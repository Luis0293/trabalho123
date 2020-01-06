using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho123
{
    public partial class Form1 : Form
    {

        Classe1 calc = new Classe1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            calc.Altura = textBox1.Text;
            calc.Largura = textBox2.Text;
            if (radioButton1.Checked) label3.Text = calc.Multiplicar;
            else if (radioButton2.Checked) label3.Text = calc.Dividir;
            else if (radioButton3.Checked) label3.Text = calc.Somar;
            else if (radioButton4.Checked) label3.Text = calc.Subtrair;
        }
    }
}
