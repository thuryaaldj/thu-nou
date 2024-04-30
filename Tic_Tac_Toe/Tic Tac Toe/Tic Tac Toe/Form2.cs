using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ex_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pl_Click(object sender, EventArgs e)
        {
            Form1.playernames(textBox1.Text, textBox2.Text);
            Form1 form1 = new Form1();
            if (textBox2.Text == "computer")
            {
                form1.mode = true;
            }
            form1.Show();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }
        //هي شو بتعمل ؟
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pl.PerformClick();
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
