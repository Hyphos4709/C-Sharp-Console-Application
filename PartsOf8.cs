using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf8
    {
        NumberAsciiArt eight = new NumberAsciiArt("8");

        string _eightPart;

        public string EightPart
        {
            get { return _eightPart; }
            set
            {
                if (value == "0")
                {
                    _eightPart = eight.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _eightPart = eight.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _eightPart = eight.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _eightPart = eight.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _eightPart = eight.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _eightPart = eight.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _eightPart = "ERROR";
                }






            }

        }
        public PartsOf8() { }

        public PartsOf8(string eightPart)
        {
            EightPart = eightPart;
        }
    }
}
