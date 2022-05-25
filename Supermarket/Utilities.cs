using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    static class Utilities
    {
        public static void ToggleEnabled(this System.Windows.Forms.Button b)
        {
            b.Enabled = !b.Enabled;
        }

        public static void ToggleEnabled(this System.Windows.Forms.TextBox t)
        {
            t.Enabled = !t.Enabled;
        }
    }
}
