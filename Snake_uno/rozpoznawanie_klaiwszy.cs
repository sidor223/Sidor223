using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_uno
{
    class rozpoznawanie_klawiszy
    {
        private static Hashtable keyTable = new Hashtable(); // zaladowanie listy dostepnych klawiszy do uzycia

        public static bool KeyPressed(Keys key)
        {
            if (keyTable[key] == null)
            {
                return false;
            }

            return (bool)keyTable[key];
        }

        public static void ChangeState(Keys key, bool state)
        {
            keyTable[key] = state;
        }
    }
}
