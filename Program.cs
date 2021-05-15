using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //example01();
            //example02();
            //example03();
            //example04();
            //example05();
            //example06();
            //example07();

            //tryout();

            /// <summary>
            /// Which of the following conversations can't be perfomed implicitly.
            /// 1) int to short
            /// </summary>
            //exercise01_1();

            /// <summary>
            /// Which of the following conversations can't be perfomed implicitly.
            /// 2) short to int
            /// </summary>
            //exercise01_2();

            /// <summary>
            /// Which of the following conversations can't be perfomed implicitly.
            /// 3) bool to string
            /// </summary>
            //exercise01_3();

            /// <summary>
            /// Which of the following conversations can't be perfomed implicitly.
            /// 4) byte to float
            /// </summary>
            //exercise01_4();

            ///<summary>
            ///Give the code for a color enumeration based on the short type containing the colors of the  rainbow plus black and white. on this enunmeration be based on the byte type
            ///</summary>
            //exercise02();

            ///<summary>
            /// Write code to ensure that compiler compile the code or not, if not explain the reason
            ///</summary>
            //exercise03();

            ///<summary>Write a code that accepts a string from the user and outputs a tring value with the characters in reverse order</summary>
            //exercise04();

            ///<summary>
            ///Wwrite a console application that accepts a string and replaces all occurances of the string "no" with "yes"
            ///</summary>
            //exercise05();

            ///<summary>
            ///Write a console application that places double quotes around each word in a string
            ///</summary>
            ///
            exercise06();
        }

        private static void exercise06()
        {
            string sentence = "what is your age?";
            char[] seperator = { ' ' };
            string[] words= sentence.Split(seperator);
            string output = string.Empty;
            for (int i = 0; i < words.Length; i++)
            {
                output+= "\"" + words[i] + "\"";
            }
            Console.WriteLine(output);
        }

        private static void exercise05()
        {
            Console.WriteLine("Enter string:");
            string val=Console.ReadLine();

            if (!string.IsNullOrEmpty(val))
            {
                val = val.Replace("no", "yes");
                Console.WriteLine(val);
            }
        }

        private static void exercise04()
        {
            Console.Write("Write a sentence:");
            string returnVal = Console.ReadLine();

            char[] seprator = { ' ' };
            if (!string.IsNullOrEmpty(returnVal))
            {
                char[] characters = returnVal.ToCharArray();
                //foreach (var character in characters)
                //{
                //    Console.WriteLine("{0}", character);
                //}

                for (int i = characters.Length-1; i >=0 ; i--)
                {
                        Console.Write("{0}", characters[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid sentence.");
            }
        }

        private static void exercise03()
        {
            string[] blab = new string[5];
            blab[5] = "5th string" ;//System.IndexoutOutOfRangeException: Index was outside the bounds of the array.
        }

        private static void exercise02()
        {
            
            var type= typeof(Color);
            Console.WriteLine("Type: {0} -{1}.",type.Name,Enum.GetUnderlyingType(type).Name);
            //Type val = Enum.GetUnderlyingType(type).UnderlyingSystemType;

            byte byteValue = (byte)Color.white;

        }

        /// <summary>
        /// Which of the following conversations can't be perfomed implicitly.
        /// 4) byte to float
        /// </summary>
        private static void exercise01_4()
        {
            byte age = 32;
            float ageInFloat = age;
            Console.WriteLine("{0}-> byte to float", ageInFloat);
        }

        /// <summary>
        /// Which of the following conversations can't be perfomed implicitly.
        /// 3) bool to string
        /// </summary>
        private static void exercise01_3()
        {
            bool isValidAge = false;
            //string isApproved = isValidAge; //cannot implicity convert type 'bool' to 'string'
            //string isApproved = (string)isValidAge; //cannot convert type 'bool' to 'string'
            string isApproved = Convert.ToString(isValidAge);
            Console.WriteLine("{0}->bool to string", isApproved);
        }

        /// <summary>
        /// Which of the following conversations can't be perfomed implicitly.
        /// 2) short to int
        /// </summary>
        private static void exercise01_2()
        {
            int ageToInt;
            short ageToShort = 32;
            ageToInt = ageToShort;

            Console.WriteLine("{0}->short to integer.", ageToInt);
        }

        /// <summary>
        /// Which of the following conversations can't be perfomed implicitly.
        /// 1) int to short
        /// </summary>
        private static void exercise01_1()
        {
            int ageToInt = 32;
            short ageToShort;
            //ageToShort= ageToInt; // Cannot implicitly convert type 'int' to 'short'.. An explicit conversion exists(are you missing cast?
            ageToShort = (short)ageToInt;
            Console.WriteLine("{0}->integer to short",ageToShort);
        }

        private static void tryout()
        {
            string mystring = "This is a test";
            char[] seprator = { ' ' };
            string[] myWords;
            myWords = mystring.Split(seprator);


            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
        }

        private  static void example01()
        {
            string myString = "A string";
            char myChar = myString[0];

            Console.WriteLine(myChar);
        }

        /// <summary>
        /// to get the character array
        /// </summary>
        private static void example02()
        {
            string myString = "A string";
            char[] myChars = myString.ToCharArray();

            foreach (char item in myChars)
            {
                Console.Write("{0}",item);
            }
        }

        /// <summary>
        /// if enter exit as text then exit the method.
        /// if break then exit the loop.
        /// </summary>
        private static void example03()
        {
            while (true)
            {
                string userResponse= Console.ReadLine();
                if (userResponse.ToLower().Equals("exit"))
                { return; }
                if (userResponse.ToLower().Equals("yes"))
                { break; }
            }

            Console.WriteLine("string matched with lower case");
        }

        private static void example04()
        {
            string userResponse = Console.ReadLine();
            userResponse = userResponse.Trim();
            if (userResponse .ToLower() == "yes")
            {
                Console.WriteLine("use of TRIM function");
            }
        }

        //remove all leading or trailing occurances of a set of characters specified in an array from the current string
        private static void example05()
        {
            char[] trimChar = { ' ', 'e', 's' };
            string userResponse = Console.ReadLine();
            userResponse = userResponse.ToLower();
            userResponse = userResponse.Trim(trimChar);
            Console.WriteLine(userResponse);
        }

        /// <summary>
        /// padleft
        /// </summary>
        private static void example06()
        {
            string myString = "Aligned";
            myString = myString.PadLeft(10,'x');
            myString = "[" + myString + "]";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(myString);
        }

        /// <summary>
        /// padright
        /// </summary>
        private static void example07()
        {
            string myString = "Aligned";
            myString = myString.PadRight(10, 'x');
            myString = "[" + myString + "]";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(myString);
        }

        
    }
}
