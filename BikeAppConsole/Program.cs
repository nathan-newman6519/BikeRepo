using BikeApp.RideData;
using System;

namespace BikeAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //User clicks button
            //User selects file to upload and app type
            //User selects continue.


            //Call single class to generate correct IRide class.
            RideBase rideBase = RideBase.CreateRideData(RideDataApp.IpBike, "");
            //Upload file using IRide interface
            rideBase.ProcessFile();
        }
    }
}
