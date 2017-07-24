using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    class FrameBuildout
    {
        string topTop = " _______________________________________________________________________________________________________ ";
        string topBottom = "|_______________________________________________________________________________________________________|";
        #region arrow
        PartsOfArrow arrowzero = new PartsOfArrow("0");
        PartsOfArrow arrowone = new PartsOfArrow("1");
        PartsOfArrow arrowtwo = new PartsOfArrow("2");
        PartsOfArrow arrowthree = new PartsOfArrow("3");
        PartsOfArrow arrowfour = new PartsOfArrow("4");
        PartsOfArrow arrowfive = new PartsOfArrow("5");
        #endregion

        string[] arrowList = new string[6];

        string _arrowProperty;

        public string ArrowProperty
        {
            get { return _arrowProperty; }
            set
            {
                if (value == "0")
                {
                    arrowList[0] = arrowzero.ArrowPart;
                    arrowList[1] = arrowone.ArrowPart;
                    arrowList[2] = arrowtwo.ArrowPart;
                    arrowList[3] = arrowthree.ArrowPart;
                    arrowList[4] = arrowfour.ArrowPart;
                    arrowList[5] = arrowfive.ArrowPart;
                }
            }
        }
        public NumberBuilder Exam1 { get; set; }
        public NumberBuilder Midterm { get; set; }
        public NumberBuilder Exam2 { get; set; }
        public NumberBuilder FinalExam { get; set; }
        public FrameBuildout() { }
        public FrameBuildout(NumberBuilder exam1, NumberBuilder midterm, NumberBuilder exam2, NumberBuilder finalExam)
        {
            Exam1 = exam1;
            Midterm = midterm;
            Exam2 = exam2;
            FinalExam = finalExam;
        }

        public override string ToString()
        {
            return string.Format(" _______________________________________________________________________________________________________ \n|_______________________________________________________________________________________________________|\n{0}\n |||_________________________________________________________________|||_____________________________|||\n{1}\n |||_________________________________________________________________|||_____________________________|||\n{2}\n |||_________________________________________________________________|||_____________________________|||\n{3}\n |||_________________________________________________________________|||_____________________________|||",  Exam1, Midterm,Exam2,FinalExam);
        }

       
    }
}


