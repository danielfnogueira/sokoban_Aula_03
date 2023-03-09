using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Sokoban_Projeto_01
{
    public class Player
    {
        // Current player position in the matrix (multiply by tileSize prior to drawing)
        private Point position; //Point = Vector2, mas são inteiros
        public Point Position => position; //auto função (equivalente a ter só get sem put)

        public Player(int x, int y) //constructor que dada a as +osições guarda a sua posição
        {
            position = new Point(x, y);
        }
    }
}

