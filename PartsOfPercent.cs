using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfPercent
    {


        ScoreBoxText score = new ScoreBoxText("6");

        string _percentPart;

        public string PercentPart
        {
            get { return _percentPart; }
            set
            {
                if (value == "0")
                {
                    _percentPart = score.BoxText.Substring(0, (score.BoxText.Length / 6));
                }
                else if (value == "1")
                {
                    _percentPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _percentPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _percentPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _percentPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _percentPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfPercent() { }

        public PartsOfPercent(string percentPart)
        {
            PercentPart = percentPart;
        }
    }
}
