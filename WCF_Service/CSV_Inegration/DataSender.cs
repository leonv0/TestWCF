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
using CSV_Inegration.CSV_Inegration;

namespace CSV_Inegration
{
    internal class DataSender
    {
        string _FileName;
        private ListPersons _listpersons;
        private CSVImportClient _client;

        internal DataSender(string FileName)
        {
            //precheck
            if (FileName == null) { throw new ArgumentNullException("FileName cannot be null"); }
            if (!File.Exists(FileName)) { throw new ArgumentException("File not exists"); }
            //
            _FileName = FileName;
        }
        //
        internal void Read()
        {
            int lines = File.ReadAllLines(_FileName).Length;
            //parse file in list
            using (TextFieldParser parser = new TextFieldParser(_FileName))
            {

                int i = 0;
                
                _listpersons = new ListPersons(lines);
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

                    _listpersons.PersonList[i] = person;
                    i++;
                }
            }

        }
        //send data
        internal void SendList()
        {
            _client = new CSVImportClient();


            try
            {
                _client.SaveCSV(_listpersons);

                
            }
            catch (Exception ex)
            {
                Console.WriteLine (ex.ToString());
            }
        }
    }
}
