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
        /// Forme de l'ennemi
        /// </summary>
        string _shape;

        /// <summary>
        /// GETTER/SETTER
        /// Forme de l'ennemi
        /// </summary>
        public string Shape
        {
            get
            {
                return _shape;
            }
            set
            {
                _shape = value;
            }
        }

        /// <summary>
        /// Position de l'ennemi sur l'axe X
        /// </summary>
        private int _positionOnX;

        /// <summary>
        /// Position de l'ennemi sur l'axe X
        /// </summary>
        public int PositionOnX
        {
            get
            {
                return _positionOnX;
            }
            set
            {
                _positionOnX = value;
            }
        }

        /// <summary>
        /// Position de l'enemi sur l'axe Y
        /// </summary>
        private int _positionOnY;

        /// <summary>
        /// GETTER/SETTER
        /// Position de l'enemi sur l'axe Y
        /// </summary>
        public int PositionOnY
        {
            get
            {
                return _positionOnY;
            }
            set
            {
                _positionOnY = value;
            }
        }

        /// <summary>
        /// Nombre de vie de l'ennemi
        /// </summary>
        private int _lives;

        /// <summary>
        /// Nombre de vie de l'ennemi
        /// </summary>
        public int Lives
        {
            get
            {
                return _lives;
            }
            set
            {
                _lives = value;
            }
        }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="shape">Forme de l'enemi</param>
        /// <param name="positionOnX">Position de l'enemi sur l'axe X</param>
        /// <param name="positionOnY">Position de l'enemi sur l'axe Y</param>
        /// <param name="lives">Vies de l'enemi</param>
        public Enemy(string shape, int positionOnX, int positionOnY, int lives)
        {
            _shape = shape;
            _positionOnX = positionOnX;
            _positionOnY = positionOnY;
            _lives = lives;
        }

        /// <summary>
        /// Affiche l'ennemi sur la console
        /// </summary>
        public void DrawEnemy()
        {
            //Place le curseur à la position demandée
            Console.SetCursorPosition(_positionOnX, _positionOnY);

            //Affiche la forme de l'ennemi
            Console.WriteLine(_shape);


        }

        /// <summary>
        /// Vérifie si l'ennemi a été touché
        /// </summary>
        public void CheckColision()
        {
        }

    }
}
