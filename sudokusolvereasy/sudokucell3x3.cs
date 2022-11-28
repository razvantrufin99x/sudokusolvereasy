using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudokusolvereasy
{
    public partial class sudokucell3x3 : UserControl
    {
        public sudokucell3x3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.button1.BackColor != Color.Red) { this.button1.BackColor = Color.Red; }
            else { this.button1.BackColor = Color.Blue; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.button2.BackColor != Color.Red) { this.button2.BackColor = Color.Red; }
            else { this.button2.BackColor = Color.Blue; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.button3.BackColor != Color.Red) { this.button3.BackColor = Color.Red; }
            else { this.button3.BackColor = Color.Blue; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (this.button6.BackColor != Color.Red) { this.button6.BackColor = Color.Red; }
            else { this.button6.BackColor = Color.Blue; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.button5.BackColor != Color.Red) { this.button5.BackColor = Color.Red; }
            else { this.button5.BackColor = Color.Blue; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (this.button9.BackColor != Color.Red) { this.button9.BackColor = Color.Red; }
            else { this.button9.BackColor = Color.Blue; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (this.button8.BackColor != Color.Red) { this.button8.BackColor = Color.Red; }
            else { this.button8.BackColor = Color.Blue; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (this.button7.BackColor != Color.Red) { this.button7.BackColor = Color.Red; }
            else { this.button7.BackColor = Color.Blue; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.button4.BackColor != Color.Red) { this.button4.BackColor = Color.Red; }
            else { this.button4.BackColor = Color.Blue; }
        }
    }
}
