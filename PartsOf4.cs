using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf4
    {
        NumberAsciiArt four = new NumberAsciiArt("4");

        string _fourPart;

        public string FourPart
        {
            get { return _fourPart; }
            set
            {
                if (value == "0")
                {
                    _fourPart = four.CharValueToAscii.Substring(0, 8);
                }
                else if (value == "1")
                {
                    _fourPart = four.CharValueToAscii.Substring(8, 8);
                }
                else if (value == "2")
                {
                    _fourPart = four.CharValueToAscii.Substring(16, 8);
                }
                else if (value == "3")
                {
                    _fourPart = four.CharValueToAscii.Substring(24, 8);
                }
                else if (value == "4")
                {
                    _fourPart = four.CharValueToAscii.Substring(32, 8);
                }
                else if (value == "5")
                {
                    _fourPart = four.CharValueToAscii.Substring(40, 8);
                }
                else
                {
                    _fourPart = "ERROR";
                }






            }

        }
        public PartsOf4() { }

        public PartsOf4(string fourPart)
        {
            FourPart = fourPart;
        }
    }
}
