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
            punkt head = new Snake_uno.punkt();
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
            else
            {
                string koniecGry = " Koniec gry! \n Wynik:" + glowne.Wynik + "\n Wciśnij enter, aby zagrać ponownie";
                KomunikatKoncaGry.Text = koniecGry;
                KomunikatKoncaGry.Visible = true;
            }

                    private void RuchGracza()
        {
            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (glowne.Kierunek)
                    {
                        case Direction.wPrawo:
                            Snake[i].X++;
                            break;
                        case Direction.wLewo:
                            Snake[i].X--;
                            break;
                        case Direction.wGore:
                            Snake[i].Y--;
                            break;
                        case Direction.wDol:
                            Snake[i].Y++;
                            break;

                    }

                    int maxXPos = plansza_gry.Size.Width / glowne.Wysokosc;
                    int maxYPos = plansza_gry.Size.Height / glowne.Szerokosc;

                    //kKolizcja z bokami planszy
                    if (Snake[i].X < 0 || Snake[i].Y < 0
                        || Snake[i].X >= maxXPos || Snake[i].Y >= maxYPos)
                    {
                        smierc();
                    }


                    //Kolizja z cialem
                    for (int j = 1; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X &&
                           Snake[i].Y == Snake[j].Y)
                        {
                            smierc();
                        }
                    }

                    //Kolizja z jedzeniem
                    if (Snake[0].X == jedzenie.X && Snake[0].Y == jedzenie.Y)
                    {
                        jedz();
                    }

                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            rozpoznawanie_klawiszy.ChangeState(e.KeyCode, false);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            rozpoznawanie_klawiszy.ChangeState(e.KeyCode, true);
        }

        private void smierc()
        {
            glowne.KoniecGry = true;
        }

        private void jedz()
        {
            //dodawanie kolejnych punktow do ciala
            punkt punkt = new punkt
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(punkt);

            //aktualizacja licznika wyniku
            glowne.Wynik += glowne.Punkty;
            wyswietlacz_wyniku.Text = glowne.Wynik.ToString();

            GeneratorJedzenia();
        }



    }
}
