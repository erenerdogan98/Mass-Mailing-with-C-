using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MassMailling_Core.Helper
{
    public class GlobalOperations
    {
        public void UseTryCatch(Action action)
        {
			try
			{
				action();
			}
			catch (Exception ex) // never write only Exception , because if a mistake happens , it will be very huge problem
			{
				string Exstr = Newtonsoft.Json.JsonConvert.SerializeObject(ex);	
				var logger = NLog.LogManager.GetCurrentClassLogger();
				logger.Log(LogLevel.Error, Exstr); // we manage nugget (json to dll)
				// if any error occurs , we take it on Json and we serialize it 
			}
        }

    }
}
