using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Data;
using Data.DataModel;
using Data.Functions; 


namespace Testing
{
    [TestClass]
    public class TestsForSign
    {

        readonly DBContext PBContext = DbInstance.Instance;

        [TestMethod]
        // Test case: inputEmail is not on database 
        public void TestSignIn01()
        {
            // Arrange 
            string inputEmail = "notOnDB@gmail.com";
            string inputPassword = "noPassword";
            List<bool> actual = new List<bool>();
            List<bool> expected = new List<bool>();
            expected.Add(false); // index 0, email
            expected.Add(false); // index 1, password 
            // Act 
            actual = ExistingUser.SignIn(inputEmail, inputPassword);
            // Assert 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        // Test case: inputEmail is on database, but wrong password
        public void TestSignIn02()
        {
            // Arrange 
            string inputEmail = "test@test.com";
            string inputPassword = "noPassword";
            List<bool> actual = new List<bool>();
            List<bool> expected = new List<bool>();
            expected.Add(true); // index 0, email
            expected.Add(false); // index 1, password 
            // Act 
            actual = ExistingUser.SignIn(inputEmail, inputPassword);
            // Assert 
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        // Test case: inputEmail is on database, and correct password
        public void TestSignIn03()
        {
            // Arrange 
            string inputEmail = "test@test.com";
            string inputPassword = "123abc";
            List<bool> actual = new List<bool>();
            List<bool> expected = new List<bool>();
            expected.Add(true); // index 0, email
            expected.Add(true); // index 1, password 
            // Act 
            actual = ExistingUser.SignIn(inputEmail, inputPassword);
            // Assert 
            CollectionAssert.AreEqual(expected, actual);
        }

    } // end of: TestsForSign class 
}
