using MSTest_UserDetails;
using System.Runtime.ExceptionServices;
using System.Text.RegularExpressions;

namespace TestingRegex
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validName";
            string actualResult = objt.FirstName("Sunil");            
            Assert.AreEqual(output, actualResult);
        }
        [TestMethod]
        public void TestLastName()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validName";
            string actualResult = objt.LastName("Kumar");
            Assert.AreEqual(output, actualResult);
        }
    }    
}