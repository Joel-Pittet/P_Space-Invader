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


            DrawMenu();

            char returnedOption = SelectedOption();

            OptionToLaunch(returnedOption);

            //Méthode qui affiche le menu
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

            //Récupère le choix de l'utilisateur
            char SelectedOption()
            {
                Console.WriteLine("Veuillez entrer la lettre qui correspond à votre choix");
                Console.Write("Votre choix: ");
                char letterPressed = Convert.ToChar(Console.ReadLine().ToLower());

                return letterPressed;
            }

            //Lance l'option selectionnée
            void OptionToLaunch(char userChoice)
            {
                switch (userChoice)
                {
                    case 'a':
                        PlayGame();
                        break;
                    case 'b':
                        OpenOptions();
                        break;
                    case 'c':
                        ShowHighScore();
                        break;
                    case 'd':
                        ShowAbout();
                        break;
                    case 'e':
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("Veuillez entrer une lettre disponible");
                        SelectedOption();
                        break;
                }
            }


            //Démarre le jeu
            void PlayGame()
            {

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
