using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoard
    {
    }
    public class Cordinates
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Cordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    public class Occupation
    {
        private Dictionary<string, string> occupationType = new Dictionary<string, string>()
        {
            {"Empty", "O" },
            {"Battleship","B" },
            {"Cruiser","C" },
            {"Destroyer","D" },
            {"Submarine","S" },
            {"Carrier","A" },
            {"Hit","X" },
            {"Miss", "M" }
        };
        public string occupation { get; set; }

        public Occupation(string s)
        {
            occupation = occupationType[s];
        }
            
    }
 
    public class Panel
    {

        public Cordinates Cordinates { get; set; }
        public Occupation Occupation { get; set; }

        public Panel(int row, int column, string status)
        {
            Cordinates = new Cordinates(row, column);
            Occupation = new Occupation(status);

        }

        public string getOccupation()
        {
            return Occupation.ToString();
        }
    }
}
