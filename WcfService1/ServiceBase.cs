using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService1
{
    public class ServiceBase
    {
        private readonly ILog log;
        public ServiceBase()
        {
            //Load log4net Configuration
            XmlConfigurator.Configure();
            //Get logger
            log = LogManager.GetLogger(typeof(ServiceBase));
            //Start logging
            log.Debug("ServiceBase Constructor Call");
           

        }
    }
}