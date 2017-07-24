using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfMidterm
    {


        ScoreBoxText score = new ScoreBoxText("1");

        string _midtermPart;

        public string MidtermPart
        {
            get { return _midtermPart; }
            set
            {
                if (value == "0")
                {
                    _midtermPart = score.BoxText.Substring(0, (score.BoxText.Length / 6) );
                }
                else if (value == "1")
                {
                    _midtermPart = score.BoxText.Substring(((score.BoxText.Length/6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _midtermPart = score.BoxText.Substring(((score.BoxText.Length/6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _midtermPart = score.BoxText.Substring(((score.BoxText.Length/6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _midtermPart = score.BoxText.Substring(((score.BoxText.Length/6) * 4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _midtermPart = score.BoxText.Substring(((score.BoxText.Length/6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfMidterm() { }

        public PartsOfMidterm(string midtermPart)
        {
            MidtermPart = midtermPart;
        }
    }
}
