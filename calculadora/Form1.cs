using CustomControls.RJControls;
using operaciones;

namespace calculadora
{
    public partial class Form1 : Form
    {
        double resultado = 0;
        string operacion = string.Empty;
        bool enterValue = false;
        double ultimoNumero = 0;
        private Op_arimetica arimetica = new Op_arimetica();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnNum_click(object sender, EventArgs e)
        {
            if (textdisplay1.Text == "0" || enterValue)
                textdisplay1.Text = string.Empty;

            enterValue = false;
            RJButton button = (RJButton)sender;

            if (button.Text == ".")
            {
                if (!textdisplay1.Text.Contains("."))
                    textdisplay1.Text += button.Text;
            }
            else
            {
                textdisplay1.Text += button.Text;
            }
        }

        private void BtnOperador_click(object sender, EventArgs e)
        {
            RJButton button = (RJButton)sender;

            if (resultado != 0)
                btnIgual.PerformClick();
            else
                double.TryParse(textdisplay1.Text, out resultado);

            operacion = button.Text;
            enterValue = true;
            textdisplay2.Text = $"{resultado} {operacion}";
            textdisplay1.Text = string.Empty;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            double segNum;

            if (!double.TryParse(textdisplay1.Text, out segNum))
                segNum = ultimoNumero; 

            try
            {
                if (string.IsNullOrEmpty(operacion))
                {
                    return;
                }

                if (!enterValue)
                {
                    ultimoNumero = segNum;
                }

                double tempResultado = resultado;

                resultado = arimetica.operacionmatematicas(resultado, ultimoNumero, operacion);

                textdisplay1.Text = resultado.ToString();

                textdisplay2.Text = $"{tempResultado} {operacion} {ultimoNumero} = {resultado}";

                RtBoxDisplayHistory.AppendText($"{textdisplay2.Text}\n");

                enterValue = true;
            }
            catch (Exception ex)
            {
                textdisplay1.Text = ($"Error en el cálculo: {ex.Message}");
            }
        }


        private void Btn_Operaciones_Click(object sender, EventArgs e)
        {
            RJButton button = (RJButton)sender;
            operacion = button.Text;
            double num;

            if (!double.TryParse(textdisplay1.Text, out num)) return;

            try
            {
                switch (operacion)
                {
                    case "√x":
                        textdisplay2.Text = $"√({num})";
                        textdisplay1.Text = arimetica.operacionAritmeticas(num, resultado, operacion).ToString();
                        break;
                    case "^2":
                        textdisplay2.Text = $"{num}^2";
                        textdisplay1.Text = arimetica.operacionAritmeticas(num, resultado, operacion).ToString();
                        break;
                    case "⅟":
                        if (num == 0)
                        {
                            textdisplay1.Text = ("Error: División por cero no permitida");
                            return;
                        }
                        textdisplay2.Text = $"1/({num})";
                        textdisplay1.Text = arimetica.operacionAritmeticas(num, resultado, operacion).ToString();
                        break;
                    case "%":
                        textdisplay2.Text = $"{resultado} * {num}%";
                        textdisplay1.Text = arimetica.operacionAritmeticas(num, resultado, operacion).ToString();
                        break;
                    case "±":
                        textdisplay1.Text = arimetica.operacionAritmeticas(num, resultado, operacion).ToString();
                        break;
                }
                RtBoxDisplayHistory.AppendText($"{textdisplay2.Text} = {textdisplay1.Text}\n");
            }
            catch (Exception ex)
            {
                textdisplay1.Text = ($"Error en la operación: {ex.Message}");
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textdisplay1.Text = "0";
            textdisplay2.Text = string.Empty;
            resultado = 0;
            operacion = string.Empty;
            ultimoNumero = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textdisplay1.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (textdisplay1.Text.Length > 0)
                textdisplay1.Text = textdisplay1.Text.Remove(textdisplay1.Text.Length - 1);

            if (textdisplay1.Text == string.Empty)
                textdisplay1.Text = "0";
        }

        private void bntLimpiarHistorias_Click(object sender, EventArgs e)
        {
            RtBoxDisplayHistory.Clear();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
