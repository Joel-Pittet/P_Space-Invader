///Auteur: Joël Pittet
///Date: 25.01.2024
///Lieu: Lausanne - ETML
///Description: Classe qui contient plusieurs méthodes et 
///             attributs qui permettent d'utiliser le vaisseau du joueur
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace P_Space_Invader
{
    internal class SpaceShipPlayer
    {

        /// <summary>
        /// Forme du vaisseau
        /// </summary>
        private string _spaceShipShape = "--|--";

        /// <summary>
        /// Position du curseur sur l'axe X
        /// </summary>
        private int _cursorOnX = 0;

        /// <summary>
        /// Position du curseur sur l'axe Y
        /// </summary>
        private int _cursorOnY = 0;

        /// <summary>
        /// Vie et mort du vaisseau
        /// </summary>
        //private bool _isAlive = true;

        /// <summary>
        /// Constructeur pa défaut
        /// </summary>
        public SpaceShipPlayer()
        {

        }


        /// <summary>
        /// Affiche le vaisseau
        /// </summary>
        public void PlayerSpaceShipDraw(int cursorOnX, int cursorOnY)
        {
            //Récupère la position du vaisseau
            _cursorOnX = cursorOnX;
            _cursorOnY = cursorOnY;

            //Position initiale du vaisseau
            Console.CursorLeft = _cursorOnX;
            Console.CursorTop = _cursorOnY;

            //Affiche le vaisseau du vaisseau
            Console.WriteLine(_spaceShipShape);
        }

        /// <summary>
        /// Déplacement du vaisseau du joueur
        /// </summary>
        /// <param name="stockedPositionX">Position du vaisseau sur l'axe X</param>
        /// <param name="stockedPositionY">Position du vaisseau sur l'axe Y</param>
        /// <param name="isLeft">Savoir si la flèche de droite ou de gauche à été touchée</param>
        public void PlayerSpaceShipMoving(int stockedPositionX, int stockedPositionY, bool isLeft)
        {

            //Efface la console
            Console.Clear();


            //Lorsque que la flèche gauche est touchée
            if (isLeft)
            {

                //Debug.WriteLine("stockedPositionX: " + stockedPositionX--);

                //Réaffiche le vaisseau un cran à gauche de son ancienne position
                PlayerSpaceShipDraw(stockedPositionX--, stockedPositionY);

            }//Lorsque que la flèche droite est touchées
            else
            {
              
                //Debug.WriteLine("stockedPositionX: "+ stockedPositionX++);

                //Réaffiche le vaisseau un cran à droite de son ancienne position
                PlayerSpaceShipDraw(stockedPositionX++, stockedPositionY);


            }

        }
    }
}
