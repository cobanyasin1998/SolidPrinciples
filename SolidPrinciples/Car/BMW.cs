using SolidPrinciples.Models;
using SolidPrinciples.Models.SmsModels;
using System;
using System.Collections.Generic;
using System.Net.Mail;

namespace SolidPrinciples.Car
{
    public class BMW : BaseCar, IEmailSendable,IMultipleEmailSendable
    {

        public override double GetCostPerKM()
        {
            return 1.5;
        }

        public void Go()
        {
            Console.WriteLine("Car is now going....");
        }

        public void SendTripInfoEmailToDriver(DriverInfo driverInfo)
        {
            if (!string.IsNullOrEmpty(driverInfo.EmailAddress))
            {
                var mailMessage = new MailMessage();
                mailMessage.To.Add(driverInfo.EmailAddress);

                var client = new SmtpClient("mail.mercedes.com", 587);
                client.Send(mailMessage);
            }
        }

        public void SendTripIntoEmailToDrivers(List<DriverInfo> drivers)
        {
            foreach (var driver in drivers)
            {
                if (!string.IsNullOrEmpty(driver.PhoneNumber))
                {
                    var smsSender = new SmsSender();
                    smsSender.SendSms(new SmsModel()
                    {
                        Message = "Todays Trip",
                        PhoneNumber = driver.PhoneNumber,
                        SendTime = DateTime.Now
                    });
                }
            }
        }

        public void Stop()
        {
            Console.WriteLine("Car has stopped....");
        }
    }
}
