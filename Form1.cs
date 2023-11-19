using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula_17_03
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            int numtab, conttab, resptab;
            try
            {
                lsttab.Items.Clear();
                numtab = Convert.ToInt32(txtnumtab.Text);
                for (conttab = 1; conttab <= 10; conttab++)
                {
                    resptab = numtab * conttab;
                    lsttab.Items.Add(numtab + " X " + conttab + " = " + resptab);
                }
            }
            catch
            {
                MessageBox.Show("Por favor verifique o número para a tabuada.", "Alerta",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumtab.Clear();
            lsttab.Items.Clear();
            txtnumtab.Focus();
        }

        private void btncalcfat_Click(object sender, EventArgs e)
        {
            int numfat, contfat, respfat = 1;
            numfat = Convert.ToInt32(txtnumfat.Text);
            for(contfat=numfat;contfat>=1;contfat--)
            {
                respfat = respfat + contfat;
            }
            lblfat.Text = "Fatorial: " + respfat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int limite, cont, a = 1, b = 0, c = 0;
            string fibo = "";
            limite = Convert.ToInt32(txtfibo.Text);
            for (cont = 1; cont<=limite; cont++)
                {
                c = a + b;
                a = b; 
                b = c;
                fibo = fibo + c.ToString() + " ";
                }
            lblfibo.Text = "Fibonacci: " + fibo;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcprimo_Click(object sender, EventArgs e)
        {
            int numprimo, c, qtde = 0;
            numprimo = Convert.ToInt32(text_nuprimo.Text);
            for (c = 1; c <= numprimo; c++)
            {
               
                
                
                
                if (numprimo % c == 0)
                    {
                    qtde++;
                }
            }
            if (qtde == 2)
                lbl_primo.Text =  numprimo.ToString() + "é primo, amigo";
            else
            {
                lbl_primo.Text = numprimo.ToString() + " NAO é primo, amigo ";
            }
              
        }

        private void txtnumfat_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
