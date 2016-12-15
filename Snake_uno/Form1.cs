using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_uno
{
    public partial class Form1 : Form
    {

        private List<punkt> Snake = new List<punkt>();
        private punkt jedzenie = new punkt();

        public Form1()
        {
            InitializeComponent();

            new glowne();

            CzasGry.Interval = 3000 / glowne.Szybkosc;
            CzasGry.Tick += AktualizacjaObrazu;
            CzasGry.Start();

            StartGame();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void StartGame()

        {

            KomunikatKoncaGry.Visible = false;
            new glowne();

            Snake.Clear();
            punkt head = new Snake.punkt();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            // wyswietlacz_wyniku = glowne.Wynik.ToString();
            GeneratorJedzenia();

        }

        private void GeneratorJedzenia()
        {
            int maxXPos = plansza_gry.Size.Width / glowne.Wysokosc;
            int maxYPos = plansza_gry.Size.Height / glowne.Szerokosc;

            Random random = new Random();
            jedzenie = new punkt();
            jedzenie.X = random.Next(0, maxXPos);
            jedzenie.Y = random.Next(0, maxYPos);

        }
        private void AktualizacjaObrazu(object sender, EventArgs e)
        {
            if (glowne.KoniecGry == true)
            {
                if (rozpoznawanie_klawiszy.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }
            else
            {
                if (rozpoznawanie_klawiszy.KeyPressed(Keys.Right) && glowne.Kierunek != Direction.wLewo)
                    glowne.Kierunek = Direction.wPrawo;
                else if (rozpoznawanie_klawiszy.KeyPressed(Keys.Left) && glowne.Kierunek != Direction.wPrawo)
                    glowne.Kierunek = Direction.wLewo;
                else if (rozpoznawanie_klawiszy.KeyPressed(Keys.Up) && glowne.Kierunek != Direction.wDol)
                    glowne.Kierunek = Direction.wGore;
                else if (rozpoznawanie_klawiszy.KeyPressed(Keys.Down) && glowne.Kierunek != Direction.wGore)
                    glowne.Kierunek = Direction.wDol;

                RuchGracza();
            }

            plansza_gry.Invalidate();
        }

        private void plansza_gry_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            if (!glowne.KoniecGry)

                for (int i = 0; i < Snake.Count; i++)

                {
                    Brush snakeColour;
                    if (i == 0)
                        snakeColour = Brushes.Blue;     //glowka
                    else
                        snakeColour = Brushes.Green;    //cialo

                    //rysowanie wezyka
                    canvas.FillEllipse(snakeColour,
                        new Rectangle(Snake[i].X * glowne.Wysokosc,
                                      Snake[i].Y * glowne.Szerokosc,
                                      glowne.Wysokosc, glowne.Szerokosc));


                    //rysowanie jedzenia
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(jedzenie.X * glowne.Wysokosc,
                             jedzenie.Y * glowne.Wysokosc, glowne.Szerokosc, glowne.Wysokosc));

                }
        }
}
