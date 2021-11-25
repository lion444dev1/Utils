using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lioncs.Utils;

namespace UtilsTestProject
{
    [TestClass]
    public class RandomHelpertest
    {
        [TestMethod]
        public void TestString()
        {
            string result = RandomHelper.getString(25);
             result = RandomHelper.getFirstName();
             result = RandomHelper.getFirstName();
             result = RandomHelper.getPhrase(10);
        }
    }
}
