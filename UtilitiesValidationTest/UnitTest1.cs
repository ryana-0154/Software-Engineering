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
        public List<DateTime> input1 = new List<DateTime>();


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
            getTests("\\PhoneNumber.txt");
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
            getTests("\\Description.txt");
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
            string txtAddress1 = "37 Castle Road";

            bool actual = Utilities.AddressValidation("txtAddress1", txtAddress1);

            const bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DOBValidationTest()
        {
            
            /*
            System.IO.StreamReader file = new System.IO.StreamReader("\\DOB.txt");
            string txt = file.ReadLine();
            DateTime dt = DateTime.Parse(txt);
            file.Close();
            */

            getTests("\\DOB.txt");
            for (int i = 0; i < results.Count; i++)
            {
                
                bool actualResult = Utilities.DOBValidation((input1[i]));
                Assert.AreEqual(results[i], actualResult);

            }
            emptyLists();




            /*   DateTime dtpDOB = new DateTime(2003, 05, 28);

            bool actual = Utilities.DOBValidation(dtpDOB);

            const bool expected = true;
            Assert.AreEqual(expected, actual);
        */
        }


    }
}
