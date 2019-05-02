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


        public void placeShips()
        {
            Random rand = new Random(Guid.NewGuid.GetHashCode());
            foreach (var ship in ships)
            {
                bool isOpen = true;
                while (isOpen)
                {
                    var startC = rand.Next(1, 11);
                    var startR = rand.Next(1, 11);
                    int endR = startr, endC = startC;
                    var orientation = rand.Next(1, 101) % 2;

                    List<int> panelNum = new List<int>();
                    if (orientation == 0)
                    {
                        for (int i = 1; i < ship.width; i++)
                        {
                            endR++;
                        }
                    }
                    else
                    {
                        for (int i = 1; i < ship.width; i++)
                        {
                            endC++;
                        }
                    }

                    if(endR>10||endC>10)
                    {
                        isOpen = true;
                        continue;
                    }

                    var affectedPan = GameBoard.Panels.AddRange(startR, startC, endR, endC);
                }
            }
        }
    }
}
