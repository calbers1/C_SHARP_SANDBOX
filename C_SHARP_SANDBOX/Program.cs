using System;
using System.Data.SqlClient;
using System.Collections;
using System.Data;

namespace C_SHARP_SANDBOX
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            short num;
            short length;
            char selectedChar;


            try
            {
                string n = null;
                int a = 12345;
                //byte b = Convert.ToByte(a);
                var b = n.ToLower();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
  

            //do
            //{
            //    Console.WriteLine("Enter a string. (Enter \"exit\" to quit.)");
            //    str = Console.ReadLine();
            //    if (str.ToLower() != "exit")
            //    {
            //        length = Convert.ToInt16(str.Length);
            //        do
            //        {
            //            Console.WriteLine("Enter a number between 1 and " + length);
            //            num = Convert.ToInt16(Console.ReadLine());
            //        }
            //        while (num > length  || num < 1);

            //        selectedChar = str[num - 1];
            //        Console.WriteLine(selectedChar);
            //    }
            //}
            //while (str.ToLower() != "exit");

            //Console.WriteLine("Thanks for stopping by!");
        }
    }
}
