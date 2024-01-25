///Auteur: Joël Pittet
///Date: 25.01.2024
///Lieu: Lausanne - ETML
///Description: Programme qui permet de jouer au jeu Space Invader
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Affiche le menu
            DrawMenu();

            //Récupère le choix de l'utilisateur
            char returnedOption = SelectedOption();

            //Passe le choix de l'utilisateur en paramètre pour lancer la méthode correspondante
            OptionToLaunch(returnedOption);


            //Méthodes


            //Affiche le menu
            void DrawMenu()
            {

                //Affiche une introduction au jeu
                Console.WriteLine("+---------------+");
                Console.WriteLine("| Space Invader |");
                Console.WriteLine("+---------------+");



                //Liste qui stocke les choix du menu
                List<string> listMenuEntries = new List<string>()
                {
                    "a. Jouer",
                    "b. Options",
                    "c. Highscore",
                    "d. A propos",
                    "e. Quitter"
                };

                //Affiche toutes les options de la liste
                for(int i = 0; i < listMenuEntries.Count; i++)
                {
                    Console.WriteLine(listMenuEntries[i]+"\n");
                    
                }

            }

            
            char SelectedOption()
            {
                Console.WriteLine("Veuillez entrer la lettre qui correspond à votre choix");
                Console.Write("Votre choix: ");
                char letterPressed = Convert.ToChar(Console.ReadLine().ToLower());

                return letterPressed;
            }

            //Lance l'option choisie par l'utilisateur
            void OptionToLaunch(char userChoice)
            {
                switch (userChoice)
                {
                    //Lance le jeu
                    case 'a':
                        PlayGame();
                        break;
                    //Ouvre les options
                    case 'b':
                        OpenOptions();
                        break;
                    //Affiche le tableau des scores
                    case 'c':
                        ShowHighScore();
                        break;
                    //Affiche l'à propos
                    case 'd':
                        ShowAbout();
                        break;
                    //Quitte le programme
                    case 'e':
                        ExitProgram();
                        break;
                    //Si l'utilisateur entre une lettre pas existanrte dans le menu
                    //Efface la comnsole et réaffiche le menu en lui redemandant une lettre
                    default:
                        Console.WriteLine("Veuillez entrer une lettre disponible");
                        Console.Clear();
                        DrawMenu();
                        SelectedOption();
                        break;
                }
            }


            //Démarre le jeu
            void PlayGame()
            {
                Game game = new Game();
                Console.Clear();
                game.InitializeGame();
            }


            //Ouvre les options du jeu
            void OpenOptions()
            {

            }


            //Affiche le meilleur score
            void ShowHighScore()
            {

            }


            //Affiche "A propos"
            void ShowAbout()
            {

            }


            //Quitte le programme
            void ExitProgram()
            {
                Console.Clear();
                Console.WriteLine("Au revoir et merci");

                Console.ReadLine();
            }
        }
    }
}
