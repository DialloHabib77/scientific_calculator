using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Welcome : Form
    {
        private string text;
        private int len = 0;
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            text = label1.Text;
            label1.Text = "";
            timer1.Start();
            timer2.Start();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (progressBar1.Value < 50)
            {
                progressBar1.Value += 1;
                label2.Text = progressBar1.Value.ToString() + "%";
            }
            else
            {
                timer1.Stop();
                Close();
                Form1 form = new Form1();
                form.Show();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // animation texte
            if (len < text.Length)
            {
                label1.Text = label1.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                timer2.Stop();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
