using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelExtractor
{
    public class Logger
    {
        public event EventHandler<string> DisplayMsg;

        public void Log(string MsgToDisplay)
        {
            DisplayMsg?.Invoke(this, MsgToDisplay);
        }
    }
}
