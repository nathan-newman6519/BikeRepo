using BikeApp.IpBike;
using Common.FileReader;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeApp.RideData
{
    public abstract class RideBase
    {
        public static RideBase CreateRideData(RideDataApp rideData, string fileName)
        {
            if (rideData == RideDataApp.IpBike)
            {
                return new IpBikeRideImporter(new CSVReader(fileName));
            }

            throw new Exception("Unknown ride app.");
        }

        public abstract void ProcessFile();
    }
}
