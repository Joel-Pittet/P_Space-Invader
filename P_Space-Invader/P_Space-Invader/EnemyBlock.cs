//Auteur: Joël Pittet
//Date: 14.03.2024
//Lieu: ETML - VENNES
//Description: Cette classe contient les méthodes et attributs pour créer et gérer les blocs d'ennemis


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class EnemyBlock
    {
        //Instanciation des 5 enemy du block d'enemi
        Enemy _enemy1;
        Enemy _enemy2;
        Enemy _enemy3;
        Enemy _enemy4;
        Enemy _enemy5;

        public EnemyBlock(Enemy enemy1, Enemy enemy2, Enemy enemy3, Enemy enemy4, Enemy enemy5, int positionOnX, int positionOnY)
        {
            _enemy1 = enemy1;
            _enemy2 = enemy2;
            _enemy3 = enemy3;
            _enemy4 = enemy4;
            _enemy5 = enemy5;
        }

    }
}
