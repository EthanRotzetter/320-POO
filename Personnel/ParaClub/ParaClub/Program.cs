﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParaClub
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //définis la taille de l'écran
            Console.BufferHeight = Config.SCREEN_HEIGHT;
            Console.BufferWidth = Config.SCREEN_WIDTH;

            Plane plane = new Plane();

            plane.draw();

            //bouger l'avion
            while (true)
            {
                // Modifier le modèle (ce qui *est*)
                plane.update();        

                // Modifier ce que l'on *voit*
                Console.Clear();
                plane.draw();

                // Temporiser
                Thread.Sleep(100);
            }
            Console.ReadLine();
        }
    }
}
