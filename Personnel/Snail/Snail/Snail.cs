using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snail
{
    internal class Snail
    {
        //attribut
        public int life = 50;            //Point de vie de l'escargot
        public int x = 0;                //coordenée en x
        public int y;                    //coordenée en y
        public string alive = "_@_ö";    //escargot vivant
        public string dead = "____";     //escargot mort
        public string name;

        //constructeur
        public Snail(int y)
        {
            this.y = y;
            this.name = "Escargot " + y;
        }
        public Snail()
        {
            y = 12;
            this.name = "EScargot";
        }

        //méthode
        public void Move()
        {
            x++;
            life--; //un déplacement coûte un pv
        }

    }
}
