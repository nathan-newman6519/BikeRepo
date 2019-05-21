using BikeApp.RideData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests.BikeApp.RideData
{
    [TestClass]
    public class RideBaseTests
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
