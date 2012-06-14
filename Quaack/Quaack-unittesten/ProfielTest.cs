using Quaack_domein.model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Quaack_unittesten
{
    
    
    /// <summary>
    ///This is a test class for ProfielTest and is intended
    ///to contain all ProfielTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProfielTest
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
        ///A test for Profiel Constructor
        ///</summary>
        [TestMethod()]
        public void ProfielConstructorTest()
        {
            Profiel target = new Profiel();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for AvatarLokatie
        ///</summary>
        [TestMethod()]
        public void AvatarLokatieTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.AvatarLokatie = expected;
            actual = target.AvatarLokatie;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Berichten
        ///</summary>
        [TestMethod()]
        public void BerichtenTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            List<Bericht> expected = null; // TODO: Initialize to an appropriate value
            List<Bericht> actual;
            target.Berichten = expected;
            actual = target.Berichten;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Emailadres
        ///</summary>
        [TestMethod()]
        public void EmailadresTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Emailadres = expected;
            actual = target.Emailadres;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GeblokkeerdDoor
        ///</summary>
        [TestMethod()]
        public void GeblokkeerdDoorTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            List<Profiel> expected = null; // TODO: Initialize to an appropriate value
            List<Profiel> actual;
            target.GeblokkeerdDoor = expected;
            actual = target.GeblokkeerdDoor;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Geblokkerd
        ///</summary>
        [TestMethod()]
        public void GeblokkerdTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.Geblokkerd = expected;
            actual = target.Geblokkerd;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GeblokkerdeGebruikers
        ///</summary>
        [TestMethod()]
        public void GeblokkerdeGebruikersTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            List<Profiel> expected = null; // TODO: Initialize to an appropriate value
            List<Profiel> actual;
            target.GeblokkerdeGebruikers = expected;
            actual = target.GeblokkerdeGebruikers;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MobielNummer
        ///</summary>
        [TestMethod()]
        public void MobielNummerTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.MobielNummer = expected;
            actual = target.MobielNummer;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Naam
        ///</summary>
        [TestMethod()]
        public void NaamTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Naam = expected;
            actual = target.Naam;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Profielschets
        ///</summary>
        [TestMethod()]
        public void ProfielschetsTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Profielschets = expected;
            actual = target.Profielschets;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for VerificationPendingDate
        ///</summary>
        [TestMethod()]
        public void VerificationPendingDateTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.VerificationPendingDate = expected;
            actual = target.VerificationPendingDate;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Wachtwoord
        ///</summary>
        [TestMethod()]
        public void WachtwoordTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Wachtwoord = expected;
            actual = target.Wachtwoord;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for WijzigingEmail
        ///</summary>
        [TestMethod()]
        public void WijzigingEmailTest()
        {
            Profiel target = new Profiel(); // TODO: Initialize to an appropriate value
            DateTime expected = new DateTime(); // TODO: Initialize to an appropriate value
            DateTime actual;
            target.WijzigingEmail = expected;
            actual = target.WijzigingEmail;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
