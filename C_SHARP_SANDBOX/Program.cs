using System;

namespace C_SHARP_SANDBOX
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int i = 12345;
                byte b = Convert.ToByte(i);
            }
            catch (Exception)
            {
                Console.WriteLine("Type Cannot Be Converted!");
            }



        }
    }
}
