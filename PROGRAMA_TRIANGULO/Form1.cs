namespace PROGRAMA_TRIANGULO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnverificar_Click(object sender, EventArgs e)
        {
            try
            {
                double l1, l2, l3;
                l1 = Convert.ToDouble(txtlado1.Text);
                l2 = Convert.ToDouble(txtlado2.Text);
                l3 = Convert.ToDouble(txtlado3.Text);

            if((l1+l2 >=l3)&&(l1+l3 >= l2)&&(l2 + l3 >= l1))
                { 
                if(l1 == l2 && l2 == l3 && l3 == l1)
                    {
                        lbresultado.Text = "Triangulo Equilatero";
                    } 
                else if(l1 == l2 || l2 == l3 || l3 == l1)
                    {
                        lbresultado.Text = "Triangulo Isósceles";
                    }
                else if(l1 != l2 && l2 != l3 && l3 != l1)
                    {
                        lbresultado.Text = "Triangulo Escaleno";
                    }
                }
            else 
                { lbresultado.Text = "Não é um triangulo";
                }
            }
            catch
                {
                lbresultado.Text = "Error";
                MessageBox.Show("Insira valores numéricos válidos!", "Erro");

            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtlado1.Text = "";
            txtlado2.Text = "";
            txtlado3.Text = "";
        }
    }
}