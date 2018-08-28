using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    public static class HelpClass
    {
        public static void VisibleOrNot(bool ShowOrHide, params System.Windows.Forms.Control [] C)
    {
            foreach (var item in C)
            {
                item.Visible = ShowOrHide; 
            }
    }

        public static void EnabledOrDisabled (bool EnabledOrDisabled, params System.Windows.Forms.Control [] C)
        {
            foreach (var item in C)
            {
                item.Enabled = EnabledOrDisabled; 
            }
        }





}
}
