using PersonalDetails;
using PersonalInfoTest.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInfoTest.BusinessObjectTest
{

    public class HRTest
    {
        [Fact]
        public static void GetPeopleTest()
        {
            DataManager dataManager = new DataManager();
            List<Person> expectedPerson = dataManager.GetSampleJsonData();
            List<Person> actualPerson = HRManager.GetPeople();
            Assert.Equal(expectedPerson, actualPerson);

        }
    }
}
