using System;
using BasicGP;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;

namespace UtilitiesValidationTest
{
    [TestClass]
    public class UnitTest1
    {
        public string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        //public string[] inputs;
        public List<bool> results = new List<bool>();
        public List<string> inputs = new List<string>();


        public void getTests(string filename)
        {
            string[] lines = File.ReadAllLines(@dir + filename);
            int amountOfTests = lines.Length;
            for (int i = 0; i < lines.Length; i++)
            {
                string[] lineSplit = lines[i].Split(',');
                inputs.Add(lineSplit[0]);
                results.Add(bool.Parse(lineSplit[1]));
            }
        }
        public void emptyLists()
        {
            inputs.Clear();
            results.Clear();
        }
        [TestMethod]

        public void PhoneNumberValidationTest()
        {
            getTests("\\PhoneNumberTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.PhoneNumberValidation(inputs[i]);
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }

        [TestMethod]
        public void DescriptionValidationTest()
        {
            getTests("\\DescriptionTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.DescriptionValidation(inputs[i]);
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }


        [TestMethod]
        public void AddressValidationTest()
        {
            getTests("\\AddressTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.AddressValidation("txtAddress1", inputs[i]);
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }

        [TestMethod]
        public void DOBValidationTest()
        {
            getTests("\\DOBTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.DOBValidation(DateTime.Parse(inputs[i]));
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }
        [TestMethod]
        public void NHNumberValidationTest()
        {
            getTests("\\NHNumberTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.NHNumberValidation(inputs[i]);
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }
        [TestMethod]
        public void ComboBoxValidationTest()
        {
            getTests("\\ComboBoxTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.ComboBoxValidation(Int32.Parse(inputs[i]));
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }
        [TestMethod]
        public void NameValidationTests()
        {
            getTests("\\NameTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.NameValidation(inputs[i]);
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }
        [TestMethod]
        public void DateBookingValidationTests()
        {
            getTests("\\DateBookingTests.txt");
            for (int i = 0; i < results.Count; i++)
            {
                bool actualResult = Utilities.DateBookingValidation(DateTime.Parse(inputs[i]));
                Assert.AreEqual(results[i], actualResult);
            }
            emptyLists();
        }
    }
}
