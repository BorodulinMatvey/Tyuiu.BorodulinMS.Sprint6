using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BorodulinMS.Sprint6.Task6.V3.Lib;
namespace Tyuiu.BorodulinMS.Sprint6.Task6.V3.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = "rtvta fafafn fajfna";

            string res = ds.CollectTextFromFile(path);
            string wait = "rtvta";
            Assert.AreEqual(wait, res);
        }
    }
}
