using SolidPrinciples.Models;
using System.Collections.Generic;

namespace SolidPrinciples
{
    public interface IEmailSendable
    {
        void SendTripInfoEmailToDriver(DriverInfo driverInfo);
    }
}
