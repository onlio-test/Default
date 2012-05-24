using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for Class1Test and is intended
    ///to contain all Class1Test Unit Tests
    ///</summary>
    [TestClass()]
    public class Class1Test
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Class1 Constructor
        ///</summary>
        [TestMethod()]
        public void Class1ConstructorTest()
        {
            Class1 target = new Class1();
            Assert.IsNotNull(target);
        }

        /// <summary>
        ///A test for Test
        ///</summary>
        [TestMethod()]
        public void TestTest()
        {
            Class1 target = new Class1();
            string value = null;

            int actual;
            try
            {
                actual = target.Test(value);
            }
            catch (ArgumentNullException)
            {
                // continue
            }

            value = string.Empty;
            int expected = 0;
            actual = target.Test(value);
            Assert.AreEqual(expected, actual);

            value = "test";
            expected = 4;
            actual = target.Test(value);
            Assert.AreEqual(expected, actual);
        }
    }
}
