using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Interfaces;
using Microsoft.VisualBasic.FileIO;
using System.Runtime.Serialization;
using System.ServiceModel.Description;
using System.ServiceModel;


namespace CSV_Inegration
{
    internal class DataSender
    {
        string _FileName;
        private ImportCSVServiceClient _client;

        internal DataSender(string FileName)
        {
            //precheck
            if (FileName == null) { throw new ArgumentNullException("FileName cannot be null"); }
            if (!File.Exists(FileName)) { throw new ArgumentException("File not exists"); }
            //
            _FileName = FileName;
        }
        //
        internal void Send()
        {
            _client = new ImportCSVServiceClient();
            //parse file in list
            using (TextFieldParser parser = new TextFieldParser(_FileName))
            {

                
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while (!parser.EndOfData)
                {
                    
                    string[] fields = parser.ReadFields();
                    Person person = new Person
                    {
                        Flight_Number = fields[0],
                        Flight_Sheduled_Time = new TimeSpan(DateTime.Parse(fields[1]).Hour, DateTime.Parse(fields[1]).Minute, 0),
                        Flight_Sheduled_Date = DateTime.Parse(fields[2]).Date,
                        Estimate_Arrival = fields[3] != "" ? DateTime.Parse(fields[3]) : (DateTime?)null,
                        Arrival = fields[4] != "" ? DateTime.Parse(fields[4]) : (DateTime?)null,
                        Name = fields[5],
                        Reservation_Number = fields[6],
                        DocumentNumber = fields[7]
                    };
                    try
                    {
                        _client.SaveCSV(person);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                        return;
                    }
                }
                parser.Close();
            }

        }
        //send data
        
    }
}
