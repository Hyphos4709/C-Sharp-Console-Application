using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf5
    {
        NumberAsciiArt five = new NumberAsciiArt("5");

        string _fivePart;

        public string FivePart
        {
            get { return _fivePart; }
            set
            {
                if (value == "0")
                {
                    _fivePart = five.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _fivePart = five.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _fivePart = five.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _fivePart = five.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _fivePart = five.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _fivePart = five.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _fivePart = "ERROR";
                }






            }

        }
        public PartsOf5() { }

        public PartsOf5(string fivePart)
        {
            FivePart = fivePart;
        }
    }
}
