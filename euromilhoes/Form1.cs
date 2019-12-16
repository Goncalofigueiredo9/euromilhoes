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
        }

        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            temp.Text = E.numero(Convert.ToInt32(temp.Tag)+1);
        }

        private int[] sorteia(int qtd, int max)
        {
            Random rnd = new Random();
            List<int> l = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                int tmp;
                do tmp = rnd.Next(1, max);
                while (l.Contains(tmp));
                l.Add(tmp);
            }
            l.Sort();
            return l.ToArray();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int[] n = sorteia(5, 51);
            int[] s = sorteia(2, 12);

            n1.Text = n[0].ToString();
            n2.Text = n[1].ToString();
            n3.Text = n[2].ToString();
            n4.Text = n[3].ToString();
            n5.Text = n[4].ToString();

            s1.Text = s[0].ToString();
            s2.Text = s[1].ToString();
        }


        private void Label63_Click_1(object sender, EventArgs e)
        {

        }

        private void Label63_Click(object sender, EventArgs e)
        {

        } 
    }

}