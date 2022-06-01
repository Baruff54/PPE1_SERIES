using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Security.Cryptography;
using System.Text;

namespace TestsUnitaires
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(this.HasherSalerMDP("aa"), "997d8b7c641284746b78a6fc1257daef91b1692811e6b4d2bbed163448cf3386") ;
        }
        public string HasherSalerMDP(string mdp)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes("*//" + mdp + "**/"));

                // Convert byte array to a string   
                StringBuilder mdpHasher = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    mdpHasher.Append(bytes[i].ToString("x2"));
                }
                return mdpHasher.ToString();
            }
        }
    }
}
