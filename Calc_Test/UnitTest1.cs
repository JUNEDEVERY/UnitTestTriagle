using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TriagleTest;

namespace TriagleTest_Test
{
    [TestClass]
    public class unitTestTriagle
    {
        [TestMethod]
        public void ShowTypeTriagle_5_and_5_and_5_returnedRAVNTRUE()
        {
            int a = 5;
            int b = 5;
            int c = 5;
            string except = "Треугольник является равносторонним";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void ShowTypeTriagle_5_and_6_and_6_returnedRAVNBEDRTRUE()
        {
            int a = 5;
            int b = 6;
            int c = 6;
            string except = "Треугольник является равнобедренным";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void ShowTypeTriagle_5_and_6_and_7_returnedRAZNTRUE()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            string except = "Треугольник является разносторонним";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// //
        /// </summary>
         [TestMethod]
        public void ShowTypeTriagle_5_and_5_and_5_returnedRAVNFALSE()
        {
            int a = 5;
            int b = 5;
            int c = 5;
            string except = "Треугольник является равнобедренным";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void ShowTypeTriagle_5_and_6_and_6_returnedRAVNBEDRFALSE()
        {
            int a = 5;
            int b = 6;
            int c = 6;
            string except = "Треугольник является разносторонним";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }
        [TestMethod]
        public void ShowTypeTriagle_5_and_6_and_7_returnedRAZNFALSE()
        {
            int a = 5;
            int b = 6;
            int c = 7;
            string except = "Треугольник является равносторонним";

            MainForm mainForm = new MainForm();

            string actual = mainForm.ShowTypeTriagle(a, b, c);
            Assert.AreEqual(except, actual);
        }


    }
   
    
}
