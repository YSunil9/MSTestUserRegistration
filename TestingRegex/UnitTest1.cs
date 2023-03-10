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
        [TestMethod]
        public void TestEmail()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validEmail";
            string actualResult = objt.Email("sunil.pcs24@gmail.com");
            Assert.AreEqual(output, actualResult);
        }
        [TestMethod]
        public void TestMobile()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validMob";
            string actualResult = objt.Mobile("8709383334");
            Assert.AreEqual(output, actualResult);
        }
        [TestMethod]
        public void TestPassword()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validPassword";
            string actualResult = objt.Password("Sunil99@");
            Assert.AreEqual(output, actualResult);
        }
        [TestMethod]
        public void TestEmailSample()
        {
            RegexClassTest objt = new RegexClassTest();
            string output = "validEmailSample";
            string actualResult = objt.EmailSample("Sunil.pcs24@gmail.com");
            Assert.AreEqual(output, actualResult);
        }
    }    
}