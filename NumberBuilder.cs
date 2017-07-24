using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    class NumberBuilder
    {


        #region formatting
        string exam1maxlength = "                        ";
        string midtermmaxlength = "               ";
        string exam2maxlength = "                      ";
        string verticalborder = " ||| ";
        #endregion
        #region PartsOf0
        PartsOf0 zerozero = new PartsOf0("0");
        PartsOf0 zeroone = new PartsOf0("1");
        PartsOf0 zerotwo = new PartsOf0("2");
        PartsOf0 zerothree = new PartsOf0("3");
        PartsOf0 zerofour = new PartsOf0("4");
        PartsOf0 zerofive = new PartsOf0("5");
        #endregion
        #region PartsOf1
        PartsOf1 onezero = new PartsOf1("0");
        PartsOf1 oneone = new PartsOf1("1");
        PartsOf1 onetwo = new PartsOf1("2");
        PartsOf1 onethree = new PartsOf1("3");
        PartsOf1 onefour = new PartsOf1("4");
        PartsOf1 onefive = new PartsOf1("5");
        #endregion
        #region PartsOf2
        PartsOf2 twozero = new PartsOf2("0");
        PartsOf2 twoone = new PartsOf2("1");
        PartsOf2 twotwo = new PartsOf2("2");
        PartsOf2 twothree = new PartsOf2("3");
        PartsOf2 twofour = new PartsOf2("4");
        PartsOf2 twofive = new PartsOf2("5");
        #endregion
        #region PartsOf3
        PartsOf3 threezero = new PartsOf3("0");
        PartsOf3 threeone = new PartsOf3("1");
        PartsOf3 threetwo = new PartsOf3("2");
        PartsOf3 threethree = new PartsOf3("3");
        PartsOf3 threefour = new PartsOf3("4");
        PartsOf3 threefive = new PartsOf3("5");
        #endregion
        #region PartsOf4
        PartsOf4 fourzero = new PartsOf4("0");
        PartsOf4 fourone = new PartsOf4("1");
        PartsOf4 fourtwo = new PartsOf4("2");
        PartsOf4 fourthree = new PartsOf4("3");
        PartsOf4 fourfour = new PartsOf4("4");
        PartsOf4 fourfive = new PartsOf4("5");
        #endregion
        #region PartsOf5
        PartsOf5 fivezero = new PartsOf5("0");
        PartsOf5 fiveone = new PartsOf5("1");
        PartsOf5 fivetwo = new PartsOf5("2");
        PartsOf5 fivethree = new PartsOf5("3");
        PartsOf5 fivefour = new PartsOf5("4");
        PartsOf5 fivefive = new PartsOf5("5");
        #endregion
        #region PartsOf6
        PartsOf6 sixzero = new PartsOf6("0");
        PartsOf6 sixone = new PartsOf6("1");
        PartsOf6 sixtwo = new PartsOf6("2");
        PartsOf6 sixthree = new PartsOf6("3");
        PartsOf6 sixfour = new PartsOf6("4");
        PartsOf6 sixfive = new PartsOf6("5");
        #endregion
        #region PartsOf7
        PartsOf7 sevenzero = new PartsOf7("0");
        PartsOf7 sevenone = new PartsOf7("1");
        PartsOf7 seventwo = new PartsOf7("2");
        PartsOf7 seventhree = new PartsOf7("3");
        PartsOf7 sevenfour = new PartsOf7("4");
        PartsOf7 sevenfive = new PartsOf7("5");
        #endregion
        #region PartsOf8
        PartsOf8 eightzero = new PartsOf8("0");
        PartsOf8 eightone = new PartsOf8("1");
        PartsOf8 eighttwo = new PartsOf8("2");
        PartsOf8 eightthree = new PartsOf8("3");
        PartsOf8 eightfour = new PartsOf8("4");
        PartsOf8 eightfive = new PartsOf8("5");
        #endregion
        #region PartsOf9
        PartsOf9 ninezero = new PartsOf9("0");
        PartsOf9 nineone = new PartsOf9("1");
        PartsOf9 ninetwo = new PartsOf9("2");
        PartsOf9 ninethree = new PartsOf9("3");
        PartsOf9 ninefour = new PartsOf9("4");
        PartsOf9 ninefive = new PartsOf9("5");
        #endregion
        #region PartsOfExam1
        PartsOfExam1 exam1zero = new PartsOfExam1("0");
        PartsOfExam1 exam1one = new PartsOfExam1("1");
        PartsOfExam1 exam1two = new PartsOfExam1("2");
        PartsOfExam1 exam1three = new PartsOfExam1("3");
        PartsOfExam1 exam1four = new PartsOfExam1("4");
        PartsOfExam1 exam1five = new PartsOfExam1("5");
        #endregion
        #region PartsOfMidterm
        PartsOfMidterm midtermzero = new PartsOfMidterm("0");
        PartsOfMidterm midtermone = new PartsOfMidterm("1");
        PartsOfMidterm midtermtwo = new PartsOfMidterm("2");
        PartsOfMidterm midtermthree = new PartsOfMidterm("3");
        PartsOfMidterm midtermfour = new PartsOfMidterm("4");
        PartsOfMidterm midtermfive = new PartsOfMidterm("5");
        #endregion
        #region PartsOfExam2
        PartsOfExam2 exam2zero = new PartsOfExam2("0");
        PartsOfExam2 exam2one = new PartsOfExam2("1");
        PartsOfExam2 exam2two = new PartsOfExam2("2");
        PartsOfExam2 exam2three = new PartsOfExam2("3");
        PartsOfExam2 exam2four = new PartsOfExam2("4");
        PartsOfExam2 exam2five = new PartsOfExam2("5");
        #endregion
        #region FinalExam
        PartsOfFinalExam finalexamzero = new PartsOfFinalExam("0");
        PartsOfFinalExam finalexamone = new PartsOfFinalExam("1");
        PartsOfFinalExam finalexamtwo = new PartsOfFinalExam("2");
        PartsOfFinalExam finalexamthree = new PartsOfFinalExam("3");
        PartsOfFinalExam finalexamfour = new PartsOfFinalExam("4");
        PartsOfFinalExam finalexamfive = new PartsOfFinalExam("5");
        #endregion
        #region arrow
        PartsOfArrow arrowzero = new PartsOfArrow("0");
        PartsOfArrow arrowone = new PartsOfArrow("1");
        PartsOfArrow arrowtwo = new PartsOfArrow("2");
        PartsOfArrow arrowthree = new PartsOfArrow("3");
        PartsOfArrow arrowfour = new PartsOfArrow("4");
        PartsOfArrow arrowfive = new PartsOfArrow("5");
        #endregion
        #region Lists
        string[] array1 = new string[6];
        string[] array2 = new string[6];
        string[] whichtest = new string[6];
        string[] arrowList = new string[6];
        string[] percentList = new string[6];
        #endregion
        #region PartsOfPercent
        PartsOfPercent percentzero = new PartsOfPercent("0");
        PartsOfPercent percentone = new PartsOfPercent("1");
        PartsOfPercent percenttwo = new PartsOfPercent("2");
        PartsOfPercent percentthree = new PartsOfPercent("3");
        PartsOfPercent percentfour = new PartsOfPercent("4");
        PartsOfPercent percentfive = new PartsOfPercent("5");

        #endregion
        string b = "";

        int x = 0;

        string _currentOption;
        string _percentProperty;
        string _arrowProperty;
        string _whichNumber1;
        string _whichNumber2;
        string _whichTest;




        public string CurrentOption
        {
            get { return _currentOption; }
            set
            {
                if (value == "0")
                {
                    x = 0;
                    _currentOption = "0";
                }
                else if (value == "1")
                {
                    x = 1;
                    _currentOption = "1";
                }
                else if (value == "2")
                {
                    x = 2;
                    _currentOption = "2";
                }
                else if (value == "3")
                {
                    x = 3;
                    _currentOption = "3";

                }
                else if (value == "4")
                {
                    x = 4;
                    _currentOption = "4";
                }
                else if (value == "5")
                {
                    x = 5;
                    _currentOption = "5";
                }
            }
        }
        public string PercentProperty
        {
            get { return _percentProperty; }
            set
            {
                if (value == "0")
                {
                    percentList[0] = percentzero.PercentPart;
                    percentList[1] = percentone.PercentPart;
                    percentList[2] = percenttwo.PercentPart;
                    percentList[3] = percentthree.PercentPart;
                    percentList[4] = percentfour.PercentPart;
                    percentList[5] = percentfive.PercentPart;
                }

            }
        }
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
        #region Properties
        public string WhichNumber1
        {
            get { return _whichNumber1; }
            set
            {
                if (value == "0")
                {
                    array1[0] = zerozero.ZeroPart;
                    array1[1] = zeroone.ZeroPart;
                    array1[2] = zerotwo.ZeroPart;
                    array1[3] = zerothree.ZeroPart;
                    array1[4] = zerofour.ZeroPart;
                    array1[5] = zerofive.ZeroPart;
                    _whichNumber1 = "0";

                }
                else if (value == "null")
                {
                    for (int i = 0; i < array1.Length; i++)
                    {
                        array1[i] = " ";
                    }
                    _whichNumber1 = "null";
                }
                else if (value == "1" || value == "D1" || value == "NumPad1")
                {
                    array1[0] = onezero.OnePart;
                    array1[1] = oneone.OnePart;
                    array1[2] = onetwo.OnePart;
                    array1[3] = onethree.OnePart;
                    array1[4] = onefour.OnePart;
                    array1[5] = onefive.OnePart;
                    _whichNumber1 = "1";

                }
                else if (value == "2" || value == "D2" || value == "NumPad2")
                {
                    array1[0] = twozero.TwoPart;
                    array1[1] = twoone.TwoPart;
                    array1[2] = twotwo.TwoPart;
                    array1[3] = twothree.TwoPart;
                    array1[4] = twofour.TwoPart;
                    array1[5] = twofive.TwoPart;
                    _whichNumber1 = "2";

                }
                else if (value == "3" || value == "D3" || value == "NumPad3")
                {
                    array1[0] = threezero.ThreePart;
                    array1[1] = threeone.ThreePart;
                    array1[2] = threetwo.ThreePart;
                    array1[3] = threethree.ThreePart;
                    array1[4] = threefour.ThreePart;
                    array1[5] = threefive.ThreePart;
                    _whichNumber1 = "3";

                }
                else if (value == "4" || value == "D4" || value == "NumPad4")
                {
                    array1[0] = fourzero.FourPart;
                    array1[1] = fourone.FourPart;
                    array1[2] = fourtwo.FourPart;
                    array1[3] = fourthree.FourPart;
                    array1[4] = fourfour.FourPart;
                    array1[5] = fourfive.FourPart;
                    _whichNumber1 = "4";

                }
                else if (value == "5" || value == "D5" || value == "NumPad5")
                {
                    array1[0] = fivezero.FivePart;
                    array1[1] = fiveone.FivePart;
                    array1[2] = fivetwo.FivePart;
                    array1[3] = fivethree.FivePart;
                    array1[4] = fivefour.FivePart;
                    array1[5] = fivefive.FivePart;
                    _whichNumber1 = "5";

                }
                else if (value == "6" || value == "D6" || value == "NumPad6")
                {
                    array1[0] = sixzero.SixPart;
                    array1[1] = sixone.SixPart;
                    array1[2] = sixtwo.SixPart;
                    array1[3] = sixthree.SixPart;
                    array1[4] = sixfour.SixPart;
                    array1[5] = sixfive.SixPart;
                    _whichNumber1 = "6";

                }
                else if (value == "7" || value == "D7" || value == "NumPad7")
                {
                    array1[0] = sevenzero.SevenPart;
                    array1[1] = sevenone.SevenPart;
                    array1[2] = seventwo.SevenPart;
                    array1[3] = seventhree.SevenPart;
                    array1[4] = sevenfour.SevenPart;
                    array1[5] = sevenfive.SevenPart;
                    _whichNumber1 = "7";

                }
                else if (value == "8" || value == "D8" || value == "NumPad8")
                {
                    array1[0] = eightzero.EightPart;
                    array1[1] = eightone.EightPart;
                    array1[2] = eighttwo.EightPart;
                    array1[3] = eightthree.EightPart;
                    array1[4] = eightfour.EightPart;
                    array1[5] = eightfive.EightPart;
                    _whichNumber1 = "8";

                }
                else if (value == "9" || value == "D9" || value == "NumPad9")
                {
                    array1[0] = ninezero.NinePart;
                    array1[1] = nineone.NinePart;
                    array1[2] = ninetwo.NinePart;
                    array1[3] = ninethree.NinePart;
                    array1[4] = ninefour.NinePart;
                    array1[5] = ninefive.NinePart;
                    _whichNumber1 = "9";

                }
            }
        }
        public string WhichNumber2
        {
            get { return _whichNumber2; }
            set
            {
                if (value == "0" || value == "D0" || value == "NumPad0")
                {
                    array2[0] = zerozero.ZeroPart;
                    array2[1] = zeroone.ZeroPart;
                    array2[2] = zerotwo.ZeroPart;
                    array2[3] = zerothree.ZeroPart;
                    array2[4] = zerofour.ZeroPart;
                    array2[5] = zerofive.ZeroPart;
                    _whichNumber2 = "0";

                }
                else if (value == "null")
                {
                    for (int i = 0; i < array2.Length; i++)
                    {
                        array2[i] = " ";
                    }
                    _whichNumber2 = "null";
                }
                else if (value == "1" || value == "D1" || value == "NumPad1")
                {
                    array2[0] = onezero.OnePart;
                    array2[1] = oneone.OnePart;
                    array2[2] = onetwo.OnePart;
                    array2[3] = onethree.OnePart;
                    array2[4] = onefour.OnePart;
                    array2[5] = onefive.OnePart;
                    _whichNumber1 = "1";

                }
                else if (value == "2" || value == "D2" || value == "NumPad2")
                {
                    array2[0] = twozero.TwoPart;
                    array2[1] = twoone.TwoPart;
                    array2[2] = twotwo.TwoPart;
                    array2[3] = twothree.TwoPart;
                    array2[4] = twofour.TwoPart;
                    array2[5] = twofive.TwoPart;
                    _whichNumber2 = "2";

                }
                else if (value == "3" || value == "D3" || value == "NumPad3")
                {
                    array2[0] = threezero.ThreePart;
                    array2[1] = threeone.ThreePart;
                    array2[2] = threetwo.ThreePart;
                    array2[3] = threethree.ThreePart;
                    array2[4] = threefour.ThreePart;
                    array2[5] = threefive.ThreePart;
                    _whichNumber2 = "3";

                }
                else if (value == "4" || value == "D4" || value == "NumPad4")
                {
                    array2[0] = fourzero.FourPart;
                    array2[1] = fourone.FourPart;
                    array2[2] = fourtwo.FourPart;
                    array2[3] = fourthree.FourPart;
                    array2[4] = fourfour.FourPart;
                    array2[5] = fourfive.FourPart;
                    _whichNumber2 = "4";

                }
                else if (value == "5" || value == "D5" || value == "NumPad5")
                {
                    array2[0] = fivezero.FivePart;
                    array2[1] = fiveone.FivePart;
                    array2[2] = fivetwo.FivePart;
                    array2[3] = fivethree.FivePart;
                    array2[4] = fivefour.FivePart;
                    array2[5] = fivefive.FivePart;
                    _whichNumber2 = "5";

                }
                else if (value == "6" || value == "D6" || value == "NumPad6")
                {
                    array2[0] = sixzero.SixPart;
                    array2[1] = sixone.SixPart;
                    array2[2] = sixtwo.SixPart;
                    array2[3] = sixthree.SixPart;
                    array2[4] = sixfour.SixPart;
                    array2[5] = sixfive.SixPart;
                    _whichNumber2 = "6";

                }
                else if (value == "7" || value == "D7" || value == "NumPad7")
                {
                    array2[0] = sevenzero.SevenPart;
                    array2[1] = sevenone.SevenPart;
                    array2[2] = seventwo.SevenPart;
                    array2[3] = seventhree.SevenPart;
                    array2[4] = sevenfour.SevenPart;
                    array2[5] = sevenfive.SevenPart;
                    _whichNumber2 = "7";

                }
                else if (value == "8" || value == "D8" || value == "NumPad8")
                {
                    array2[0] = eightzero.EightPart;
                    array2[1] = eightone.EightPart;
                    array2[2] = eighttwo.EightPart;
                    array2[3] = eightthree.EightPart;
                    array2[4] = eightfour.EightPart;
                    array2[5] = eightfive.EightPart;
                    _whichNumber2 = "8";

                }
                else if (value == "9" || value == "D9" || value == "NumPad9")
                {
                    array2[0] = ninezero.NinePart;
                    array2[1] = nineone.NinePart;
                    array2[2] = ninetwo.NinePart;
                    array2[3] = ninethree.NinePart;
                    array2[4] = ninefour.NinePart;
                    array2[5] = ninefive.NinePart;
                    _whichNumber2 = "9";

                }
            }
        }
        #endregion
        public string WhichTest
        {
            get { return _whichTest; }
            set
            {
                if (value == "0")
                {
                    whichtest[0] = exam1zero.Exam1Part + exam1maxlength;
                    whichtest[1] = exam1one.Exam1Part + exam1maxlength;
                    whichtest[2] = exam1two.Exam1Part + exam1maxlength;
                    whichtest[3] = exam1three.Exam1Part + exam1maxlength;
                    whichtest[4] = exam1four.Exam1Part + exam1maxlength;
                    whichtest[5] = exam1five.Exam1Part + exam1maxlength;

                }
                else if (value == "1")
                {
                    whichtest[0] = midtermzero.MidtermPart + midtermmaxlength;
                    whichtest[1] = midtermone.MidtermPart + midtermmaxlength;
                    whichtest[2] = midtermtwo.MidtermPart + midtermmaxlength;
                    whichtest[3] = midtermthree.MidtermPart + midtermmaxlength;
                    whichtest[4] = midtermfour.MidtermPart + midtermmaxlength;
                    whichtest[5] = midtermfive.MidtermPart + midtermmaxlength;

                }
                else if (value == "2")
                {
                    whichtest[0] = exam2zero.Exam2Part + exam2maxlength;
                    whichtest[1] = exam2one.Exam2Part + exam2maxlength;
                    whichtest[2] = exam2two.Exam2Part + exam2maxlength;
                    whichtest[3] = exam2three.Exam2Part + exam2maxlength;
                    whichtest[4] = exam2four.Exam2Part + exam2maxlength;
                    whichtest[5] = exam2five.Exam2Part + exam2maxlength;
                }
                else if (value == "3")
                {
                    whichtest[0] = finalexamzero.FinalExamPart;
                    whichtest[1] = finalexamone.FinalExamPart;
                    whichtest[2] = finalexamtwo.FinalExamPart;
                    whichtest[3] = finalexamthree.FinalExamPart;
                    whichtest[4] = finalexamfour.FinalExamPart;
                    whichtest[5] = finalexamfive.FinalExamPart;
                }
            }

        }




        public NumberBuilder(string currentOption, string percentProperty, string arrowProperty, string whichNumber1, string whichNumber2, string whichtest)
        {
            CurrentOption = currentOption;
            PercentProperty = percentProperty;
            ArrowProperty = arrowProperty;
            WhichNumber1 = whichNumber1;
            WhichNumber2 = whichNumber2;
            WhichTest = whichtest;

        }

        public override string ToString()
        {
            if (x == 0)//TWO NUMBERS, NO PERCENT, NO ARROW
            {
                SpaceAFterNumberMath spaces = new SpaceAFterNumberMath(array1[0].Length, array2[0].Length);

                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + spaces + verticalborder,
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + spaces + verticalborder,
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + spaces + verticalborder,
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + spaces + verticalborder,
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + spaces + verticalborder,
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + spaces + verticalborder);
            }
            else if (x == 1)//TWO NUMBERS WITH NO PERCENT, BUT HAS ARROW
            {

                SpaceAFterNumberMath spaces = new SpaceAFterNumberMath(array1[0].Length, array2[0].Length);

                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + spaces + verticalborder + arrowList[0],
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + spaces + verticalborder + arrowList[1],
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + spaces + verticalborder + arrowList[2],
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + spaces + verticalborder + arrowList[3],
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + spaces + verticalborder + arrowList[4],
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + spaces + verticalborder + arrowList[5]);
            }
            else if (x == 2)//TWO NUMBERS WITH PERCENT WITH ARROW
            {
                SpaceAFterPercent spaces = new SpaceAFterPercent(array1[0].Length, array2[0].Length);

                //for (int i = 0; i < 6; i++)
                //    Console.WriteLine("{0}",
                //   verticalborder + whichtest[i] + verticalborder + array1[i] + array2[i] + percentList[i] + spaces + verticalborder + arrowList[i]);

                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",

                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + percentList[0] + spaces + verticalborder + arrowList[0],
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + percentList[1] + spaces + verticalborder + arrowList[1],
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + percentList[2] + spaces + verticalborder + arrowList[2],
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + percentList[3] + spaces + verticalborder + arrowList[3],
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + percentList[4] + spaces + verticalborder + arrowList[4],
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + percentList[5] + spaces + verticalborder + arrowList[5]);
            }
            else if (x == 3)//TWO NUMBERS WITH PERCENT WITHOUT ARROW
            {
                SpaceAFterPercent spaces = new SpaceAFterPercent(array1[0].Length, array2[0].Length);


                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + percentList[0] + spaces + verticalborder,
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + percentList[1] + spaces + verticalborder,
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + percentList[2] + spaces + verticalborder,
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + percentList[3] + spaces + verticalborder,
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + percentList[4] + spaces + verticalborder,
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + percentList[5] + spaces + verticalborder);
            }
            else if (x == 4)//100% WITH ARROW
            {
                HundredSpacing spaces = new HundredSpacing(array1[0].Length, array2[0].Length, zerozero.ZeroPart.Length);


                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + zerozero.ZeroPart + percentList[0] + spaces + verticalborder + arrowList[0],
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + zeroone.ZeroPart + percentList[1] + spaces + verticalborder + arrowList[1],
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + zerotwo.ZeroPart + percentList[2] + spaces + verticalborder + arrowList[2],
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + zerothree.ZeroPart + percentList[3] + spaces + verticalborder + arrowList[3],
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + zerofour.ZeroPart + percentList[4] + spaces + verticalborder + arrowList[4],
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + zerofive.ZeroPart + percentList[5] + spaces + verticalborder + arrowList[5]);
            }
            else//100% NO ARROW
            {
                HundredSpacing spaces = new HundredSpacing(array1[0].Length, array2[0].Length, zerozero.ZeroPart.Length);


                return string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}",
                   verticalborder + whichtest[0] + verticalborder + array1[0] + array2[0] + zerozero.ZeroPart + percentList[0] + spaces + verticalborder,
                   verticalborder + whichtest[1] + verticalborder + array1[1] + array2[1] + zeroone.ZeroPart + percentList[1] + spaces + verticalborder,
                   verticalborder + whichtest[2] + verticalborder + array1[2] + array2[2] + zerotwo.ZeroPart + percentList[2] + spaces + verticalborder,
                   verticalborder + whichtest[3] + verticalborder + array1[3] + array2[3] + zerothree.ZeroPart + percentList[3] + spaces + verticalborder,
                   verticalborder + whichtest[4] + verticalborder + array1[4] + array2[4] + zerofour.ZeroPart + percentList[4] + spaces + verticalborder,
                   verticalborder + whichtest[5] + verticalborder + array1[5] + array2[5] + zerofive.ZeroPart + percentList[5] + spaces + verticalborder);
            }
           

        }
        public string FunctionalStuff()
        {
            return string.Format(_currentOption);
        }

    }
}


