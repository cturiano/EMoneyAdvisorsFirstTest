using System;
using System.Text;

namespace eMoneyAdvisorTest
{
    internal class Program
    {
        #region Private Methods

        private static void Main(string[] args)
        {
            try
            {
                var args0 = args.Length < 1 ? Console.ReadLine() : args[0];
                
                int size;
                if (int.TryParse(args0, out size))
                {
                    for (var i = 1; i < size; i++)
                    {
                        PrintGlass(i);
                    }
                }
                else
                {
                    Error();
                }
            }
            catch (Exception e)
            {                
                Error(e.Message);
            }
        }

        private static void MakeStem(int size, StringBuilder glass)
        {
            for (var i = 0; i < size; i++)
            {           
                glass.Append(new string(' ', size - 1) + '|' + "\n");
            }               
        }

        private static void PrintGlass(int size)
        {               
            var stem = new StringBuilder();
            MakeBowl(size, stem);
            MakeStem(size, stem);
            MakeBase(size, stem);
            Console.WriteLine(stem);
        }

        private static void MakeBowl(int size, StringBuilder glass)
        {                             
            for (var i = 0; i < size; i++)
            {           
                glass.Append(new string(' ', i) + new string('0', 2 * (size - i) - 1) + "\n");
            }  
        }

        private static void MakeBase(int size, StringBuilder glass)
        {                                 
            glass.Append(new string('=', (2*size)-1));
        }

        private static void Error(string message = null)
        {
            Console.WriteLine(message ?? "You must enter one numeric glass size.");
        }

        #endregion
    }    
}