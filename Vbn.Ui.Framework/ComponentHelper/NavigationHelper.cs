using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vbn.Ui.Framework.BaseClasses;
using Vbn.Ui.Framework.Settings;

namespace Vbn.Ui.Framework.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string Url)
        {
            //ObjectRepository.Driver.Navigate().GoToUrl(Url);
Driver.Instance.Navigate().GoToUrl(Url);
        }
    }
}
