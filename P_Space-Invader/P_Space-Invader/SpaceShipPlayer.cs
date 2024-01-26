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

namespace P_Space_Invader
{
    internal class SpaceShipPlayer
    {

        /// <summary>
        /// Forme du vaisseau
        /// </summary>
        string _spaceShip = "--|--";

        /// <summary>
        /// Position du curseur sur l'axe X
        /// </summary>
        int _cursorOnX;

        /// <summary>
        /// Position du curseur sur l'axe Y
        /// </summary>
        int _cursorOnY;


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
            Console.WriteLine(_spaceShip);
        }

        void PlayerSpaceShipLife()
        {

        }

        void PlayerSpaceShipStructure()
        {

        }

        public void PlayerSpaceShipMoving()
        {
            
            /*if(Console.ReadKey().Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
                PlayerSpaceShipDraw(_stockedCursorX - 1, _cursorOnY);

            }
            else if(Console.ReadKey().Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
                PlayerSpaceShipDraw(_stockedCursorX + 1, _cursorOnY);
            }*/



        }

        void PlayerSpaceShipShooting()
        {

        }
    }
}
