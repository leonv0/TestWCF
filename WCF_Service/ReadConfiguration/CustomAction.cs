using Microsoft.Deployment.WindowsInstaller;
using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace ReadConfiguration
{
    [Serializable]
    public class Parameter
    {
        [XmlAttribute]
        public string Name { get; set; }

        [XmlText]
        public string Value { get; set; }
    }

    public class CustomActions
    {
        // <summary> Получить параметры установки из xml. </summary>
        /// <param name="session"> Сессия инсталлятора. </param>
        /// <returns> Результат выполнения. </returns>
        [CustomAction]
        public static ActionResult GetInstallParamters(Session session)
        {
            session.Log("Begin GetInstallParamters");
            try
            {
                var currentDirectory = session["CURRENTDIRECTORY"];
                var msiPath = session["OriginalDatabase"];
                string parametersFileName = Path.GetFileNameWithoutExtension(msiPath) + "Parameters.xml";

                var parametersFilePath = Path.Combine(currentDirectory, parametersFileName);
                if (!File.Exists(parametersFilePath))
                    parametersFilePath = Path.Combine(currentDirectory, "InstallParameters.xml");

                session["SEARCHSETTINGSPATH"] = parametersFilePath;
                if (File.Exists(parametersFilePath))
                {
                    var xs = new XmlSerializer(typeof(Parameter[]), new XmlRootAttribute("InstallParameters"));
                    Parameter[] parameters;
                    using (var fs = new FileStream(parametersFilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                        parameters = (Parameter[])xs.Deserialize(fs);
                    foreach (var param in parameters)
                        session[param.Name] = param.Value;
                }
            }
            catch (Exception ex)
            {
                session["PARSEINSTALLPARAMTERSERROR"] = ex.Message;
            }
            return ActionResult.Success;
        }
    }
}
