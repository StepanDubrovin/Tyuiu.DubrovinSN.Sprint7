using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DubrovinSN.Sprint7.Project.V6.Lib;
using System.IO;

namespace Tyuiu.DubrovinSN.Sprint7.Project.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckFile()
        {
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint7\Tyuiu.DubrovinSN.Sprint7.Project.V6\bin\Debug\Информация о пациентах";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
    }
}
