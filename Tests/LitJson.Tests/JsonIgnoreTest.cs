using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LitJson;

namespace LitJson.Tests
{
    [TestClass]
    public class JsonIgnoreTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            TestStruct test = new TestStruct();
            Console.WriteLine(JsonMapper.ToJson(test));

        }
    }
    [TestClass]
    public class TestStruct
    {
        [JsonIngore]
        public string Ignored = "I am ignored.";
        public string NotIgnored = "I am not ignored !";
    }
}
