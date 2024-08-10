using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacroSim
{
    public class PCMessage
    {
        public int ButtonNumber { get; set; }

        public Color ButtonColor { get; set; }

        public string DisplayText { get; set; }

        public PCMessage()
        {
            ButtonNumber = -1;
            ButtonColor = Color.Black;
            DisplayText = string.Empty;
        }
    }
}
