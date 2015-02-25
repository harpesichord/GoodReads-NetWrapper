using System;
using GoodReads_NetWrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoodReads_NetWrapper_Test
{
    /// <summary>
    ///This is a test class for GoodReadsTest and is intended
    ///to contain all GoodReadsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GoodReadsTest
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

        #endregion Additional test attributes

        /// <summary>
        ///A test for GetBookID
        ///</summary>
        [TestMethod()]
        public void GetBookIDTest()
        {
            string DeveloperKey = DevelopersKey.Key;
            GoodReads target = new GoodReads(DeveloperKey);
            string isbn = "0345451325";
            long expected = 60229;
            long actual;
            actual = target.GetBookID(isbn);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}