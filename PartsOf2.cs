using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf2
    {
        NumberAsciiArt two = new NumberAsciiArt("2");

        string _twoPart;

        public string TwoPart
        {
            get { return _twoPart; }
            set
            {
                if (value == "0")
                {
                    _twoPart = two.CharValueToAscii.Substring(0, 6);
                }
                else if (value == "1")
                {
                    _twoPart = two.CharValueToAscii.Substring(6, 6);
                }
                else if (value == "2")
                {
                    _twoPart = two.CharValueToAscii.Substring(12, 6);
                }
                else if (value == "3")
                {
                    _twoPart = two.CharValueToAscii.Substring(18, 6);
                }
                else if (value == "4")
                {
                    _twoPart = two.CharValueToAscii.Substring(24, 6);
                }
                else if (value == "5")
                {
                    _twoPart = two.CharValueToAscii.Substring(30, 6);
                }
                else
                {
                    _twoPart = "ERROR";
                }






            }

        }
        public PartsOf2() { }

        public PartsOf2(string twoPart)
        {
            TwoPart = twoPart;
        }
    }
}
