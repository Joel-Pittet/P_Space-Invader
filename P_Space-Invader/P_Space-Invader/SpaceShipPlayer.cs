﻿///Auteur: Joël Pittet
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
using System.Threading;

namespace P_Space_Invader
{
    internal class SpaceShipPlayer
    {

        /// <summary>
        /// Forme du vaisseau
        /// </summary>
        public string SpaceShipShape { get; set; }

        /// <summary>
        /// Position du vaisseau sur l'axe X
        /// </summary>
        public int PositionOnX { get; set; }

        /// <summary>
        /// Nombre de vie du vaisseau
        /// </summary>
        public int NumberOfLives { get; set; }

        /// <summary>
        /// Position initiale du vaisseau sur l'axe Y
        /// </summary>
        private const int _STARTING_POSITION_ON_Y = 20;

        /// <summary>
        /// Position initiale du vaisseau sur l'axe X
        /// </summary>
        private const int _STARTING_POSITION_ON_X = 35;

        /// <summary>
        /// Enplacement maximum du vaisseau sur la droite de la fenêtre
        /// </summary>
        private int maxPosRight = 70 - 6;

        /// <summary>
        /// Enplacement maximum du vaisseau sur la gauche de la fenêtre
        /// </summary>
        private int maxPosLeft = -1;

        /// <summary>
        /// Constructeur avec position sur l'axe X, nombre de vies et forme du vaisseau
        /// </summary>
        /// <param name="posX">Position sur l'axe X</param>
        /// <param name="nbLives">Nombre de vies</param>
        /// <param name="spaceShipShape">Forme du vaisseau</param>
        public SpaceShipPlayer(int posX, int nbLives, string spaceShipShape)
        {
            PositionOnX = posX;
            NumberOfLives = nbLives;
            SpaceShipShape = spaceShipShape;
        }

        //Missile pour que le joueur puisse tirer avec le vaisseau
        Missile missile = new Missile(posX: _STARTING_POSITION_ON_X, posY: _STARTING_POSITION_ON_Y, nbLives: 1, missileShape: "|");

        /// <summary>
        /// Affiche le vaisseau
        /// </summary>
        public void PlayerSpaceShipDraw()
        {
            //Position du vaisseau
            Console.CursorLeft = PositionOnX;
            Console.CursorTop = _STARTING_POSITION_ON_Y;

            //Affiche le vaisseau du vaisseau et des espaces de chaque côtés
            //pour que le vaisseau ne laisse pas de trace
            Console.WriteLine(" " + SpaceShipShape + " ");
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
            if (keyPressed == ConsoleKey.LeftArrow && (PositionOnX - 1) != maxPosLeft)
            {
                //Change la position du vaisseau de 1 à gauche
                PositionOnX = PositionOnX - 1;

                //Dessine le vaisseau
                PlayerSpaceShipDraw();

            }// Lorsque la flèche de droite est appuyée
            else if (keyPressed == ConsoleKey.RightArrow && (PositionOnX + 1) != maxPosRight)
            {
                //Change la position du vaisseau de 1 à droite
                PositionOnX = PositionOnX + 1;

                //Dessine le vaisseau
                PlayerSpaceShipDraw();
            }
            
        }

        /// <summary>
        /// Tire un missile
        /// </summary>
        public void Shoot()
        {
            if(missile.IsAlive() == false)
            {
                //Instancie un nouveau missile
                Missile missile = new Missile(posX: PositionOnX, posY: _STARTING_POSITION_ON_Y, nbLives: 1, missileShape: "|");

                //Dessine le missile
                missile.DrawMissile();
            }
            
        }
                
        /// <summary>
        /// Vie et mort du vaisseau
        /// </summary>
        /// <returns>Retourne vrai si le nombre de vie est supérieur à 0</returns>
        public bool isAlive()
        {
            bool isAlive = false;

            if(NumberOfLives > 0)
            {
                isAlive = true;
            }

            return isAlive;
        }


        /// <summary>
        /// Met à jour le jeu
        /// </summary>
        public void Update()
        {

            //stocke la touche pressée
            ConsoleKey keyPressed;

            //Récupère la touche pressée et la stocke
            keyPressed = Console.ReadKey().Key;

            //Si la touche pressée est la barre d'espace 
            if (keyPressed == ConsoleKey.Spacebar)
            {
                //Appelle la méthode pour créer un nouveau missile
                Shoot();

                do
                {

                    //Place le curseur à la position du missile pour l'effacer
                    Console.SetCursorPosition(missile.PositionOnX, missile.PositionOnY);

                    //Affiche un espace pour cacher l'ancienne position du missile
                    Console.WriteLine(" ");

                    //Change la position du missile
                    missile.PositionOnY = missile.PositionOnY - 1;

                    //Place le curseur à la nouvelle position du missile
                    Console.SetCursorPosition(missile.PositionOnX, missile.PositionOnY);

                    //Dessine le missile
                    missile.DrawMissile();

                    //Vitesse d'affichage du missile
                    Thread.Sleep(Convert.ToInt32(missile.speed));

                } while (missile.PositionOnY > 1);

                //Le missile est mort
                missile.NumberOfLives = 0;

                //Place le curseur à la place de mort du missile
                Console.SetCursorPosition(missile.PositionOnX, missile.PositionOnY);

                //Efface le missile mort
                Console.WriteLine(" ");


            }


        }

    }
}
