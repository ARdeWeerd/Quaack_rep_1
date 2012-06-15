using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Quaack_service.Service;

namespace Quaack_web.Util
{
    public static class ServiceUtil
    {
        public static ProfielService getProfielService(HttpApplicationState Application)
        {
            return (ProfielService)Application["profielService"];
        }

        public static BerichtenService getBerichtenService(HttpApplicationState Application)
        {
            return (BerichtenService)Application["berichtenService"];
        }


    }
}