using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    public class TripInfoLogger
    {
        private readonly ILogger logger;

        public TripInfoLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void Log(string logInfo)
        {
            logger.Log(logInfo);

        }


        //Dependency Inversion principle 
        //public void LogToGermany(string tripInfo)
        //{
        //    new GermanyLogger().Log(tripInfo);
        //}
        //public void LogToLocalStorage(string logInfo)
        //{
        //    new LocalStorageLogger().Log(logInfo);

        //}
    }

    public interface ILogger
    {
        void Log(string log);
    }


    public class GermanyLogger : ILogger
    {
        public void Log(string tripInfo)
        {
            //send to date to the Germany
        }
    }

    public class LocalStorageLogger : ILogger
    {
        public void Log(string tripInfo)
        {
            //save car localStorage
        }
    }
}
