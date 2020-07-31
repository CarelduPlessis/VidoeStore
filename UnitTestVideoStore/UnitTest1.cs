using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vidoe_Store;
using System.Data;

namespace UnitTestVideoStore
{
    [TestClass]
    public class UnitTest1
    {
        // test the database connection by returning database name from Database Server.
        [TestMethod]
        public void TestDBConnection()
        {
            VideoStoreDBClass db = new VideoStoreDBClass();
            Assert.AreEqual(db.ReturnDBName(), "VideoStoreDB");
        }

        // test the database connection by checking the state (if connection is open or close) on lauching the program. 
        [TestMethod]
        public void TestDBConnectionState()
        {
            VideoStoreDBClass db = new VideoStoreDBClass();
            
            Assert.AreNotEqual(db.ReturnDBConnectionState(), ConnectionState.Open);
        }
    }
}
