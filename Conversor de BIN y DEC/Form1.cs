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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            frmBinToDec binarioDecimal = new frmBinToDec();
            this.Hide();
            binarioDecimal.Show();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            frmDecToBin decimalBinario = new frmDecToBin();
            this.Hide();
            decimalBinario.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
