using SolidPrinciples.Models;
using SolidPrinciples.Models.SmsModels;
using System;
using System.Net.Mail;

namespace SolidPrinciples.Car
{
    public class BaseCar
    {
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
        public void SendTripInfoSmsToDriver(DriverInfo driverInfo)
        {
            if (!string.IsNullOrEmpty(driverInfo.PhoneNumber))
            {
                var smsSender = new SmsSender();
                smsSender.SendSms(new SmsModel()
                {
                    Message = "Todays Trip",
                    PhoneNumber = driverInfo.PhoneNumber,
                    SendTime = DateTime.Now
                });
            }
        }
    }
}
