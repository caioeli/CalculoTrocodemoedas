using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoTrocodemoedas.View
{
    public partial class Telaprincipal : Form
    {
        public Telaprincipal()
        {
            InitializeComponent();
        }

        private void Telaprincipal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)

        //declaramos as variáveis para o tipo decimal


        {
            decimal valuebuy;

            decimal valuepay;

            decimal rest;

            // receber os valores nas decimas delaradas e converter para o decimal

            valuebuy = Convert.ToDecimal(textBoxvaluebuy.Text);
            valuepay = Convert.ToDecimal(textBoxpay.Text);

            if (valuebuy < valuepay)
            {
                

                    rest = valuepay - valuebuy;

                    labelresultbuy.Text = rest.ToString();

                    int coin100 = (int)(rest / 1);
                    rest = rest % 1m;
                    resultcoin1.Text = coin100.ToString();

                    //Resto = resto % 1;

                    int coin050 = (int)(rest / 0.50m);
                    rest = rest % 0.50m;
                    resultcoin05.Text = coin050.ToString();

                    int coin025 = (int)(rest / 0.25m);
                    rest = rest % 0.25m;
                    resultcoin025.Text = coin025.ToString();

                    int coin010 = (int)(rest / 0.10m);
                    rest = rest % 0.10m;
                    resultcoin010.Text = coin010.ToString();

                    int coin005 = (int)(rest / 0.05m);
                    rest = rest % 0.05m;
                    resultcoin005.Text = coin005.ToString();

                    int coin001 = (int)(rest / 0.01m);
                    rest = rest % 0.01m;
                    resultcoin001.Text = coin001.ToString();






                
            }else
            {
                MessageBox.Show("Falta Dinheiro");
            }


             if (textBoxvaluebuy.SelectedText == "" || textBoxpay.SelectedText == "")
             {
                    MessageBox.Show("Digite os Valores");
             } else
             { }

            }
      
        private void textBoxvaluebuy_TextChanged(object sender, EventArgs e)
        {

        }

    }

}



 


