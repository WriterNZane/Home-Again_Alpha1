using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HomeAgain
{
    public class Player
    {
        public string name;
        public void DisplayInfo()
        {
            Console.WriteLine($"Player: {name}");
        }

    }
}
