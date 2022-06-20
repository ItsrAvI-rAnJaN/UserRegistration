using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationMSTest
{
    [TestClass]
    public class UnitTest1
    {
        
            [TestMethod]
            [DataRow("Ravi", "Ravi")]
            [DataRow("Ra", null)]

            [DataRow("Ranjan", "Ranjan")]
            [DataRow("R", null)]
            public void Name(string a, string expected)
            {
                ValidationMSTest validation = new ValidationMSTest();
                string actual = validation.Name(a);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [DataRow("abc@yahoo.com", "abc@yahoo.com")]
            [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
            [DataRow("abc-100@abc.net", "abc-100@abc.net")]
            [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
            [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
            [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
            [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
            public void Email(string a, string expected)
            {
                ValidationMSTest validate = new ValidationMSTest();

                string actual = validate.Email(a);

                Assert.AreEqual(expected, actual);
            }


            [TestMethod]
            [DataRow("9 9955540266", "9 9955540266")]
            [DataRow("91 9955540266", "91 9955540266")]
            [DataRow("1 1000987267", null)]
            [DataRow("919955540266", null)]
            [DataRow("91 99555", null)]
            public void Mobile(string a, string expected)
            {
                ValidationMSTest validation = new ValidationMSTest();

                string actual = validation.Mobile(a);

                Assert.AreEqual(expected, actual);
            }

            [TestMethod]
            [DataRow("8A*yurvs", "8A*yurvs")]
            [DataRow("A&utvtkhtby", null)]
            [DataRow("456lkh27", null)]
            public void Password(string a, string expected)
            {
                ValidationMSTest validation = new ValidationMSTest();

                string actual = validation.Password(a);

                Assert.AreEqual(expected, actual);
            }
        }
    
}