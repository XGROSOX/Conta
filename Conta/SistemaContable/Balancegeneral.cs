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
    public partial class Balancegeneral : Form
    {

        public Balancegeneral()
        {
            
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 T = new Form2();
            Hide();
            T.ShowDialog();
            Close();
        }

        private void txt_Capi_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Balancegeneral_Load(object sender, EventArgs e)
        {
            txt_Capi.ReadOnly = true;
            txt_Resultado.ReadOnly = true;
            txt_Total_Activo.ReadOnly = true;
            txt_Total_Pasivo.ReadOnly=true;

        }

        private void txt_Resultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Total_Activo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Total_Pasivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit X = new Edit();
            Hide();
            X.ShowDialog();
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
