using SolidPrinciples.Models;

namespace SolidPrinciples
{
    public interface ISmsSendable
    {
        void SendTripInfoSmsToDriver(DriverInfo driverInfo);

      
    }
}
