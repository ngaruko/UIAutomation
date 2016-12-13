using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vbn.Ui.Framework
{
   public interface IConfig
    {
       string GetUsername();
       string GetPassword();
       BrowserType? GetBrowser();

       //todo: Change this method to GetBaseUrl
       string GetWebsite();
       int GetPageLoadTimeOut();
       int GetElementLoadTimeOut();
    }
}
