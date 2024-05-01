using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using PersonalDetails;

namespace PersonalInfoTest.Utility
{
    public class DataManager
    {
        public DataManager() { }
        public List<Person> GetSampleJsonData()
        {
            string filename = @"D:/TAP/23April/PersonalInfo/PersonalInfoTest/SampleData/PersonInfo.json";
            string jsonString = File.ReadAllText(filename);
            List<Person> jsonPeople = JsonSerializer.Deserialize<List<Person>>(jsonString);
            
            return jsonPeople;
        }
    }
}
