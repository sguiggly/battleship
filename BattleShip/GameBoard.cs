using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class GameBoard
    {
        public List<Panel> Panels { get; set; }
        public GameBoard()
        {
            Panels = new List<Panel>();
            for (int i = 1; i <=10; i++)
            {
                for (int j = 1; j<=10; j++)
                {
                    Panels.Add(new Panel(i, j, "Empty"));
                }
            }
        }
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
    public static class PanelExtensions
    {
        public static List<Panel> Range(this List<Panel> panels, int startRow, int startColumn, int endRow, int endColumn)
        {
            return panels.Where(x => x.Coordinates.Row >= startRow
                                        && x.Coordinates.Column >= startColumn
                                        && x.Coordinates.Row <= endRow
                                        && x.Coordinates.Column <= endColumn).ToList();
        }
    }

    public abstract class Ship
    {
        public string name { get; set; }
        public int width { get; set; }
        public int hits { get; set; }
        public Occupation occupation { get; set; }
        public bool isSunk
        {
            get
            {
                return hits >= width;
            }
        }
    }

    public class Destroyer : Ship
    {
        public Destroyer()
        {
            name = "Destroyer";
            width = 2;
            occupation = Occupation(name);
        }
    }

   
}
