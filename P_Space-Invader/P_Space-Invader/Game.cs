///Auteur: Joël Pittet
///Date: 25.01.2024
///Lieu: Lausanne - ETML
///Description: Classe qui contient les méthodes pour lancer le jeu Space Invader
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class Game
    {

        //Position du vaisseau du joueur sur l'axe X
        const int STARTING_POSITION_SPACESHIP_ON_X = 35;

        //Position du vaisseau du joueur sur l'axe Y
        const int STARTING_POSITION_SPACESHIP_ON_Y = 60;

        //Crée un bunker
        Bunker bunker = new Bunker();

        //Instancie un nouveau vaisseau
        SpaceShipPlayer spaceShipPlayer = new SpaceShipPlayer();

        int stockedPositionX = STARTING_POSITION_SPACESHIP_ON_X;

        int stockedPositionY = STARTING_POSITION_SPACESHIP_ON_Y;

        /// <summary>
        /// Initialise le jeu
        /// </summary>
        public void DrawGame()
        {

            //Largeur de la fenêtre de jeu
            const int WINDOW_WIDTH = 70;

            //Hauteur de la fenêtre de jeu
            const int WINDOW_HEIGHT = 40;

            //Redimentionnement de la fenêtre de jeu
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            //Affiche les bunkers
            bunker.DrawBunkers();

            //Dessine le vaisseau
            spaceShipPlayer.PlayerSpaceShipDraw(STARTING_POSITION_SPACESHIP_ON_X, STARTING_POSITION_SPACESHIP_ON_Y);

        }

        /// <summary>
        /// Permet de jouer au jeu
        /// </summary>
        public void PlayGame()
        {
            do
            {
                if (Console.ReadKey().Key == ConsoleKey.LeftArrow)
                {
  
                    spaceShipPlayer.PlayerSpaceShipMoving(stockedPositionX, stockedPositionY,true);
                    stockedPositionX = stockedPositionX - 1;

                }
                else if (Console.ReadKey().Key == ConsoleKey.RightArrow)
                {
                  
                    spaceShipPlayer.PlayerSpaceShipMoving(stockedPositionX, stockedPositionY, false);
                    stockedPositionX = stockedPositionX + 1;

                }

            }while(true);







        }


    }
}
