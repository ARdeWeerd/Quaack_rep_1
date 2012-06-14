using Quaack_domein.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Quaack_unittesten
{
    
    
    /// <summary>
    ///This is a test class for BerichtTest and is intended
    ///to contain all BerichtTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BerichtTest
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
        ///A test for Bericht Constructor
        ///</summary>
        [TestMethod()]
        public void BerichtConstructorTest()
        {
            Bericht target = new Bericht();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for DatumGeplaatst
        ///</summary>
        [TestMethod()]
        public void DatumGeplaatstTest()
        {
            Bericht target = new Bericht(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.DatumGeplaatst = expected;
            actual = target.DatumGeplaatst;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReactieOp
        ///</summary>
        [TestMethod()]
        public void ReactieOpTest()
        {
            Bericht target = new Bericht(); // TODO: Initialize to an appropriate value
            Bericht expected = null; // TODO: Initialize to an appropriate value
            Bericht actual;
            target.ReactieOp = expected;
            actual = target.ReactieOp;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Reacties
        ///</summary>
        [TestMethod()]
        public void ReactiesTest()
        {
            Bericht target = new Bericht(); // TODO: Initialize to an appropriate value
            List<Bericht> expected = null; // TODO: Initialize to an appropriate value
            List<Bericht> actual;
            target.Reacties = expected;
            actual = target.Reacties;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Tekst
        ///</summary>
        [TestMethod()]
        public void TekstTest()
        {
            Bericht target = new Bericht(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Tekst = expected;
            actual = target.Tekst;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Verwijderd
        ///</summary>
        [TestMethod()]
        public void VerwijderdTest()
        {
            Bericht target = new Bericht(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            target.Verwijderd = expected;
            actual = target.Verwijderd;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
