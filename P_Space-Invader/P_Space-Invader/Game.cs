﻿///Auteur: Joël Pittet
///Date: 25.01.2024
///Lieu: Lausanne - ETML
///Description: Classe qui contient les méthodes pour lancer le jeu Space Invader
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace P_Space_Invader
{
    internal class Game
    {

        //Enumération des états du jeu
        enum GameState {Play, Pause}

       GameState state;


        //Instancie un nouveau vaisseau
        SpaceShipPlayer spaceShipPlayer = new SpaceShipPlayer(posX: Console.WindowWidth / 2, nbLives: 3, spaceShipShape: "--|--");

        //Instancie des nouveaux ennemis
        static Enemy enemy1 = new Enemy(shape: "<<^^>>", positionOnX: 32, positionOnY: 5, lives: 4);
        static Enemy enemy2 = new Enemy(shape: "YY==YY", positionOnX: 40, positionOnY: 5, lives: 3);
        static Enemy enemy3 = new Enemy(shape: "<<^^>>", positionOnX: 48, positionOnY: 5, lives: 4);
        static Enemy enemy4 = new Enemy(shape: "YY==YY", positionOnX: 56, positionOnY: 5, lives: 3);
        static Enemy enemy5 = new Enemy(shape: "<<^^>>", positionOnX: 64, positionOnY: 5, lives: 4);

        //Instancie un block d'ennemis
        EnemyBlock firstEnemyBlock = new EnemyBlock(enemy1: enemy1, enemy2: enemy2, enemy3: enemy3, enemy4: enemy4, enemy5: enemy5, positionOnX: 32, positionOnY: 10);

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

            for(int i = 1; i < 4; i++)
            {
                //Crée un bunker
                Bunker bunker = new Bunker(30 * i, 24);

                //Dessine le bunker
                bunker.DrawBunker();
            }

            //Dessine le vaisseau
            spaceShipPlayer.PlayerSpaceShipDraw();

            //Affiche le block d'ennemi
            firstEnemyBlock.DrawEnemyBlock();


        }

        /// <summary>
        /// Permet de jouer au jeu
        /// </summary>
        public void PlayGame()
        {
            //Le jeu est en cours
            state = GameState.Play;

            do
            {
                //Le vaisseau peut bouger et tirer
                spaceShipPlayer.Update();

                //Le bloc d'ennemi se déplace
                //firstEnemyBlock.Update();

                
                /*OPTION PAUSE
                //Si la touche p est touchée et que le jeu est en cours
                if (Keyboard.IsKeyDown(Key.P) && state == GameState.Play)
                {
                    //Met le jeu en pause
                    state = GameState.Pause;
                    
                    //Placement du message de pause
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

                    //Affiche le message de pause
                    Console.WriteLine("Pause");
                }

                if (Keyboard.IsKeyDown(Key.P) && state == GameState.Pause)
                {

                    //Placement du message de pause
                    Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);

                    //Efface le message de pause
                    Console.WriteLine("     ");

                    //L'état du jeu redevient "En cours"
                    state = GameState.Play;
                }*/

            } while (spaceShipPlayer.isAlive() == true);


        }


    }
}
