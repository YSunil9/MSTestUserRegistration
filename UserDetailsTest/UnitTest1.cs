namespace UserDetailsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstNameTest()
        {

            string userInput = "Abc";
            bool output = RegexClassTest.FirstName(userInput);
            Assert.AreEqual(output, true);
        }
    }
}