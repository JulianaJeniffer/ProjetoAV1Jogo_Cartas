using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int carta2 = bntGerarCarta();
            int naipe2 = bntGerarNaipe();
            //MessageBox.Show("carta "+carta2+" naipe "+naipe2); // debug
            string nomeNaipe = "";
            // Troca o numero do naipe pela letra do nome 
            if (naipe2 == 1) nomeNaipe = "o";
            else if (naipe2 == 2) nomeNaipe = "p";
            else if (naipe2 == 3) nomeNaipe = "c";
            else nomeNaipe = "e";
            // monta o nome
            string nomeCarta2 = ("" + carta2 + "_" + nomeNaipe + ".png");
            pictureBox2.Load(@"..\..\imagens\" + nomeCarta2);

        }

        private int bntGerarCarta()
        {
            Random randCarta = new Random();
            return (randCarta.Next(1, 11));
        }
        private int bntGerarNaipe()
        {
            Random randNaipe= new Random();
            return (randNaipe.Next(1, 5));
        }
            
    }
}
