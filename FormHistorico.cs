using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppCalc
{
    public partial class FormHistorico : Form
    {
        public FormHistorico(List<string> historico)
        {
            InitializeComponent();
            CriarInterface(historico);
        }

        private void CriarInterface(List<string> historico)
        {
            this.Text = "📊 Histórico de Cálculos";
            this.Size = new Size(450, 600);
            this.BackColor = Color.FromArgb(30, 30, 30);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            Panel panelMain = new Panel();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Padding = new Padding(20);
            this.Controls.Add(panelMain);

            Label lblTitulo = new Label();
            lblTitulo.Text = "📊 HISTÓRICO DE CÁLCULOS";
            lblTitulo.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(10, 10);
            panelMain.Controls.Add(lblTitulo);

            Label lblContador = new Label();
            lblContador.Text = $"Total: {historico.Count} operações";
            lblContador.Font = new Font("Segoe UI", 10);
            lblContador.ForeColor = Color.LightGray;
            lblContador.AutoSize = true;
            lblContador.Location = new Point(10, 45);
            panelMain.Controls.Add(lblContador);

            ListBox listHistorico = new ListBox();
            listHistorico.Location = new Point(10, 80);
            listHistorico.Size = new Size(400, 400);
            listHistorico.BackColor = Color.FromArgb(50, 50, 50);
            listHistorico.ForeColor = Color.White;
            listHistorico.Font = new Font("Consolas", 10);
            listHistorico.BorderStyle = BorderStyle.None;

            for (int i = historico.Count - 1; i >= 0; i--)
            {
                listHistorico.Items.Add($"{historico.Count - i}. {historico[i]}");
            }

            panelMain.Controls.Add(listHistorico);

            Button btnFechar = new Button();
            btnFechar.Text = "Fechar";
            btnFechar.Size = new Size(100, 35);
            btnFechar.Location = new Point(310, 490);
            btnFechar.BackColor = Color.FromArgb(70, 70, 90);
            btnFechar.ForeColor = Color.White;
            btnFechar.FlatStyle = FlatStyle.Flat;
            btnFechar.Font = new Font("Segoe UI", 10);
            btnFechar.Click += (s, e) => this.Close();
            panelMain.Controls.Add(btnFechar);
        }
    }
}