//Auteur: Joël Pittet
//Date: 14.03.2024
//Lieu: ETML - VENNES
//Description: Cette classe contient les méthodes et attributs pour créer et gérer les blocs d'ennemis


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class EnemyBlock
    {
        //Liste pour ctosker et gérer le ennemis du block d'ennemis
        List<Enemy> _enemyList = new List<Enemy>();

        //Instanciation des 5 ennemis du block d'enemi
        private Enemy _enemy1;
        private Enemy _enemy2;
        private Enemy _enemy3;
        private Enemy _enemy4;
        private Enemy _enemy5;

        /// <summary>
        /// Position du block d'ennemis sur l'axe X
        /// </summary>
        private int _positionOnX;

        /// <summary>
        /// GETTER/SETTER
        /// Position du block d'ennemis sur l'axe X
        /// </summary>
        public int PositionOnX
        {
            get
            {
                return _positionOnX;
            }
            set
            {
                _positionOnX = value;
            }
        }


        /// <summary>
        /// Position du block d'ennemis sur l'axe Y
        /// </summary>
        private int _positionOnY;

        /// <summary>
        /// GETTER/SETTER
        /// Position du blokc d'ennemis sur l'axe Y
        /// </summary>
        public int PositionOnY
        {
            get
            {
                return _positionOnY;
            }
            set
            {
                _positionOnY = value;
            }
        }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="enemy1">Premier ennemi du bloc</param>
        /// <param name="enemy2">Deusième ennemi du bloc</param>
        /// <param name="enemy3">Troisième ennemi du bloc</param>
        /// <param name="enemy4">Quatrièem ennemi du bloc</param>
        /// <param name="enemy5">Cinquième ennemi du bloc</param>
        /// <param name="positionOnX">Position du bloc sur l'axe X</param>
        /// <param name="positionOnY">Position du bloc sur l'axe X</param>
        public EnemyBlock(Enemy enemy1, Enemy enemy2, Enemy enemy3, Enemy enemy4, Enemy enemy5, int positionOnX, int positionOnY)
        {
            _enemy1 = enemy1;
            _enemy2 = enemy2;
            _enemy3 = enemy3;
            _enemy4 = enemy4;
            _enemy5 = enemy5;
            _positionOnX = positionOnX;
            _positionOnY = positionOnY;

            AddEnemyInBlock();

        }

        /// <summary>
        /// Permet d'afficher un block d'ennemis
        /// </summary>
        public void DrawEnemyBlock()
        {
            //Place le curseur à la position demandée
            Console.SetCursorPosition(_positionOnX, _positionOnY);

            //Parcourt la liste des ennemis et les affiche
            foreach (Enemy enemy in _enemyList)
            {
                enemy.DrawEnemy();
            }


        }

        /// <summary>
        /// Ajoute tous les ennemis dans la liste des ennemis
        /// </summary>
        public void AddEnemyInBlock()
        {
            _enemyList.Add(_enemy1);
            _enemyList.Add(_enemy2);
            _enemyList.Add(_enemy3);
            _enemyList.Add(_enemy4);
            _enemyList.Add(_enemy5);
            
        }

        /*
        /// <summary>
        /// Actualise la position du bloc d'ennemi
        /// </summary>
        public void Update()
        {
            foreach (Enemy enemy in _enemyList)
            {
                if(enemy.PositionOnX < Console.WindowWidth)
                {
                    //efface l'ancienne position de l'ennemi
                    Console.SetCursorPosition(enemy.PositionOnX, enemy.PositionOnY);
                    Console.WriteLine("      ");

                    //Place le curseur au nouvel emplacement de l'ennemi
                    enemy.PositionOnX += enemy.PositionOnX++;
                    Console.SetCursorPosition(enemy.PositionOnX, enemy.PositionOnY);

                    //Affiche l'ennemi
                    enemy.DrawEnemy();

                    //Laisse un temps avant de changer la position du prochain ennemi
                    Thread.Sleep(2000);

                }else if(enemy.PositionOnX >= Console.WindowWidth)
                {
                    //Fait passer l'ennemi une ligne en dessous
                    enemy.PositionOnY++;

                    enemy.PositionOnX = Console.WindowWidth;

                    Console.SetCursorPosition(enemy.PositionOnX, enemy.PositionOnY);
                }

            }
        }*/


    }
}
