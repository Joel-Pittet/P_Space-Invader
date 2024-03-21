using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_Space_Invader
{
    internal class Enemy
    {
        /// <summary>
        /// Forme de l'enemi
        /// </summary>
        string _shape;

        /// <summary>
        /// Position de l'enemi sur l'axe X
        /// </summary>
        int _positionOnX;

        /// <summary>
        /// Position de l'enemi sur l'axe Y
        /// </summary>
        int _positionOnY;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="shape">Forme de l'enemi</param>
        /// <param name="positionOnX">Position de l'enemi sur l'axe X</param>
        /// <param name="positionOnY">Position de l'enemi sur l'axe Y</param>
        public Enemy(string shape, int positionOnX, int positionOnY)
        {
            _shape = shape;
            _positionOnX = positionOnX;
            _positionOnY = positionOnY;
        }
    }
}
