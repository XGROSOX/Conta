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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void btn_A_Corri_Click(object sender, EventArgs e)
        {
            Balancegeneral t = new Balancegeneral();
            
            t.Show();
           Close();
        }

        private void btn_A_Exi_Click(object sender, EventArgs e)
        {
            Balancegeneral h = new Balancegeneral();
           
            h.Show();
          Close();
        }

        private void btn_A_No_Exi_Click(object sender, EventArgs e)
        {
            Balancegeneral i = new Balancegeneral();
           
            i.Show();
           Close();
        }

        private void btn_A_Real_Click(object sender, EventArgs e)
        {
            Balancegeneral w = new Balancegeneral();
            
            w.Show();
            Close();
        }

        private void btn_P_Exi_Click(object sender, EventArgs e)
        {
            Balancegeneral r = new Balancegeneral();
            
            r.Show();
          Close();
        }

        private void btn_Capi_Click(object sender, EventArgs e)
        {
            Balancegeneral u = new Balancegeneral();
            
            u.Show();
          Close();
        }

        private void btn_Resultado_Click(object sender, EventArgs e)
        {
            Balancegeneral m = new Balancegeneral();
            
            m.Show();
            Close();
            
        }
    }
}
