using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfExam1
    {


        ScoreBoxText score = new ScoreBoxText("0");

        string _exam1Part;

        public string Exam1Part
        {
            get { return _exam1Part; }
            set
            {
                if (value == "0")
                {
                    _exam1Part = score.BoxText.Substring(0, (score.BoxText.Length / 6));
                }
                else if (value == "1")
                {
                    _exam1Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _exam1Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _exam1Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _exam1Part = score.BoxText.Substring(((score.BoxText.Length /6) * 4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _exam1Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfExam1() { }

        public PartsOfExam1(string exam1Part)
        {
            Exam1Part = exam1Part;
        }
    }
}
