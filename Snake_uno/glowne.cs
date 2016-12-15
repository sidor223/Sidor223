using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_uno
{

    public enum Direction
    {
        wGore,
        wDol,
        wLewo,
        wPrawo
    };

    class glowne
    {
        public static int Wysokosc { get; set; }
        public static int Szerokosc { get; set; }
        public static int Szybkosc { get; set; }
        public static int Wynik { get; set; }
        public static int Punkty { get; set; }
        public static bool KoniecGry { get; set; }
        public static Direction Kierunek { get; set; }

        public glowne()

        {
            Szerokosc = 16;
            Wysokosc = 16;
            Szybkosc = 16;
            Wynik = 0;
            Punkty = 10;
            KoniecGry = false;
            Kierunek = Direction.wDol;

        }

    }
}