using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snail
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int life = 50;
            string snail = "_@_ö";
            int left = 0;
            
            //déplacement
            do
            {
                Thread.Sleep(100);
                Console.Clear();
                Console.SetCursorPosition(left, 15);
                Console.WriteLine(snail);
                life--;
                left++;

            } while (life >= 0);

            //mort
            Console.Clear();
            Console.SetCursorPosition(left, 15);
            Console.WriteLine("____");
            Console.ReadLine();
        }
    }
}
