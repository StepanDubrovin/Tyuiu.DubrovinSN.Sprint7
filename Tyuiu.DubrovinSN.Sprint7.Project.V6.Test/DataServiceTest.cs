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
            DataService ds = new DataService();
            string path = @"C:\C#\Tyuiu.DubrovinSN.Sprint7\Tyuiu.DubrovinSN.Sprint7.Project.V6\bin\Debug\Информация о пациентах";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);

        }
        [TestMethod]
        public void TestSortMin()
        {
            DataService ds = new DataService();
            string[,] matrix =
            {
                { "Имя", "Возраст", "Срок_лечения" },
                { "Иван", "25", "80" },
                { "Петр", "30", "65" },
                { "Данил", "22", "75" },
                { "Степан", "28", "90" }
            };
            int numberColumn = 2; 
            string[,] sortedMatrix =
            {
                { "Имя", "Возраст", "Срок_лечения" },
                { "Степан", "28", "90" },
                { "Иван", "25", "80" },
                { "Данил", "22", "75" },
                { "Петр", "30", "65" }
            };
            string[,] res = ds.SortYb(matrix, numberColumn);
            Assert.AreEqual(sortedMatrix.GetLength(0), res.GetLength(0));
            Assert.AreEqual(sortedMatrix.GetLength(1), res.GetLength(1));

            for (int i = 0; i < sortedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < sortedMatrix.GetLength(1); j++)
                {
                    Assert.AreEqual(sortedMatrix[i, j], res[i, j]);
                }
            }
        }
        [TestMethod]
        public void SortMax()
        {
            DataService ds = new DataService();
            string[,] matrix =
            {
                { "Имя", "Возраст", "Срок_лечения" },
                { "Иван", "25", "80" },
                { "Петр", "30", "65" },
                { "Данил", "22", "75" },
                { "Степан", "28", "90" }
            };
            int numberColumn = 2; 
            string[,] expectedSortedMatrix =
            {
                { "Имя", "Возраст", "Срок_лечения" },
                { "Петр", "30", "65" },
                { "Данил", "22", "75" },
                { "Иван", "25", "80" },
                { "Степан", "28", "90" }
            };
            string[,] result = ds.SortVozr(matrix, numberColumn);
            Assert.AreEqual(expectedSortedMatrix.GetLength(0), result.GetLength(0));
            Assert.AreEqual(expectedSortedMatrix.GetLength(1), result.GetLength(1));

            for (int i = 0; i < expectedSortedMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < expectedSortedMatrix.GetLength(1); j++)
                {
                    Assert.AreEqual(expectedSortedMatrix[i, j], result[i, j]);
                }
            }
        }

    }
}
