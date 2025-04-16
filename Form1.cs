namespace Calculadora_De_Salario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TXTNombre.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);
            TxtSalario.KeyPress += new KeyPressEventHandler(textBox2_KeyPress);
            TxtCargo.KeyPress += new KeyPressEventHandler(textBox1_KeyPress_1);
            ConfigurarDataGridView();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String nombre = TXTNombre.Text;

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten letras en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (e.KeyChar == '-')
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números negativos.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TABLA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigurarDataGridView()
        {

            Color formColor = this.BackColor;

            TABLA.BackgroundColor = formColor;
            TABLA.DefaultCellStyle.BackColor = formColor;
            TABLA.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            TABLA.DefaultCellStyle.ForeColor = Color.Black;
            TABLA.DefaultCellStyle.SelectionBackColor = Color.DarkBlue;
            TABLA.DefaultCellStyle.SelectionForeColor = Color.White;
            TABLA.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            TABLA.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            TABLA.EnableHeadersVisualStyles = false;
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("No se permiten números en este campo.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BotonCalcular_Click(object sender, EventArgs e)
        {
            string nombre = TXTNombre.Text;
            string salarioStr = TxtSalario.Text;
            string cargo = TxtCargo.Text;

            if (decimal.TryParse(salarioStr, out decimal salario))
            {
                decimal isss = salario >= 1000 ? 30 : Math.Round(salario * 0.03m, 2);
                decimal afp = Math.Round(salario * 0.0725m, 2);
                decimal renta = Math.Round(salario - isss - afp, 2);

                decimal impuestoSobreLaRenta = 0.00m;
                if (renta <= 472)
                {
                    impuestoSobreLaRenta = 0.00m;
                }
                else if (renta > 472 && renta <= 895.24m)
                {
                    impuestoSobreLaRenta = Math.Round(((renta - 472) * 0.10m) + 17.67m, 2);
                }
                else if (renta > 895.24m && renta <= 2038.10m)
                {
                    impuestoSobreLaRenta = Math.Round(((renta - 895.24m) * 0.20m) + 60.00m, 2);
                }
                else if (renta > 2038.10m)
                {
                    impuestoSobreLaRenta = Math.Round(((renta - 2038.10m) * 0.30m) + 288.57m, 2);
                }

                decimal salarioNeto = Math.Round(salario - isss - afp - impuestoSobreLaRenta, 2);

                decimal isssPatronal = salario >= 1000 ? 75.00m : Math.Round(salario * 0.075m, 2);
                decimal afpPatronal = Math.Round(salario * 0.0875m, 2);
                decimal totalisss = Math.Round(isss + isssPatronal, 2);
                decimal totalafp = Math.Round(afp + afpPatronal, 2);
                
                TABLA.Rows.Add(nombre, cargo, "$" + salario.ToString("F2"), "$" + isss.ToString("F2"), "$" + afp.ToString("F2"), "$" + renta.ToString("F2"), "$" + impuestoSobreLaRenta.ToString("F2"), "$" + salarioNeto.ToString("F2"), "$" + isssPatronal.ToString("F2"), "$" + afpPatronal.ToString("F2"), "$" + totalisss.ToString("F2"), "$" + totalafp.ToString("F2"));

            }
            else
            {
                MessageBox.Show("Por favor, ingrese un salario válido.", "Entrada inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            TxtCargo.Clear();
            TXTNombre.Clear();
            TxtSalario.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
