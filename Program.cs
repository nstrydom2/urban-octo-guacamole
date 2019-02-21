using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class wow
    {
        public readonly string targetSentence = "Badger, Badger, Badger, Badger, Badger, Badger, Badger, Badger, Badger, Badger, MUSHROOM MUSHROOM!!!!";

    }

    class Program
    {
        static void Main(string[] args)
        {
            wow obj = new wow();
            string pattern = "Badger";
            int i = 0;

            try
            {
                i = FindAllOccurences(obj, pattern);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            finally
            {
                Console.ReadKey();
            }
        }

        private static int FindAllOccurences(wow obj, string pattern)
        {
            int i = 0; 

            while ((i = obj.targetSentence.IndexOf(pattern, i)) != -1)
            {
                i += pattern.Length;
                Console.WriteLine(i);
            }
            return i;
        }
    }
}
