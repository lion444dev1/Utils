using lioncs.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilsTestProject
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void TestIsDate()
        {
            Assert.IsTrue(StringHelper.isDate("2/4/14"));
            Assert.IsFalse(StringHelper.isDate("22/4/14"));
            Assert.IsFalse(StringHelper.isDate("sdf"));
            Assert.IsFalse(StringHelper.isDate(""));
            Assert.IsFalse(StringHelper.isDate(null));
        }

        [TestMethod]
        public void TestIsAllNumbers()
        {
            Assert.IsFalse(StringHelper.isAllNumbers("2/4/14"));
            Assert.IsTrue(StringHelper.isAllNumbers("2342"));
            Assert.IsFalse(StringHelper.isAllNumbers(""));
            Assert.IsFalse(StringHelper.isAllNumbers(" "));
            Assert.IsFalse(StringHelper.isAllNumbers(" 23"));
            Assert.IsFalse(StringHelper.isAllNumbers(null));
        }

         [TestMethod]
        public void TestRemoveNonNumbers(){
            Assert.AreEqual("12", StringHelper.removeNonNumbers("1v2"));
            Assert.AreEqual("12", StringHelper.removeNonNumbers("12"));
            Assert.AreEqual("12", StringHelper.removeNonNumbers("12 "));
            Assert.AreEqual("12", StringHelper.removeNonNumbers("1 2"));
            Assert.AreEqual("123", StringHelper.removeNonNumbers("12.3"));
            Assert.AreEqual("12", StringHelper.removeNonNumbers(" 12"));
            Assert.AreEqual("12", StringHelper.removeNonNumbers("(12)"));

             }

         [TestMethod]
         public void TestFormatPhoneNumber()
         {
             Assert.AreEqual("(123) 456-7890", StringHelper.formatPhoneNumber("(123)456-7890"));
             Assert.AreEqual("(23)456-7890", StringHelper.formatPhoneNumber("(23)456-7890"));
             Assert.AreEqual("(123) 456-7890", StringHelper.formatPhoneNumber("(123)4567890"));
             Assert.AreEqual("(123) 456-7890", StringHelper.formatPhoneNumber("(123-456-7890"));
             Assert.AreEqual("(123) 456-7890", StringHelper.formatPhoneNumber("(123)))456-7890"));
             Assert.AreEqual("(123)-456-78900", StringHelper.formatPhoneNumber("(123)-456-78900"));
         }

         [TestMethod]
         public void TestIsValidEmailAddress()
         {
             Assert.IsTrue(StringHelper.isValidEmailAddress("michael_inoa@hotmail.com"));
             Assert.IsTrue(StringHelper.isValidEmailAddress("michael.inoa@hotmail.com"));
         }

         [TestMethod]
         public void TestprependIfNeeded()
         {
             Assert.AreEqual("name, ", StringHelper.prependIfNeeded("name", ", "));
             Assert.AreEqual("", StringHelper.prependIfNeeded("", ", "));

             Assert.AreEqual("name, date", StringHelper.prependIfNeededAndAdd("name", ", ", "date"));
             
         }

         [TestMethod]
         public void TestDST()
         {
             Assert.AreEqual("8", DateTimeHelper.getArizonaTime());
         //    Assert.AreEqual("8", DateTimeHelper.getCurrentTimeForZone("US/Arizona"));
           

         }
    }
}
