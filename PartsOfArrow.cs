using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfArrow
    {


        ScoreBoxText score = new ScoreBoxText("5");

        string _arrowPart;

        public string ArrowPart
        {
            get { return _arrowPart; }
            set
            {
                if (value == "0")
                {
                    _arrowPart = score.BoxText.Substring(0, (score.BoxText.Length / 6));
                }
                else if (value == "1")
                {
                    _arrowPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _arrowPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _arrowPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _arrowPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _arrowPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfArrow() { }

        public PartsOfArrow(string arrowPart)
        {
            ArrowPart = arrowPart;
        }
    }
}
