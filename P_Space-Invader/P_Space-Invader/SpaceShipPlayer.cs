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
        /// Position du vaisseau sur l'axe X
        /// </summary>
        private int _positionOnX = 32;

        /// <summary>
        /// Position du vaisseau sur l'axe Y
        /// </summary>
        private const int _POSITION_ON_Y = 50;

        /// <summary>
        /// Enplacement maximum du vaisseau sur la droite de la fenêtre
        /// </summary>
        private int maxPosRight = 70 - 6;

        /// <summary>
        /// Enplacement maximum du vaisseau sur la gauche de la fenêtre
        /// </summary>
        private int maxPosLeft = -1;


        //private int minPositionOnY = 

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
        public void PlayerSpaceShipDraw()
        {
            //Position du vaisseau
            Console.CursorLeft = _positionOnX;
            Console.CursorTop = _POSITION_ON_Y;

            //Affiche le vaisseau du vaisseau et des espaces de chaque côtés
            //pour que le vaisseau ne laisse pas de trace
            Console.WriteLine(" " + _spaceShipShape + " ");
        }

       
        /// <summary>
        /// Mouvement du vaisseau du joueur
        /// </summary>
        public void PlayerSpaceShipMoving()
        {
            //stocke la touche pressée pour savoir s'il faut bouger à gauche ou à droite
            ConsoleKey keyPressed;

            //Récupère la touche pressée et la stocke
            keyPressed = Console.ReadKey().Key;

            //Lorsque la flèche de gauche est appuyée
            if (keyPressed == ConsoleKey.LeftArrow && (_positionOnX - 1) != maxPosLeft)
            {
                //Change la position du vaisseau de 1 à gauche
                _positionOnX = _positionOnX - 1;

                //Dessine le vaisseau
                PlayerSpaceShipDraw();

            }// Lorsque la flèche de droite est appuyée
            else if (keyPressed == ConsoleKey.RightArrow && (_positionOnX + 1) != maxPosRight)
            {
                //Change la position du vaisseau de 1 à droite
                _positionOnX = _positionOnX + 1;

                //Dessine le vaisseau
                PlayerSpaceShipDraw();
            }
            else
            {
               

            }
        }

    }
}
