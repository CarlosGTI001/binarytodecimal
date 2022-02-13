using System;
using System.Windows.Forms;

namespace Conversor_de_BIN_y_DEC
{
    public partial class frmDecToBin : Form
    {
        public frmDecToBin()
        {
            InitializeComponent();
        }

        private void btnConvertDaB_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtDecimal.Text))
                try
                {
                    txtBinario.Text = dactobin(Convert.ToInt32(txtDecimal.Text));
                }
                catch(FormatException)
                {
                    MessageBox.Show("Debes ingresar un valor numerico", "Error");
                }
                catch
                {
                    MessageBox.Show("Debes ingresar datos para continuar", "Error");
                }
            else
                MessageBox.Show("Alerta", "Alerta2");
        }

        public string dactobin(int dec)
        {

            int ant;
            int two = 2;

            int bin1, bin2, bin3, bin4, bin5, bin6, bin7, bin8;
            //Console.WriteLine("Bienvenido al Conversor de decimal a Binario\n ------- \nIngresa un numero decimal:");
            ant = dec;

            bin1 = dec % two;
            dec = dec / two;
            // Console.WriteLine(""+Convert.ToString(bin1)+"\n"+Convert.ToString(dec)+"\n");
            bin2 = dec % two;
            dec = dec / two;
            // Console.WriteLine(""+Convert.ToString(bin2)+"\n"+Convert.ToString(dec)+"\n");
            bin3 = dec % two;
            dec = dec / two;
            // Console.WriteLine(""+Convert.ToString(bin3)+"\n"+Convert.ToString(dec)+"\n");
            bin4 = dec % two;
            dec = dec / two;
            // Console.WriteLine(""+Convert.ToString(bin4)+"\n"+Convert.ToString(dec)+"\n");
            bin5 = dec % two;
            dec = dec / two;
            // Console.WriteLine(""+Convert.ToString(bin5)+"\n"+Convert.ToString(dec)+"\n");
            bin6 = dec % two;
            dec = dec / two;
            //  Console.WriteLine(""+Convert.ToString(bin6)+"\n"+Convert.ToString(dec)+"\n");
            bin7 = dec % two;
            dec = dec / two;
            //  Console.WriteLine(""+Convert.ToString(bin7)+"\n"+Convert.ToString(dec)+"\n");
            bin8 = dec % two;
            dec = dec / two;
            //  Console.WriteLine(""+Convert.ToString(bin8)+"\n"+Convert.ToString(dec)+"\n");
            string binario;
            binario = "" + bin8 + bin7 + bin6 + bin5 + bin4 + bin3 + bin2 + bin1 + "";
            return (binario);
        }

        private void btnVolverDashboard_Click(object sender, EventArgs e)
        {
            frmDashboard dashboard = new frmDashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}
