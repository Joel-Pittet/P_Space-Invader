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

        //Crée un bunker
        Bunker bunker = new Bunker();

        //Instancie un nouveau vaisseau
        SpaceShipPlayer spaceShipPlayer = new SpaceShipPlayer(posX: 32, nbLives: 3, spaceShipShape: "--|--");

        /// <summary>
        /// Initialise le jeu
        /// </summary>
        public void DrawGame()
        {

            //Largeur de la fenêtre de jeu
            int WINDOW_WIDTH = Console.WindowWidth;

            //Hauteur de la fenêtre de jeu
            int WINDOW_HEIGHT = Console.WindowHeight;

            //Redimentionnement de la fenêtre de jeu
            Console.SetWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT);

            //Affiche les bunkers
            //bunker.DrawBunkers();

            //Dessine le vaisseau
            spaceShipPlayer.PlayerSpaceShipDraw();

        }

        /// <summary>
        /// Permet de jouer au jeu
        /// </summary>
        public void PlayGame()
        {

            //Boucle pour bouger le vaisseau durant la partie
            do
            {
                spaceShipPlayer.PlayerSpaceShipMoving();
                spaceShipPlayer.Update();

            } while (true) ;

        }


    }
}
