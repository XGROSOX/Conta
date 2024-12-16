using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conta_Tool
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_enter_Click(object sender, EventArgs e)
        {
            if (tbox_user.Text == "" || tbox_pwd.Text == "")
            {
                MessageBox.Show("Faltan llenar campos.");
            }
            else
            {
                tbox_pwd.Text = "";
                tbox_user.Text = "";
                Form2 R = new Form2();
                Hide();
                R.ShowDialog();
                Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
