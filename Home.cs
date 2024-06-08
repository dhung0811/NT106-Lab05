using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var openForm = new Bai1();
            openForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var openForm = new Bai2();
            openForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var openForm = new Login();
            openForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var openForm = new Bai3();
            openForm.Show();
        }
    }
}
