using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    class Program
    {
        private static void PrintProperties(Panel myObj)
        {
            foreach (var prop in myObj.GetType().GetProperties())
            {
                Console.WriteLine(prop.Name + ": " + prop.GetValue(myObj, null));
            }

            foreach (var field in myObj.GetType().GetFields())
            {
                Console.WriteLine(field.Name + ": " + field.GetValue(myObj));
            }
        }
        static void Main(string[] args)
        {
            object panel = new Panel(1, 1, "Carrier");
            //string status = panel.getOccupation();
            Type type = panel.GetType();
            foreach (PropertyInfo info in type.GetProperties()){
                Console.WriteLine(info);
            }
        }
    }
}
