///Auteur: Joël Pittet
///Date: 22.02.2024
///Lieu: Lausanne - ETML
///Description: Classe qui contient les méthodes et les attributs
///d'un missile dans le jeu Space Invader
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class Missile
    {

        /// <summary>
        /// Forme du missile
        /// </summary>
        public string MissileShape { get; set; }

        /// <summary>
        /// Position du missile sur l'axe X
        /// </summary>
        public int PositionOnX { get; set; }

        /// <summary>
        /// Position du missile sur l'axe Y
        /// </summary>
        public int PositionOnY { get; set; }

        /// <summary>
        /// Nombre de vie du vaisseau
        /// </summary>
        public int NumberOfLives { get; set; }

        /// <summary>
        /// Constructeur avec position, nombre de vie et forme du missile
        /// </summary>
        /// <param name="posX">Position sur l'axe X</param>
        /// <param name="posY">Position sur l'axe Y</param>
        /// <param name="nbLives">Nombre de vies</param>
        /// <param name="missileShape">Forme du missile</param>
        public Missile (int posX, int posY, int nbLives, string missileShape)
        {
            PositionOnX = posX;
            PositionOnY = posY;
            NumberOfLives = nbLives;
            MissileShape = missileShape;

        }

        /// <summary>
        /// Vie et mort du missile
        /// </summary>
        /// <returns>Retourne vrai si le nombre de vie est supérieur à 0</returns>
        public bool isAlive()
        {
            bool isAlive = false;

            if (NumberOfLives > 0)
            {
                isAlive = true;
            }

            return isAlive;
        }



    }
}
