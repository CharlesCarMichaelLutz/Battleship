using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    internal class GamePlay
    {
        public string cannon;
        public string name;
        public int    length;

        public GamePlay(string aCannon, string aName, int aLength)
        {
            cannon = aCannon;
            name = aName;
            length = aLength;

        }

    }

  
}
