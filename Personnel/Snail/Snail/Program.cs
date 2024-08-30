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
            List<Snail> snails = new List<Snail>();

            for (int i = 0; i < 10; i++)
            {
                snails.Add(new Snail(i));
            }

            Console.ForegroundColor = ConsoleColor.Green;

            //rend le curseur invisble
            Console.CursorVisible = false;

            //déplacement
            do
            {
                Console.Clear();
                foreach (Snail snail in snails)
                {
                    Console.SetCursorPosition(snail.x, snail.y);
                    Console.WriteLine(snail.alive);
                    snail.Move();
                }
                Thread.Sleep(30);

            } while (snails[0].life > 0);

            //mort
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            foreach (Snail snail in snails)
            {
                Console.SetCursorPosition(snail.x, snail.y);
                Console.WriteLine(snail.dead);
            }
            Console.ReadLine();
        }
    }
}
