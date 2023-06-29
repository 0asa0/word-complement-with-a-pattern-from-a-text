using System;
using System.Globalization;
using System.Linq;

namespace WordWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text,textlow, pattern, patternlow;
            int i = 0;
            

            Console.WriteLine("Please enter a text.");
            text = Console.ReadLine();                                          //Receiving text input from the user.
            textlow = text.ToLower();                                              
            

            char[] chararray = textlow.ToCharArray();                           //Transferring text to char array to check the suitability of alphabets and symbols used.

            do
            {
                if (chararray[i] == 'a' | chararray[i] == 'b' | chararray[i] == 'c' | chararray[i] == 'd' | chararray[i] == 'e' | chararray[i] == 'f' | chararray[i] == 'g' |
                        chararray[i] == 'h' | chararray[i] == 'i' | chararray[i] == 'j' | chararray[i] == 'k' | chararray[i] == 'l' | chararray[i] == 'm' | chararray[i] == 'n' |
                         chararray[i] == 'o' | chararray[i] == 'p' | chararray[i] == 'q' | chararray[i] == 'r' | chararray[i] == 's' | chararray[i] == 't' | chararray[i] == 'u' |
                          chararray[i] == 'v' | chararray[i] == 'w' | chararray[i] == 'x' | chararray[i] == 'y' | chararray[i] == 'z' | chararray[i] == '.' | chararray[i] == ',' |
                          chararray[i] == ' ' | chararray[i] == 'ı')
                {
                    if (chararray[i] == 'ı')
                    {
                        chararray[i] = 'i';                                                     //Checking the suitability of alphabets and symbols used.
                    }
                    if (i == chararray.Length - 1)
                    {
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("You can type only English alphabet letters and two punctuations dot (.) and comma (,).");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter a text again.");                      //Retrieving the input by showing an error message if the alphabet and symbols used are not appropriate.
                    text = Console.ReadLine();
                    textlow = text.ToLower();

                    chararray = textlow.ToCharArray();
                    i = -1;
                }
                i++;
            } while (true);

            Console.WriteLine("Please enter a pattern.");
            pattern = Console.ReadLine();
            patternlow = pattern.ToLower();                                              //Receiving pattern input from the user.
            char[] chararray1 = patternlow.ToCharArray();
            i = 0;
            
            do
            {
                if (chararray1[i] == 'a' | chararray1[i] == 'b' | chararray1[i] == 'c' | chararray1[i] == 'd' | chararray1[i] == 'e' | chararray1[i] == 'f' | chararray1[i] == 'g' |
                        chararray1[i] == 'h' | chararray1[i] == 'i' | chararray1[i] == 'j' | chararray1[i] == 'k' | chararray1[i] == 'l' | chararray1[i] == 'm' | chararray1[i] == 'n' |
                         chararray1[i] == 'o' | chararray1[i] == 'p' | chararray1[i] == 'q' | chararray1[i] == 'r' | chararray1[i] == 's' | chararray1[i] == 't' | chararray1[i] == 'u' |
                          chararray1[i] == 'v' | chararray1[i] == 'w' | chararray1[i] == 'x' | chararray1[i] == 'y' | chararray1[i] == 'z' | chararray1[i] == '*' | chararray1[i] == '-' |
                          chararray1[i] == ' ' | chararray[i] == 'ı')
                {
                    if (chararray[i] == 'ı')
                    {
                        chararray[i] = 'i';                                                    //Checking the suitability of alphabets and symbols used.
                    }
                    if (patternlow.IndexOf('*') >= 0 & patternlow.IndexOf('-') >= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("The pattern can contain letters, as well as either the character(s) of “*” or the character(s) of “-”, but not both of them.");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Please enter a pattern again.");                    //Displaying error message if pattern contains both * and -.       
                        pattern = Console.ReadLine();
                        patternlow = pattern.ToLower();

                        chararray1 = patternlow.ToCharArray();
                        i = -1;
                    }
                    if (i == chararray1.Length - 1)
                    {
                        break;
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The pattern can contain English alphabet letters, as well as either the character(s) of “*” or the character(s) of “-”, but not both of them.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please enter a pattern again.");                   //Retrieving the input by showing an error message if the alphabet and symbols used are not appropriate.
                    pattern = Console.ReadLine();
                    patternlow = pattern.ToLower();

                    chararray1 = patternlow.ToCharArray();
                    i = -1;
                }

                i++;

            } while (true);

            ///////////////////////////////////////////////////////////////////////

            text = text.Replace(",", "");
            text = text.Replace(".", "");                                      //Removing the (,) and (.) signs from the text input.
            textlow = textlow.Replace(",","");
            textlow = textlow.Replace(".", "");

            string[] str = textlow.Split();                                    //Assigning the lowercase text of the text to an array by dividing it from spaces.
            string[] capitalstr = text.Split();                                //Assigning the text to an array by dividing it from spaces.
            bool flag = false;

            string[] uniquestr = str.Distinct().ToArray();                     //Deleting repeating elements in an array.
            string[] uniquecapitalstr = capitalstr.Distinct().ToArray();       //Deleting repeating elements in an array.


            if (patternlow.Contains("-"))
            {
                for (int j = 0; j < uniquestr.Length; j++)
                {
                    string str1 = uniquestr[j];

                    if (patternlow.Length == uniquestr[j].Length)
                    {
                        for (int k = 0; k < uniquestr[j].Length; k++)
                        {
                            if (patternlow[k] != '-')                        //If the pattern contains (-) and the length of the pattern is equal to the length of any element in the text array
                                                                             //and the letters of the pattern and that element respectively are the same, it prints that element to the console.
                            {
                                if (patternlow[k] != str1[k])
                                {
                                    flag = false;
                                    
                                }
                                else
                                {
                                    flag = true;
                                }
                            }
                        }
                        if (flag == true)
                        {
                            Console.WriteLine(uniquecapitalstr[j]);
                        }
                    }
                    
                }
            }
            if (patternlow.Contains("-"))
            {
                for (i = 0; i < uniquestr.Length; i++)                    //If the pattern contains only (-) and the length of the pattern is equal to the length of any element in the text array,
                                                                          //it will print that element to the console.
                {
                    if (patternlow.Length == uniquestr[i].Length)
                    {
                        for (int j = 0; j < patternlow.Length; j++)
                        {
                            if (patternlow[j] != '-')
                            {
                                flag = false;
                                i = uniquestr.Length;
                                break;
                            }
                            else
                            {
                                flag = true;
                            }
                        }
                        if (flag == true)
                        {
                            Console.WriteLine(uniquecapitalstr[i]);
                        }
                    }

                }
            }
            ///////////////////////////////////////////////////////////////////////////////////////// 

            if (patternlow.Contains("*"))
            {
                for (int j = 0; j < uniquestr.Length; j++)
                {
                    if (patternlow.Length <= uniquestr[j].Length)              //If the pattern contains only (*), it first divides the pattern from (*) symbols and assigns it to an array,
                                                                               //then it checks whether the elements of the text array contain the elements of the pattern array,
                                                                               //and if it does, it prints that element to the console.
                    {
                        string[] pattstar = patternlow.Split('*');
                       
                        for (int k = 0; k < pattstar.Length; k++)
                        {
                            if (pattstar[k] == "")
                            {
                                
                            }
                            else
                            {
                                if (uniquestr[j].Contains(pattstar[k]))
                                {
                                    flag = true;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                        }
                        if (flag == true)
                        {
                            Console.WriteLine(uniquecapitalstr[j]);
                        }
                    }
                }
            }
            if (patternlow.Contains("*"))
            {
                for (int k = 0; k < uniquestr.Length; k++)
                {
                    for (int j = 0; j < patternlow.Length; j++)
                    {
                        if (patternlow[j] != '*')                                          //If the pattern contains only (*), it prints all the non-identical elements of the array.
                        {
                            flag = false;
                            k = uniquestr.Length;
                            break;
                        }
                        else
                        {
                            flag = true;
                        }
                    }
                    if (flag == true)
                    {
                        Console.WriteLine(uniquecapitalstr[k]);
                    }
                }
            }
            
            Console.ReadKey();
        }
    }
}
