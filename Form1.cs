

using Calculadora;

namespace AppCalc
{

    public partial class Form1 : Form
    {

        private Calculator _calc = new Calculator();
        private double _primeiroNumero = 0;
        private string _operacao = "";
        private bool _novoNumero = true;

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            
            try
            {
                string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
                string exeFolder = Path.GetDirectoryName(exePath)!;
                string iconPath = Path.Combine(exeFolder, "calculator.ico");

                if (File.Exists(iconPath))
                {
                    using (var stream = new FileStream(iconPath, FileMode.Open, FileAccess.Read))
                    {
                        this.Icon = new Icon(stream);
                    }
                }
            }
            catch
            {
                
                this.Icon = SystemIcons.Application;
            }
        }






        

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(30, 30, 30);
            txtDisplay.BackColor = Color.FromArgb(50, 50, 50);
            txtDisplay.ForeColor = Color.White;
            txtDisplay.Font = new Font("Segoe UI", 16, FontStyle.Bold);


            AplicarEstiloProfissional();
            MelhorarDisplay();
            ConectarEventosHover();

            MessageBox.Show($"Calculadora carregada! Operações: {_calc.QuantidadeOperacoes}");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "7";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "7";
            }
        }

        private void AplicarEstiloProfissional()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    btn.ForeColor = Color.White;

                    if (char.IsDigit(btn.Text[0]) || btn.Text == ".")
                        btn.BackColor = Color.FromArgb(60, 60, 60);
                    else if (btn.Text == "=")
                        btn.BackColor = Color.FromArgb(0, 122, 204);
                    else if (btn.Text == "C" || btn.Text == "CE")
                        btn.BackColor = Color.FromArgb(200, 60, 60);
                    else if (btn.Text == "√" || btn.Text == "%" || btn.Text == "H")
                        btn.BackColor = Color.FromArgb(70, 70, 90);
                    else
                        btn.BackColor = Color.FromArgb(50, 50, 70);
                }
            }
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.FromArgb(80, 80, 80);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (char.IsDigit(btn.Text[0]) || btn.Text == ".")
                btn.BackColor = Color.FromArgb(60, 60, 60);
            else if (btn.Text == "=")
                btn.BackColor = Color.FromArgb(0, 122, 204);
            else if (btn.Text == "C" || btn.Text == "CE")
                btn.BackColor = Color.FromArgb(200, 60, 60);
            else if (btn.Text == "√" || btn.Text == "%" || btn.Text == "H")
                btn.BackColor = Color.FromArgb(70, 70, 90);
            else
                btn.BackColor = Color.FromArgb(50, 50, 70);

        }

        private void MelhorarDisplay()
        {
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            txtDisplay.Padding = new Padding(0, 8, 10, 0);

            Panel panelDisplay = new Panel();
            panelDisplay.BackColor = Color.FromArgb(40, 40, 40);
            panelDisplay.Size = new Size(txtDisplay.Width + 10, txtDisplay.Height + 10);
            panelDisplay.Location = new Point(txtDisplay.Left - 5, txtDisplay.Top - 5);


            this.Controls.Add(panelDisplay);
            panelDisplay.Controls.Add(txtDisplay);


            txtDisplay.Location = new Point(5, 5);
            panelDisplay.BringToFront();
        }

        private void ConectarEventosHover()
        {

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.MouseEnter += btn_MouseEnter;
                    btn.MouseLeave += btn_MouseLeave;
                }
            }
        }



        private void btn8_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "8";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "9";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "9";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "4";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "5";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "6";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "6";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "1";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "2";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "3";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "3";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (_novoNumero)
            {
                txtDisplay.Text = "0";
                _novoNumero = false;
            }
            else
            {
                txtDisplay.Text += "0";
            }
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            _primeiroNumero = double.Parse(txtDisplay.Text);

            _operacao = "+";

            _novoNumero = true;
        }


        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (_operacao == "+")
            {
                double segundoNumero = double.Parse(txtDisplay.Text);
                double resultado = _primeiroNumero + segundoNumero;
                txtDisplay.Text = resultado.ToString();
                _calc.Somar((int)_primeiroNumero, (int)segundoNumero);
            }
            else if (_operacao == "-")
            {
                double segundoNumero = double.Parse(txtDisplay.Text);
                double resultado = _primeiroNumero - segundoNumero;
                txtDisplay.Text = resultado.ToString();
                _calc.Subtrair((int)_primeiroNumero, (int)segundoNumero); // ⭐ ADICIONADO
            }
            else if (_operacao == "*")
            {
                double segundoNumero = double.Parse(txtDisplay.Text);
                double resultado = _primeiroNumero * segundoNumero;
                txtDisplay.Text = resultado.ToString();
                _calc.Multiplicar((int)_primeiroNumero, (int)segundoNumero); // ⭐ ADICIONADO
            }
            else if (_operacao == "/")
            {
                double segundoNumero = double.Parse(txtDisplay.Text);
                double resultado = _primeiroNumero / segundoNumero;
                txtDisplay.Text = resultado.ToString();
                _calc.Dividir((int)_primeiroNumero, (int)segundoNumero); // ⭐ ADICIONADO
            }
            else if (_operacao == "%")
            {
                double numero = double.Parse(txtDisplay.Text);
                double resultado = _calc.CalcularPorcentagem((int)_primeiroNumero, (int)numero);
                txtDisplay.Text = resultado.ToString();
                // ⭐ Já está chamando o método correto
            }

            _operacao = "";
            _novoNumero = true;

        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtDisplay.Text);
            double resultado = _calc.RaizQuadrada(numero);
            txtDisplay.Text = resultado.ToString();
            _novoNumero = true;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            _primeiroNumero = double.Parse(txtDisplay.Text);
            _operacao = "%";
            _novoNumero = true;

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            _primeiroNumero = double.Parse(txtDisplay.Text);
            _operacao = "*";
            _novoNumero = true;
        }

        private void btnSubtrair_Click(object sender, EventArgs e)
        {
            _primeiroNumero = double.Parse(txtDisplay.Text);
            _operacao = "-";
            _novoNumero = true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _primeiroNumero = 0;
            _operacao = "";
            txtDisplay.Text = "0";
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            _primeiroNumero = double.Parse(txtDisplay.Text);
            _operacao = "/";
            _novoNumero = true;
        }

        private void btnLimparTudo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            _primeiroNumero = 0;
            _operacao = "";
            _novoNumero = true;
            _calc.LimparHistorico();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            if (_calc.GetHistorico().Count == 0)
            {
                MessageBox.Show("Nenhum cálculo no histórico ainda!", "Histórico",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            FormHistorico formHistorico = new FormHistorico(_calc.GetHistorico());
            formHistorico.ShowDialog();
        }
    }
}