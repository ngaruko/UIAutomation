using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vbn.Ui.Framework.PageObjects;
using Vbn.Ui.Framework.Settings;
using Vbn.Ui.Tests.Utilities;

namespace Vbn.Ui.Tests.SmokeTests
{

    
    [TestClass]
    public class QuickSearchTest : InitializationTests
    {

        [TestMethod]
        public void UserCanSearch()
        {
          
            HomePage.QuickSearch("three");
        }


    }

  
}
