﻿using System;
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

    }
}
