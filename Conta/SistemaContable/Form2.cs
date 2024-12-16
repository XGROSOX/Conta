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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_plan_cuentas_Click(object sender, EventArgs e)
        {
            Form3 S = new Form3();
            S.ShowDialog();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_B_General_Click(object sender, EventArgs e)
        {
            Balancegeneral T = new Balancegeneral();
            Hide();
            T.ShowDialog();
            Close();
          
        }
    }
}
