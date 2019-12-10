using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace euromilhoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int nestrelas = 0, nnumero = 0;
        private const string cruz = "X";
        private Bilhetes E = new Bilhetes();
        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.estrela(Convert.ToInt32(temp.Tag)-1);
            teste1.Text = E.listao;
        }

        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.numero(Convert.ToInt32(temp.Tag)+1);
            teste.Text = E.listanum;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        int randomnumber;
        private void Button1_Click(object sender, EventArgs e)
        {
            randomnumber = rnd.Next(50);
            randomnumber = rnd.Next(50);
            randomnumber = rnd.Next(50);
            randomnumber = rnd.Next(50);
            randomnumber = rnd.Next(50);
            label63.Text = randomnumber.ToString();
            label63.Text = randomnumber.ToString();
            label63.Text = randomnumber.ToString();
            label63.Text = randomnumber.ToString();
            label63.Text = randomnumber.ToString();

        }

        private void Label63_Click(object sender, EventArgs e)
        {

        } 
    }
}
