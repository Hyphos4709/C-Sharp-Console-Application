using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    public class PartsOfFinalExam
    {


        ScoreBoxText score = new ScoreBoxText("3");

        string _finalExamPart;

        public string FinalExamPart
        {
            get { return _finalExamPart; }
            set
            {
                if (value == "0")
                {
                    _finalExamPart = score.BoxText.Substring(0, (score.BoxText.Length / 6));
                }
                else if (value == "1")
                {
                    _finalExamPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 1), (score.BoxText.Length / 6));
                }
                else if (value == "2")
                {
                    _finalExamPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 2), (score.BoxText.Length / 6));
                }
                else if (value == "3")
                {
                    _finalExamPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 3), (score.BoxText.Length / 6));
                }
                else if (value == "4")
                {
                    _finalExamPart = score.BoxText.Substring(((score.BoxText.Length /6)*4), (score.BoxText.Length / 6));
                }
                else if (value == "5")
                {
                    _finalExamPart = score.BoxText.Substring(((score.BoxText.Length / 6) * 5), (score.BoxText.Length / 6));
                }
            }
        }

        public PartsOfFinalExam() { }

        public PartsOfFinalExam(string finalExamPart)
        {
            FinalExamPart = finalExamPart;
        }
    }
}
