using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class NumberAsciiArt
    {

        string _charValueToAscii;

        public string CharValueToAscii 
        {
            get { return _charValueToAscii; }
            set
            {
                if (value == "0")
                {
                    _charValueToAscii = @"  ___   / _ \ | | | || | | || |_| | \___/ ";
                }
                else if (value == "1")
                {
                    _charValueToAscii = @" __ /_ | | | | | | | |_|";
                }
                else if (value == "2")
                {
                    _charValueToAscii = @" ___  |__ \    ) |  / /  / /_ |____|";
                }
                else if (value == "3")
                {
                    _charValueToAscii = @" ____  |___ \   __) | |__ <  ___) ||____/ ";
                }
                else if (value == "4")
                {
                    _charValueToAscii = @" _  _   | || |  | || |_ |__   _|   | |     |_|  ";
                }
                else if (value == "5")
                {
                    _charValueToAscii = @" _____ | ____|| |__  |___ \  ___) ||____/ ";
                }
                else if (value == "6")
                {
                    _charValueToAscii = @"   __    / /   / /_  | '_ \ | (_) | \___/ ";
                }
                else if (value == "7")
                {
                    _charValueToAscii = @" ______ |____  |    / /    / /    / /    /_/    ";
                }
                else if (value == "8")
                {
                    _charValueToAscii = @"  ___   / _ \ | (_) | > _ < | (_) | \___/ ";
                }
                else if (value == "9")
                {
                    _charValueToAscii = @"  ___   / _ \ | (_) | \__, |   / /   /_/  ";
                }
            }
        }

        public NumberAsciiArt (string charValueToAscii)
        {
            CharValueToAscii = charValueToAscii;
        }
        


    }
}
