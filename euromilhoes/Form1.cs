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

        private void estrela(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == "X")
            {
                temp.Text = "";
                nestrelas--;
            }
            else if (nestrelas<2)
            {
                temp.Text = "X";
                nestrelas++;
            }
            teste.Text = temp.Tag.ToString();
        }

        private void numeros(object sender, EventArgs e)
        {
            Label temp = (Label)sender;
            if (temp.Text == "X")
            {
                temp.Text = "";
                nnumero--;
            }
            else if (nnumero < 5)
            {
                temp.Text = "X";
                nnumero++;
            }
            teste.Text = temp.Tag.ToString();
        }

        private void Label63_Click(object sender, EventArgs e)
        {

        }
    }
}