public class SpaceAFterNumberMath
{

    int _x;
    int _y;

    public int X { get; set; }
    public int Y { get; set; }

    public SpaceAFterNumberMath() { }
    public SpaceAFterNumberMath(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        string spaces = "";
        int nbrOfSpaces = 27 - (X + Y);
        for (int i = 0; i < nbrOfSpaces; i++)
        {
            spaces = spaces + " ";
        }

        return string.Format(spaces);
    }


}
public class SpaceAFterPercent
{

    int _x;
    int _y;

    public int X { get; set; }
    public int Y { get; set; }

    public SpaceAFterPercent() { }
    public SpaceAFterPercent(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override string ToString()
    {
        string spaces = "";
        int nbrOfSpaces = 20 - (X + Y);
        for (int i = 0; i < nbrOfSpaces; i++)
        {
            spaces = spaces + " ";
        }

        return string.Format(spaces);
    }


}

public class HundredSpacing
{

    int _x;
    int _y;
    int _z;

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public HundredSpacing() { }
    public HundredSpacing(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;

    }

    public override string ToString()
    {
        string spaces = "";
        int nbrOfSpaces = 20 - (X + Y + Z);
        for (int i = 0; i < nbrOfSpaces; i++)
        {
            spaces = spaces + " ";
        }

        return string.Format(spaces);
    }


}

/*public class LengthFigureOuter
{
    public string String1 { get; set; }
    public string String2 { get; set; }
    public string String3 { get; set; }
    public string String4 { get; set; }
    public string String5 { get; set; }
    public string String6 { get; set; }
    public string String7 { get; set; }
    public string String8 { get; set; }
    public string String9 { get; set; }

    public LengthFigureOuter() { }

    public LengthFigureOuter(string string1, string string2, string string3, string string4, string string5, string string6, string string7, string string8, string string9)
    {
        String1 = string1;
        String2 = string2;
        String3 = string3;
        String4 = string4;
        String5 = string5;
        String6 = string6;
        String7 = string7;
        String8 = string8;
        String9 = string9;

    }

    public int Function()
    {
        return (String1.Length + String2.Length + String3.Length + String4.Length + String5.Length + String6.Length + String7.Length + String8.Length + String9.Length)/6;
    }


}*/

