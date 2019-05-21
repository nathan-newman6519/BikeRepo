using BikeApp.RideData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.BikeApp.IpBike
{
    [TestClass]
    public class IpBikeRideImporterTests
    {
        [DataTestMethod]
        [DataRow(RideDataApp.IpBike, "IpBikeRideImporter")]
        public void TestMethod1(RideDataApp appType, string expectedClassType)
        {
            RideBase value = RideBase.CreateRideData(appType, "");

            Assert.AreEqual(value.GetType().Name, expectedClassType);
        }
    }
}
