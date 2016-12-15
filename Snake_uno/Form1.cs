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
    }
}
