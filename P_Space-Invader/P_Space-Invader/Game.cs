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

        /// <summary>
        /// Initialise le jeu
        /// </summary>
      public void InitializeGame()
      {

            //Redimentionnement de la fenêtre de jeu
            Console.SetWindowSize(90, 30);

            //Instancie un nouveau vaisseau
            SpaceShipPlayer spaceShipPlayer = new SpaceShipPlayer();

            //Position du vaisseau du joueur sur l'axe X
            const int STARTING_POSITION_SPACESHIP_ON_X = 60;

            //Position du vaisseau du joueur sur l'axe Y
            const int STARTING_POSITION_SPACESHIP_ON_Y = 70;

            //Affiche le vaisseau sur la console
            spaceShipPlayer.PlayerSpaceShipDraw(STARTING_POSITION_SPACESHIP_ON_Y,STARTING_POSITION_SPACESHIP_ON_X);

            //TODO: Dessiner les bunkers
            //TODO: Dessiner les aliens

            const int NB_BUNKER = 3;

            for (int i = 0; i < NB_BUNKER; i++)
            {
                //Crée un bunker
                Bunker bunker = new Bunker();

                //Position initiale du bunker
                Console.CursorLeft = i * 20 + 20;
                Console.CursorTop = 50;

                //Affiche un bunker
                bunker.DrawBunker();
            }

            Console.ReadLine();

        }
    }
}
