using BikeApp.RideData;
using Common.FileReader;

namespace BikeApp.IpBike
{
    public class IpBikeRideImporter : RideBase
    {
        private ITableFileReader _reader;

        public IpBikeRideImporter(ITableFileReader reader)
        {
            this._reader = reader;
        }

        public override void ProcessFile()
        {

        }
    }
}
