using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf1
    {
        NumberAsciiArt one = new NumberAsciiArt("1");

        string _onePart;

        public string OnePart
        {
            get { return _onePart; }
            set
            {
                if (value == "0")
                {
                    _onePart = one.CharValueToAscii.Substring(0, 4);
                }
                else if (value == "1")
                {
                    _onePart = one.CharValueToAscii.Substring(4, 4);
                }
                else if (value == "2")
                {
                    _onePart = one.CharValueToAscii.Substring(8, 4);
                }
                else if (value == "3")
                {
                    _onePart = one.CharValueToAscii.Substring(12, 4);
                }
                else if (value == "4")
                {
                    _onePart = one.CharValueToAscii.Substring(16, 4);
                }
                else if (value == "5")
                {
                    _onePart = one.CharValueToAscii.Substring(20, 4);
                }
                else
                {
                    _onePart = "ERROR";
                }






            }

        }
        public PartsOf1() { }

        public PartsOf1(string onePart)
        {
            OnePart = onePart;
        }
    }
}


