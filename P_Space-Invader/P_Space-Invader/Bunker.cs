///Auteur: Joël Pittet
///Date: 26.01.2024
///Lieu: Lausanne - ETML
///Description: Classe qui contient les méthodes 
///             et attributs des bunkers dans le jeu
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class Bunker
    {
        
        public void DrawBunkers()
        {
            //Forme du bunker
            string bunkerTop =      ("XXXXX");
            string bunkerMiddle =  ("XXXXXXX");
            string bunkerBottom = ("XXXXXXXXX");

            //Nombre de bunker
            const int NB_BUNKER = 3;

            //Étages du bunker
            const int NB_BUNKER_FLOOR = 3;

            //Position de CursorTop
            int cursorTop = 50;

            //Position de l'étage du bunker sur cursorLeft
            int cursorLeftFloor = 20;

            //Distance de séparation entre les bunkers
            const int DISTANCE_BETWEEN_BUNKERS = 25;

            for(int i = 0; i < NB_BUNKER; i++)
            {
                //Initialisation du CursorTop pour que les bunkers soient tous au même niveau (même ligne)
                cursorTop = 50;


                for (int y = 0; y < NB_BUNKER_FLOOR; y++)
                {
                    if(y == 0)
                    {
                        //Position initiale du bunker
                        Console.CursorLeft = i * DISTANCE_BETWEEN_BUNKERS + cursorLeftFloor;
                        Console.CursorTop = cursorTop;

                        //Dessine le haut des bunkers
                        Console.WriteLine(bunkerTop);

                    }else if (y == 1)
                    {
                        //Décale de 1 l'apparition de l'étage suivant pour un effet pyramide
                        cursorLeftFloor--;

                        //Position initiale du bunker sur l'axe X
                        Console.CursorLeft = i * DISTANCE_BETWEEN_BUNKERS + cursorLeftFloor;

                        //Descend le curseur de 1 pour afficher le niveau suivant en dessous du précédent
                        cursorTop++;

                        //Position sur l'axe Y
                        Console.CursorTop = cursorTop;

                        //Dessine le milieu des bunkers
                        Console.WriteLine(bunkerMiddle);
                    }
                    else
                    {
                        //Décale de 1 l'apparition de l'étage suivant pour un effet pyramide
                        cursorLeftFloor--;

                        //Position initiale du bunker
                        Console.CursorLeft = i * DISTANCE_BETWEEN_BUNKERS + cursorLeftFloor;
                        cursorTop++;
                        Console.CursorTop = cursorTop;

                        //Dessine le bas des bunkers
                        Console.WriteLine(bunkerBottom);
                    }
                    
                }
            }
            

            
            
            
        }
        
    }
}
