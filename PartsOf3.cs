using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf3
    {
        NumberAsciiArt three = new NumberAsciiArt("3");

        string _threePart;

        public string ThreePart
        {
            get { return _threePart; }
            set
            {
                if (value == "0")
                {
                    _threePart = three.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _threePart = three.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _threePart = three.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _threePart = three.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _threePart = three.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _threePart = three.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _threePart = "ERROR";
                }






            }

        }
        public PartsOf3() { }

        public PartsOf3(string threePart)
        {
            ThreePart = threePart;
        }
    }
}

