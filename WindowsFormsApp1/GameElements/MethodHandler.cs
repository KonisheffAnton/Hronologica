using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HronologicaForms.GameElements
{
   public static class MethodHandler
    {
        public delegate int MyEvent();
        public static MyEvent EventHandler;
        public delegate void voidDelegator();
        public static voidDelegator FormShow;
        public static voidDelegator FormClose;
    }
}
