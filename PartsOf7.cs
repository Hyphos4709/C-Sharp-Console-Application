using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf7
    {
        NumberAsciiArt seven = new NumberAsciiArt("7");

        string _sevenPart;

        public string SevenPart
        {
            get { return _sevenPart; }
            set
            {
                if (value == "0")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(0, 8);
                }
                else if (value == "1")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(8, 8);
                }
                else if (value == "2")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(16, 8);
                }
                else if (value == "3")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(24, 8);
                }
                else if (value == "4")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(32, 8);
                }
                else if (value == "5")
                {
                    _sevenPart = seven.CharValueToAscii.Substring(40, 8);
                }
                else
                {
                    _sevenPart = "ERROR";
                }






            }

        }
        public PartsOf7() { }

        public PartsOf7(string sevenPart)
        {
            SevenPart = sevenPart;
        }


    }


}
