using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ndGradeBook
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] currentOption = new string[4] { "1", "0", "0", "0" };
            string[] firstNumber = new string[4] { "null", "null", "null", "null" };
            string[] secondNumber = new string[4] { "null", "null", "null", "null" };

            NumberBuilder exam1 = new NumberBuilder("1", "0", "0", firstNumber[0], secondNumber[0], "0");
            NumberBuilder midterm = new NumberBuilder("0", "0", "0", firstNumber[1], secondNumber[1], "1");
            NumberBuilder exam2 = new NumberBuilder("0", "0", "0", firstNumber[2], secondNumber[2], "2");
            NumberBuilder finalexam = new NumberBuilder("0", "0", "0", firstNumber[3], secondNumber[3], "3");

            FrameBuildout frame1 = new FrameBuildout(exam1, midterm, exam2, finalexam);
            #region 1st attempt
            /*while (x == 1)
            {

                Console.Clear();
                Console.WriteLine(frame1);
                int y = 1;
                
                ConsoleKey currentSelection = Console.ReadKey().Key;
                string stringCurrentSelection = Convert.ToString(currentSelection);

                while (y == 1)
                
                {
                    



                    if (stringCurrentSelection == "Enter")
                    {
                        string currentOptionStuff = Convert.ToString(exam1.CurrentOption);
                        
                        exam1.WhichNumber1 = "0";
                        exam1.WhichNumber2 = "0";
                        if (exam1.CurrentOption == "1"||exam1.CurrentOption == "2")
                        {
                            exam1.CurrentOption = "3";
                        }
                        else if (exam1.CurrentOption == "4")
                        {
                            exam1.CurrentOption = "5";
                        }
                        Console.Clear();
                        Console.WriteLine(frame1);
                        char input1 = Console.ReadKey().KeyChar;
                        string stringInput1 = Convert.ToString(input1);
                        exam1.WhichNumber1 = stringInput1;
                        Console.Clear();
                        Console.WriteLine(frame1);
                        char input2 = Console.ReadKey().KeyChar;
                        string stringInput2 = Convert.ToString(input2);
                        exam1.WhichNumber2 = stringInput2;
                        Console.Clear();
                        Console.WriteLine(frame1);
                        ConsoleKey input3 = Console.ReadKey().Key;
                        string stringInput3 = Convert.ToString(input3);
                        if (stringInput3 == "Enter")
                        {
                            exam1.CurrentOption = "2";
                            Console.Clear();
                            Console.WriteLine(frame1);
                            Console.ReadKey();
                            y = 2;


                        }
                        else if (stringInput3 == "D0" || stringInput3 == "NumPad0")
                        {
                            exam1.CurrentOption = "4";
                            Console.Clear();
                            Console.WriteLine(frame1);
                            Console.ReadKey();
                            y = 2;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("ERROR");
                            Console.ReadKey();
                            Console.Clear();
                            Console.WriteLine(frame1);
                            Console.ReadKey();
                        }

                    }
                    if (stringCurrentSelection == "DownArrow")
                    {
                        if (exam1.CurrentOption == "2")
                        {
                            exam1.CurrentOption = "3";
                        }
                        else if (exam1.CurrentOption == "4")
                        {
                            exam1.CurrentOption = "5";
                        }
                        midterm.CurrentOption = "1";
                        Console.Clear();
                        Console.WriteLine(frame1);
                        Console.ReadKey();
                        y = 2;
                    }
                }
            }*/
            #endregion
            #region 2nd attempt
            /*int y = 2;
            while (y == 2)
            {


                switch (input1)
                {

                    case "Enter":         //if they hit enter, arrow goes away, 00% pops up                                                          
                        int x = 1;
                        while (x == 1)
                        {

                            if (exam1.CurrentOption == "0")
                            {
                                exam1.CurrentOption = "1";
                            }
                            else if (exam1.CurrentOption == "2")
                            {
                                exam1.CurrentOption = "3";
                            }
                            exam1.CurrentOption = "3";
                            exam1.WhichNumber1 = "0";
                            exam1.WhichNumber2 = "0";
                            Console.Clear();
                            Console.WriteLine(frame1);
                            exam1.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                            exam1.WhichNumber2 = "null";
                            Console.Clear();
                            Console.WriteLine(frame1);
                            exam1.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                            Console.Clear();
                            Console.WriteLine(frame1);
                            input1 = Convert.ToString(Console.ReadKey().Key);

                            if (exam1.WhichNumber1 == "1" && exam1.WhichNumber2 == "0" && (input1 == "NumPad0" || input1 == "D0" || input1 == "0"))//ran into error here because exam1.WhichNumber1 and WhichNumer2 were not returning any value so there was nothing to compare. 
                            {
                                exam1.CurrentOption = "4";
                                Console.Clear();
                                Console.WriteLine(frame1);
                              
                            }
                            else
                            {
                                exam1.CurrentOption = "2";//moving arrow outside if two digits
                                Console.Clear();
                                Console.WriteLine(frame1);
                                
                            }

                            input1 = Convert.ToString(Console.ReadKey().Key);
                           
                            x = 0;

                        }

                        break;

                    case "DownArrow":
                        if (exam1.CurrentOption == "2")
                        {
                            exam1.CurrentOption = "3";
                        }
                        else if (exam1.CurrentOption == "4")
                        {
                            exam1.CurrentOption = "5";
                        }
                        else if (exam1.CurrentOption == "1")
                        {
                            exam1.CurrentOption = "0";
                        }
                        midterm.CurrentOption = "1";
                        Console.Clear();
                        Console.WriteLine(frame1);
                        input1 = Convert.ToString(Console.ReadKey().Key);
                        if (input1 == "UpArrow")
                        {
                            input1 = "Enter";
                        }
                        


                        break;


                }

            }*/
            #endregion



            int a = 1;
            while (a == 1)
            {
                int b = 1;
                while (b == 1)
                {
                    #region arrow change stuff
                    //changing midterm to no arrow, incase of breaking through an up arrow. 
                    if (midterm.CurrentOption == "1")
                    {
                        midterm.CurrentOption = "0";
                    }
                    else if (midterm.CurrentOption == "2")
                    {
                        midterm.CurrentOption = "3";
                    }
                    else if (midterm.CurrentOption == "4")
                    {
                        midterm.CurrentOption = "5";
                    }
                    //changing final exam to no arrow, incase of breaking through a down arrow. 
                    if (finalexam.CurrentOption == "1")
                    {
                        finalexam.CurrentOption = "0";
                    }
                    else if (finalexam.CurrentOption == "2")
                    {
                        finalexam.CurrentOption = "3";
                    }
                    else if (finalexam.CurrentOption == "4")
                    {
                        finalexam.CurrentOption = "5";
                    }
                    //Changing exam1 to have arrow as this is default section. 
                    if (exam1.CurrentOption == "0")
                    {
                        exam1.CurrentOption = "1";
                    }
                    else if (exam1.CurrentOption == "3")
                    {
                        exam1.CurrentOption = "2";
                    }
                    else if (exam1.CurrentOption == "5")
                    {
                        exam1.CurrentOption = "4";
                    }
                    #endregion
                    Console.Clear();
                    Console.WriteLine(frame1);//Print initial interface
                    string input1 = Convert.ToString(Console.ReadKey().Key);//store input in variable from user to decide what to do with arrow

                    {
                        int messUp = 1;
                        while (messUp == 1)
                        {
                            switch (input1)// options from arrow on exam1
                            {

                                case "DownArrow":
                                    #region ArrowStructuring
                                    //removing arrow from exam1
                                    if (exam2.CurrentOption == "1")
                                    {
                                        exam2.CurrentOption = "0";
                                    }
                                    else if (exam2.CurrentOption == "2")
                                    {
                                        exam2.CurrentOption = "3";
                                    }
                                    else if (exam2.CurrentOption == "4")
                                    {
                                        exam2.CurrentOption = "5";
                                    }
                                    if (exam1.CurrentOption == "1")
                                    {
                                        exam1.CurrentOption = "0";
                                    }
                                    else if (exam1.CurrentOption == "2")
                                    {
                                        exam1.CurrentOption = "3";
                                    }
                                    else if (exam1.CurrentOption == "4")
                                    {
                                        exam1.CurrentOption = "5";
                                    }
                                    if (midterm.CurrentOption == "0")
                                    {
                                        midterm.CurrentOption = "1";
                                    }
                                    else if (midterm.CurrentOption == "3")
                                    {
                                        midterm.CurrentOption = "2";
                                    }
                                    else if (midterm.CurrentOption == "5")
                                    {
                                        midterm.CurrentOption = "4";
                                    }
                                    Console.Clear();
                                    Console.WriteLine(frame1);
                                    input1 = Convert.ToString(Console.ReadKey().Key);

                                    #endregion
                                    int c2 = 1;
                                    while (c2 == 1)
                                    {
                                        switch (input1)
                                        {
                                            case "Enter":
                                                #region Score Entry Structure
                                                midterm.WhichNumber1 = "0";
                                                midterm.WhichNumber2 = "0";
                                                midterm.CurrentOption = "3";
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                midterm.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                midterm.WhichNumber2 = "null";
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                midterm.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                if ((midterm.WhichNumber1 == "1" || midterm.WhichNumber1 == "D1" || midterm.WhichNumber1 == "NumPad1") && (midterm.WhichNumber2 == "0" || midterm.WhichNumber2 == "D0" || midterm.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                {
                                                    midterm.CurrentOption = "4";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }
                                                else if (input1 == "Enter")
                                                {
                                                    midterm.CurrentOption = "2";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }
                                                else
                                                {
                                                    midterm.CurrentOption = "2";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }

                                                #endregion
                                                break;
                                            case "DownArrow":
                                                #region Changing Arrow Structure
                                                if (finalexam.CurrentOption == "1")
                                                {
                                                    finalexam.CurrentOption = "0";
                                                }
                                                else if (finalexam.CurrentOption == "2")
                                                {
                                                    finalexam.CurrentOption = "3";
                                                }
                                                else if (finalexam.CurrentOption == "4")
                                                {
                                                    finalexam.CurrentOption = "5";
                                                }
                                                if (midterm.CurrentOption == "1")
                                                {
                                                    midterm.CurrentOption = "0";
                                                }
                                                else if (midterm.CurrentOption == "2")
                                                {
                                                    midterm.CurrentOption = "3";
                                                }
                                                else if (midterm.CurrentOption == "4")
                                                {
                                                    midterm.CurrentOption = "5";
                                                }
                                                if (exam2.CurrentOption == "0")
                                                {
                                                    exam2.CurrentOption = "1";
                                                }
                                                else if (exam2.CurrentOption == "3")
                                                {
                                                    exam2.CurrentOption = "2";
                                                }
                                                else if (exam2.CurrentOption == "5")
                                                {
                                                    exam2.CurrentOption = "4";
                                                }
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                #endregion
                                                int d2 = 1;
                                                while (d2 == 1)
                                                {
                                                    switch (input1)
                                                    {
                                                        case "Enter":
                                                            #region Score Entry Structure
                                                            exam2.WhichNumber1 = "0";
                                                            exam2.WhichNumber2 = "0";
                                                            exam2.CurrentOption = "3";
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            exam2.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                            exam2.WhichNumber2 = "null";
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            exam2.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                            if ((exam2.WhichNumber1 == "1" || exam2.WhichNumber1 == "D1" || exam2.WhichNumber1 == "NumPad1") && (exam2.WhichNumber2 == "0" || exam2.WhichNumber2 == "D0" || exam2.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                            {
                                                                exam2.CurrentOption = "4";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }
                                                            else if (input1 == "Enter")
                                                            {
                                                                exam2.CurrentOption = "2";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }
                                                            else
                                                            {
                                                                exam2.CurrentOption = "2";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }

                                                            #endregion
                                                            break;
                                                        case "DownArrow":
                                                            #region ChanginArrowStructure
                                                            if (exam2.CurrentOption == "1")
                                                            {
                                                                exam2.CurrentOption = "0";
                                                            }
                                                            else if (exam2.CurrentOption == "2")
                                                            {
                                                                exam2.CurrentOption = "3";
                                                            }
                                                            else if (exam2.CurrentOption == "4")
                                                            {
                                                                exam2.CurrentOption = "5";
                                                            }
                                                            if (exam1.CurrentOption == "1")
                                                            {
                                                                exam1.CurrentOption = "0";
                                                            }
                                                            else if (exam1.CurrentOption == "2")
                                                            {
                                                                exam1.CurrentOption = "3";
                                                            }
                                                            else if (exam1.CurrentOption == "4")
                                                            {
                                                                exam1.CurrentOption = "5";
                                                            }
                                                            if (finalexam.CurrentOption == "0")
                                                            {
                                                                finalexam.CurrentOption = "1";
                                                            }
                                                            else if (finalexam.CurrentOption == "3")
                                                            {
                                                                finalexam.CurrentOption = "2";
                                                            }
                                                            else if (finalexam.CurrentOption == "5")
                                                            {
                                                                finalexam.CurrentOption = "4";
                                                            }
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                            #endregion
                                                            int f2 = 1;
                                                            while (f2 == 1)
                                                            {
                                                                switch (input1)
                                                                {
                                                                    case "Enter":
                                                                        #region Score Entry Structure
                                                                        finalexam.WhichNumber1 = "0";
                                                                        finalexam.WhichNumber2 = "0";
                                                                        finalexam.CurrentOption = "3";
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        finalexam.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                                        finalexam.WhichNumber2 = "null";
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        finalexam.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        if ((finalexam.WhichNumber1 == "1" || finalexam.WhichNumber1 == "D1" || finalexam.WhichNumber1 == "NumPad1") && (finalexam.WhichNumber2 == "0" || finalexam.WhichNumber2 == "D0" || finalexam.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                                        {
                                                                            finalexam.CurrentOption = "4";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }
                                                                        else if (input1 == "Enter")
                                                                        {
                                                                            finalexam.CurrentOption = "2";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }
                                                                        else
                                                                        {
                                                                            finalexam.CurrentOption = "2";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }

                                                                        #endregion
                                                                        break;
                                                                    case "DownArrow":
                                                                        b = 2;
                                                                        f2 = 2;
                                                                        c2 = 2;
                                                                        d2 = 2;
                                                                        messUp = 2;
                                                                        break;
                                                                    case "UpArrow":
                                                                        f2 = 2;
                                                                        d2 = 2;
                                                                        input1 = "DownArrow";

                                                                        break;
                                                                }
                                                            }//end while f2
                                                            break;
                                                        case "UpArrow":
                                                            d2 = 2;
                                                            c2 = 2;
                                                            input1 = "DownArrow";

                                                            break;
                                                    }
                                                }//end while d2
                                                break;
                                            case "UpArrow":

                                                c2 = 2;
                                                messUp = 2;
                                                input1 = "DownArrow";
                                                break;
                                        }//ends switch
                                    }//end while c2
                                    break;
                                case "Enter":
                                    #region Score Entry Structure
                                    exam1.WhichNumber1 = "0";
                                    exam1.WhichNumber2 = "0";
                                    exam1.CurrentOption = "3";
                                    Console.Clear();
                                    Console.WriteLine(frame1);
                                    exam1.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                    exam1.WhichNumber2 = "null";
                                    Console.Clear();
                                    Console.WriteLine(frame1);
                                    exam1.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                    Console.Clear();
                                    Console.WriteLine(frame1);
                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                    //Console.Beep(10000, 300);
                                    if ((exam1.WhichNumber1 == "1" || exam1.WhichNumber1 == "D1" || exam1.WhichNumber1 == "NumPad1") && (exam1.WhichNumber2 == "0" || exam1.WhichNumber2 == "D0" || exam1.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                    {
                                        exam1.CurrentOption = "4";
                                        Console.Clear();
                                        Console.WriteLine(frame1);
                                        input1 = Convert.ToString(Console.ReadKey().Key);
                                    }
                                    else if (input1 == "Enter")
                                    {
                                        exam1.CurrentOption = "2";
                                        Console.Clear();
                                        Console.WriteLine(frame1);
                                        input1 = Convert.ToString(Console.ReadKey().Key);
                                    }
                                    else
                                    {
                                        exam1.CurrentOption = "2";
                                        Console.Clear();
                                        Console.WriteLine(frame1);
                                        input1 = Convert.ToString(Console.ReadKey().Key);
                                    }

                                    #endregion
                                    break;
                                case "UpArrow":
                                    #region ChanginArrowStructure
                                    if (exam2.CurrentOption == "1")
                                    {
                                        exam2.CurrentOption = "0";
                                    }
                                    else if (exam2.CurrentOption == "2")
                                    {
                                        exam2.CurrentOption = "3";
                                    }
                                    else if (exam2.CurrentOption == "4")
                                    {
                                        exam2.CurrentOption = "5";
                                    }
                                    if (exam1.CurrentOption == "1")
                                    {
                                        exam1.CurrentOption = "0";
                                    }
                                    else if (exam1.CurrentOption == "2")
                                    {
                                        exam1.CurrentOption = "3";
                                    }
                                    else if (exam1.CurrentOption == "4")
                                    {
                                        exam1.CurrentOption = "5";
                                    }
                                    if (finalexam.CurrentOption == "0")
                                    {
                                        finalexam.CurrentOption = "1";
                                    }
                                    else if (finalexam.CurrentOption == "3")
                                    {
                                        finalexam.CurrentOption = "2";
                                    }
                                    else if (finalexam.CurrentOption == "5")
                                    {
                                        finalexam.CurrentOption = "4";
                                    }
                                    Console.Clear();
                                    Console.WriteLine(frame1);
                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                    #endregion
                                    int c = 1;
                                    while (c == 1)
                                    {
                                        switch (input1)//options from final exam
                                        {
                                            case "Enter":
                                                #region Score Entry Structure
                                                finalexam.WhichNumber1 = "0";
                                                finalexam.WhichNumber2 = "0";
                                                finalexam.CurrentOption = "3";
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                finalexam.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                finalexam.WhichNumber2 = "null";
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                finalexam.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                if ((finalexam.WhichNumber1 == "1" || finalexam.WhichNumber1 == "D1" || finalexam.WhichNumber1 == "NumPad1") && (finalexam.WhichNumber2 == "0" || finalexam.WhichNumber2 == "D0" || finalexam.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                {
                                                    finalexam.CurrentOption = "4";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }
                                                else if (input1 == "Enter")
                                                {
                                                    finalexam.CurrentOption = "2";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }
                                                else
                                                {
                                                    finalexam.CurrentOption = "2";
                                                    Console.Clear();
                                                    Console.WriteLine(frame1);
                                                    input1 = Convert.ToString(Console.ReadKey().Key);
                                                }

                                                #endregion
                                                break;
                                            case "UpArrow":
                                                #region Changing Arrow Structure
                                                if (finalexam.CurrentOption == "1")
                                                {
                                                    finalexam.CurrentOption = "0";
                                                }
                                                else if (finalexam.CurrentOption == "2")
                                                {
                                                    finalexam.CurrentOption = "3";
                                                }
                                                else if (finalexam.CurrentOption == "4")
                                                {
                                                    finalexam.CurrentOption = "5";
                                                }
                                                if (midterm.CurrentOption == "1")
                                                {
                                                    midterm.CurrentOption = "0";
                                                }
                                                else if (midterm.CurrentOption == "2")
                                                {
                                                    midterm.CurrentOption = "3";
                                                }
                                                else if (midterm.CurrentOption == "4")
                                                {
                                                    midterm.CurrentOption = "5";
                                                }
                                                if (exam2.CurrentOption == "0")
                                                {
                                                    exam2.CurrentOption = "1";
                                                }
                                                else if (exam2.CurrentOption == "3")
                                                {
                                                    exam2.CurrentOption = "2";
                                                }
                                                else if (exam2.CurrentOption == "5")
                                                {
                                                    exam2.CurrentOption = "4";
                                                }
                                                Console.Clear();
                                                Console.WriteLine(frame1);
                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                #endregion

                                                int d = 1;
                                                while (d == 1)
                                                {
                                                    switch (input1)//options from Exam2
                                                    {
                                                        case "Enter":
                                                            #region Score Entry Structure
                                                            exam2.WhichNumber1 = "0";
                                                            exam2.WhichNumber2 = "0";
                                                            exam2.CurrentOption = "3";
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            exam2.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                            exam2.WhichNumber2 = "null";
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            exam2.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                            if ((exam2.WhichNumber1 == "1" || exam2.WhichNumber1 == "D1" || exam2.WhichNumber1 == "NumPad1") && (exam2.WhichNumber2 == "0" || exam2.WhichNumber2 == "D0" || exam2.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                            {
                                                                exam2.CurrentOption = "4";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }
                                                            else if (input1 == "Enter")
                                                            {
                                                                exam2.CurrentOption = "2";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }
                                                            else
                                                            {
                                                                exam2.CurrentOption = "2";
                                                                Console.Clear();
                                                                Console.WriteLine(frame1);
                                                                input1 = Convert.ToString(Console.ReadKey().Key);
                                                            }

                                                            #endregion
                                                            break;
                                                        case "UpArrow":
                                                            #region ArrowStructure
                                                            if (exam2.CurrentOption == "1")
                                                            {
                                                                exam2.CurrentOption = "0";
                                                            }
                                                            else if (exam2.CurrentOption == "2")
                                                            {
                                                                exam2.CurrentOption = "3";
                                                            }
                                                            else if (exam2.CurrentOption == "4")
                                                            {
                                                                exam2.CurrentOption = "5";
                                                            }
                                                            if (exam1.CurrentOption == "1")
                                                            {
                                                                exam1.CurrentOption = "0";
                                                            }
                                                            else if (exam1.CurrentOption == "2")
                                                            {
                                                                exam1.CurrentOption = "3";
                                                            }
                                                            else if (exam1.CurrentOption == "4")
                                                            {
                                                                exam1.CurrentOption = "5";
                                                            }
                                                            if (midterm.CurrentOption == "0")
                                                            {
                                                                midterm.CurrentOption = "1";
                                                            }
                                                            else if (midterm.CurrentOption == "3")
                                                            {
                                                                midterm.CurrentOption = "2";
                                                            }
                                                            else if (midterm.CurrentOption == "5")
                                                            {
                                                                exam1.CurrentOption = "4";
                                                            }
                                                            Console.Clear();
                                                            Console.WriteLine(frame1);
                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                            #endregion

                                                            int f = 1;
                                                            while (f == 1)
                                                            {
                                                                switch (input1)//options from midterm
                                                                {

                                                                    case "Enter":
                                                                        #region Score Entry Structure
                                                                        midterm.WhichNumber1 = "0";
                                                                        midterm.WhichNumber2 = "0";
                                                                        midterm.CurrentOption = "3";
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        midterm.WhichNumber1 = Convert.ToString(Console.ReadKey().KeyChar);
                                                                        midterm.WhichNumber2 = "null";
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        midterm.WhichNumber2 = Convert.ToString(Console.ReadKey().KeyChar);
                                                                        Console.Clear();
                                                                        Console.WriteLine(frame1);
                                                                        input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        if ((midterm.WhichNumber1 == "1" || midterm.WhichNumber1 == "D1" || midterm.WhichNumber1 == "NumPad1") && (midterm.WhichNumber2 == "0" || midterm.WhichNumber2 == "D0" || midterm.WhichNumber2 == "NumPad0") && (input1 == "0" || input1 == "NumPad0" || input1 == "D0"))
                                                                        {
                                                                            midterm.CurrentOption = "4";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }
                                                                        else if (input1 == "Enter")
                                                                        {
                                                                            midterm.CurrentOption = "2";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }
                                                                        else
                                                                        {
                                                                            midterm.CurrentOption = "2";
                                                                            Console.Clear();
                                                                            Console.WriteLine(frame1);
                                                                            input1 = Convert.ToString(Console.ReadKey().Key);
                                                                        }

                                                                        #endregion
                                                                        break;
                                                                    case "UpArrow":
                                                                        b = 2;
                                                                        f = 2;
                                                                        c = 2;
                                                                        d = 2;
                                                                        messUp = 2;
                                                                        break;
                                                                    case "DownArrow":
                                                                        f = 2;
                                                                        d = 2;
                                                                        input1 = "UpArrow";

                                                                        break;
                                                                }
                                                            }


                                                            break;
                                                        case "DownArrow":
                                                            d = 2;
                                                            c = 2;
                                                            input1 = "UpArrow";
                                                            break;
                                                    }// ends options from exam2 switch
                                                }//ends while d

                                                break;
                                            case "DownArrow":

                                                c = 2;
                                                messUp = 2;
                                                input1 = "UpArrow";
                                                break;
                                        }//end options from final exam switch
                                    }//end while c

                                    break;


                            }//end options from exam1 switch
                        }//end while Messup
                    }
                }
            }
        }
    }
}

