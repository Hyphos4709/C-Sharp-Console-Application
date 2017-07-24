using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfExam2
    {


        ScoreBoxText score = new ScoreBoxText("2");

        string _exam2Part;

        public string Exam2Part
        {
            get { return _exam2Part; }
            set
            {
                if (value == "0")
                {
                    _exam2Part = score.BoxText.Substring(0, (score.BoxText.Length / 6));
                }
                else if (value == "1")
                {
                    _exam2Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _exam2Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _exam2Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _exam2Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _exam2Part = score.BoxText.Substring(((score.BoxText.Length / 6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfExam2() { }

        public PartsOfExam2(string exam2Part)
        {
            Exam2Part = exam2Part;
        }
    }
}
