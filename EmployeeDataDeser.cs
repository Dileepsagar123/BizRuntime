using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONAPP
{
    class EmployeeDataDeser
    {
        public string ReadJsonFile(string JsonfilePath)

        {

            string json = string.Empty;

            using (StreamReader r = new StreamReader("D://EmployeeData.json"))

            {

                json = r.ReadToEnd();

                dynamic array = JsonConvert.DeserializeObject(json);

                //... read text from json file

            }

            return json;

        }
        static void Main(string[] args)
        {
            string path = @"D:\EmployeeData.json";
            EmployeeDataDeser employeeDataDeser = new EmployeeDataDeser();
            Console.WriteLine(employeeDataDeser.ReadJsonFile(path));
            Console.ReadLine();
           
        }
    }
}
