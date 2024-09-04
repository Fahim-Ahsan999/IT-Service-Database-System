using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IT
{
    public partial class Log_in : Form
    {
        public static Log_in instance;
        public Log_in()

        {
            InitializeComponent();
            instance = this;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Info form = new Info();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            token form = new token();
            form.Show();

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Home form = new Home();
            form.Show();
        }
    }
}
