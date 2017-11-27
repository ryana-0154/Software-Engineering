using System;
using BasicGP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UtilitiesValidationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PhoneNumberValidationTest()
        {
            string txtPhoneNumber = "02075316006";

            bool actual = Utilities.PhoneNumberValidation(txtPhoneNumber);

            const bool expected = true;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void DescriptionValidationTest()
        {
            string txtDescription = "Back ache";

            bool actual = Utilities.DescriptionValidation(txtDescription);

            const bool expected = true;
            Assert.AreEqual(expected, actual);

        }

       
        [TestMethod]
        public void AddressValidationTest()
        {
            string txtAddress1 = "37 Castle Road";

            bool actual = Utilities.AddressValidation(txtAddress1);

            const bool expected = true;
            Assert.AreEqual(expected, actual);

        }
        

        [TestMethod]
        public void DOBValidationTest()
        {
            DateTime dtpDOB = new DateTime(2003,05,28);

            bool actual = Utilities.DOBValidation(dtpDOB);

            const bool expected = true;
            Assert.AreEqual(expected, actual);

        }
    }
}
