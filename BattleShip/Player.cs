using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Player
    {
        public string name { get; set; }
        public GameBoard gameBoard { get; set; }
        public List<Ship> ships { get; set; }
        public bool hasLost
        {
            get
            {
                return ships.All(x => x.isSunk);
            }
        }

        public Player(string n)
        {
            name = n;
            ships = new List<Ship>()
            {
                new Destroyer()
                
            };
            gameBoard = new GameBoard();
        }
    }
}
