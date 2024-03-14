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
        /// <summary>
        /// Position du bunker sur l'axe X
        /// </summary>
        int _posX;

        /// <summary>
        /// Position du bunker sur l'axe Y
        /// </summary>
        int _posY;

        /// <summary>
        /// GETTER / SETTER
        /// Position du bunker sur l'axe X
        /// </summary>
        public int PosX
        {
            get
            {
                return _posX;
            }
            set
            {
                _posX = value;
            }
        }

        /// <summary>
        /// GETTER / SETTER
        /// Position du bunker sur l'axe Y
        /// </summary>
        public int PosY
        {
            get
            {
                return _posY;
            }
            set
            {
                _posY = value;
            }
        }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="posX">Position du bunker sur l'axe X</param>
        /// <param name="posY">Position du bunker sur l'axe Y</param>
        public Bunker(int posX, int posY)
        {
            _posX = posX;
            _posY = posY;
        }

        /// <summary>
        /// Dessine le bunker
        /// </summary>
        public void DrawBunker()
        {
            //Forme du bunker
            string bunkerTop = ("XXXXX");
            string bunkerMiddle = ("XXXXXXX");
            string bunkerBottom = ("XXXXXXXXX");

            //Étages du bunker
            const int NB_BUNKER_FLOOR = 3;

            for (int i = 1; i < NB_BUNKER_FLOOR + 1; i++)
            {
                if (i == 1)
                {
                    //Position initiale du bunker
                    Console.SetCursorPosition(_posX, _posY);

                    //Dessine le haut des bunker
                    Console.WriteLine(bunkerTop);

                }
                else if (i == 2)
                {
                    //Décale de 1 l'apparition de l'étage suivant pour un effet pyramide
                    _posX--;

                    //Position initiale du bunker sur l'axe X
                    Console.CursorLeft =  _posX;

                    //Descend le curseur de 1 pour afficher le niveau suivant en dessous du précédent
                    _posY++;

                    //Position sur l'axe Y
                    Console.CursorTop = _posY;

                    //Dessine le milieu des bunkers
                    Console.WriteLine(bunkerMiddle);
                }
                else if(i == 3)
                {
                    //Décale de 1 l'apparition de l'étage suivant pour un effet pyramide
                    _posX--;

                    //Position initiale du bunker
                    Console.CursorLeft = _posX;

                    //Descend le curseur de 1 pour afficher le niveau suivant en dessous du précédent
                    _posY++;

                    //Position sur l'axe Y
                    Console.CursorTop = _posY;

                    //Dessine le bas des bunkers
                    Console.WriteLine(bunkerBottom);
                }

            }

        }


        /// <summary>
        /// Ne fait rien
        /// </summary>
        public void Update()
        {

        }



    }


}
