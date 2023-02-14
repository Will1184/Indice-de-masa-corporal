namespace GM21057Guia4Ejercicio4Selectiva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAgregarElementos_Click(object sender, EventArgs e)
        {
            double altura = double.Parse(textAltura.Text);
            double peso=double.Parse(textPeso.Text);
            double imc =  (peso/Math.Pow(altura,2));
            
            valorImc.Text = imc.ToString();
            if (imc < 16)
            {
                diagnostico.Text = "Criterio de ingreso en hospital";
            }else if (imc >= 16 && imc < 17)
            {
                diagnostico.Text = "Infrapeso.";
            }
            else if (imc >= 17 && imc < 18)
            {
                diagnostico.Text = "Bajo peso.";
            }
            else if(imc >= 18 && imc < 25)
            {
                diagnostico.Text ="Peso normal (saludable).";
            }
            else if(imc >= 5 && imc < 30)
            {
                diagnostico.Text = "Sobrepeso (obesidad de grado I).";
            }
            else if(imc >= 30 && imc < 35)
            {
                diagnostico.Text = "Sobrepeso cr\u00F3nico (obesidad de grado II).";
            }
            else if(imc >= 35 && imc < 40)
            {
                diagnostico.Text = "Obesidad prem\u00F3rbida (obesidad de grado III).";
            }
            else if(imc >= 40)
            {
                diagnostico.Text = "Obesidad m\u00F3rbida (obesidad de grado IV).";
            }

        }

        private void textAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            textAltura.Clear();
            textPeso.Clear();
            valorImc.Clear();
            diagnostico.Clear();
        }
    }
}