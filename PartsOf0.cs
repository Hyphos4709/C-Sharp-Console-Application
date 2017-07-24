using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf0
    {
        NumberAsciiArt zero = new NumberAsciiArt("0");

        string _zeroPart;

        public string ZeroPart
        {
            get { return _zeroPart; }
            set
            {
                if (value == "0")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _zeroPart = zero.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _zeroPart = "ERROR";
                }






            }

        }
        public PartsOf0() { }

        public PartsOf0(string zeroPart)
        {
            ZeroPart = zeroPart;
        }
    }
}
