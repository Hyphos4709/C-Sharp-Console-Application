using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOf9
    {
        NumberAsciiArt nine = new NumberAsciiArt("9");

        string _ninePart;

        public string NinePart
        {
            get { return _ninePart; }
            set
            {
                if (value == "0")
                {
                    _ninePart = nine.CharValueToAscii.Substring(0, 7);
                }
                else if (value == "1")
                {
                    _ninePart = nine.CharValueToAscii.Substring(7, 7);
                }
                else if (value == "2")
                {
                    _ninePart = nine.CharValueToAscii.Substring(14, 7);
                }
                else if (value == "3")
                {
                    _ninePart = nine.CharValueToAscii.Substring(21, 7);
                }
                else if (value == "4")
                {
                    _ninePart = nine.CharValueToAscii.Substring(28, 7);
                }
                else if (value == "5")
                {
                    _ninePart = nine.CharValueToAscii.Substring(35, 7);
                }
                else
                {
                    _ninePart = "ERROR";
                }






            }

        }
        public PartsOf9() { }

        public PartsOf9(string ninePart)
        {
            NinePart = ninePart;
        }
    }
}
