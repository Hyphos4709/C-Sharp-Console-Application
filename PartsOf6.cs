using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf6
    {
        NumberAsciiArt six = new NumberAsciiArt("6");

        string _sixPart;

        public string SixPart
        {
            get { return _sixPart; }
            set
            {
                if (value == "0")
                {
                    _sixPart = six.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _sixPart = six.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _sixPart = six.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _sixPart = six.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _sixPart = six.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _sixPart = six.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _sixPart = "ERROR";
                }






            }

        }
        public PartsOf6() { }

        public PartsOf6(string sixPart)
        {
            SixPart = sixPart;
        }
    }
}
