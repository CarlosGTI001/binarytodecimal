using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_de_BIN_y_DEC
{
    public partial class frmBinToDec : Form
    {
        public frmBinToDec()
        {
            InitializeComponent();
        }

        private void frmBinToDec_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertBaD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBinario.Text))
            {
                txtDecimal.Text = bintodac(txtBinario.Text);
            }
            else
            {
                MessageBox.Show("Error", "Debes ingresar algun dato!");
            }
        }
        public string bintodac(string dec)
        {

           
            int decima = 0;

            char[] bit = dec.ToCharArray(0, 8);
            int valor = 1;
            for(int contador = 8; contador > 0; contador--) {
                if (bit[contador - 1] == '1')
                {
                    decima = decima + valor;
                    valor = valor * 2;
                }
                else
                {
                    valor = valor * 2;
                }
            }
            

            return (Convert.ToString(decima));
        }

        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard(); 
            this.Hide();
            dashboard.Show();
        }
    }
}
