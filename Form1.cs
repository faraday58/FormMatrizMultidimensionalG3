using System;
using System.Windows.Forms;

namespace FormMatrizMultidimensionalG3
{
    public partial class Form1 : Form
    {
        Unidimensional u1;
        Unidimensional u2;
        Unidimensional u3;
        Multidimensional m1;
        Multidimensional m2;
        Multidimensional m3;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if( txtbMatriz.Text.Contains(";"))
                {
                    m1 = Multidimensional.Leer(txtbMatriz.Text);
                    lbMatriz1.Text = m1.ToString();
                }
                else
                {
                    u1 = Unidimensional.Leer(txtbMatriz.Text);
                    lbMatriz1.Text = u1.ToString();
                }               
                
                errorProviderTxtb.Clear();
            }
            catch (FormatException error)
            {
                errorProviderTxtb.SetError(txtbMatriz, error.Message);
            }
            catch (Exception error )
            {
                errorProviderTxtb.SetError(txtbMatriz, error.Message);
            }            
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            try
            {
                if(   txtbMatriz.Text.Contains(";")  )
                {
                    m2 = Multidimensional.Leer(txtbMatriz.Text);
                    lbMatriz2.Text = m2.ToString();
                    m3 = m1 + m2;
                    lbResultado.Text = m3.ToString();
                }
                else
                {
                    u2 = Unidimensional.Leer(txtbMatriz.Text);
                    lbMatriz2.Text = u2.ToString();
                    u3 = u1 + u2;
                    lbResultado.Text = u3.ToString();
                }
                errorProviderTxtb.Clear();
            }
            catch(FormatException error)
            {
                errorProviderTxtb.SetError(txtbMatriz, error.Message);
            }
            catch(NullReferenceException error)
            {
                errorProviderTxtb.SetError(txtbMatriz, error.Message);
            }
            catch(Exception error)
            {
                errorProviderTxtb.SetError(txtbMatriz, error.Message);
            }
        }
    }
}
