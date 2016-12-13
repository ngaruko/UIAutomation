using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vbn.Ui.Framework.CustomExceptions
{
   public class NoSuitableBrowserFoundException:Exception
    {
       public NoSuitableBrowserFoundException(string message)
           : base(message)
        {
            
        }

    }
}
