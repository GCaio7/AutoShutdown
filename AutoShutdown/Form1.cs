using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Teste1
{
    public partial class AutoShutdown : Form
    {
        int horas, minutos, segundos, tempoTotal;

        public AutoShutdown()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja cancelar o desligamento automático?", "Cancelar Agendamento", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            anularAgendamento();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(Primeira aplicação em C#, a fim de aprendizagem)\nGilson Caio - 2019\nwww.github/GCaio7", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", 
                "Sair", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question) == DialogResult.No) return;

            Application.Exit();
        }

        private void btn_ok_Click_1(object sender, EventArgs e)
        {
            if (edtTxt_horas.Text.Equals(""))
                edtTxt_horas.Text = "0";

            if (edtTxt_minutos.Text.Equals(""))
                edtTxt_minutos.Text = "0";

            if (edtTxt_segundos.Text.Equals(""))
                edtTxt_segundos.Text = "0";

            horas = int.Parse(edtTxt_horas.Text);
            minutos = int.Parse(edtTxt_minutos.Text);
            segundos = int.Parse(edtTxt_segundos.Text);
            tempoTotal = (horas * 3600) + (minutos * 60) + segundos;
            if (tempoTotal != 0)
            {
                if (MessageBox.Show("Deseja agendar para desligar em " + horas + " horas, " +
                    minutos + " minutos e " + segundos + " segundos?",
                    "Agendar", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.No) return;

                desligar(tempoTotal);
            }
            else
            {
                MessageBox.Show("Não foi possível agendar pois o tempo informado é inválido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void edtTxt_horas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void edtTxt_minutos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void edtTxt_segundos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void chkBox_dark_Click(object sender, EventArgs e)
        {
            switch (chkBox_dark.CheckState)
            {
                case CheckState.Checked:
                    BackColor = Color.DimGray;

                    edtTxt_horas.BackColor    = Color.DimGray;
                    edtTxt_minutos.BackColor  = Color.DimGray;
                    edtTxt_segundos.BackColor = Color.DimGray;

                    titulo.ForeColor      = Color.White;
                    txtHora.ForeColor     = Color.White;
                    txtMinutos.ForeColor  = Color.White;
                    txtSegundos.ForeColor = Color.White;

                    edtTxt_horas.ForeColor = Color.White;
                    edtTxt_minutos.ForeColor = Color.White;
                    edtTxt_segundos.ForeColor = Color.White;

                    chkBox_dark.ForeColor = Color.White;

                    break;
                case CheckState.Unchecked:
                    BackColor = default(Color);

                    edtTxt_horas.BackColor    = default(Color);
                    edtTxt_minutos.BackColor  = default(Color);
                    edtTxt_segundos.BackColor = default(Color);

                    titulo.ForeColor      = default(Color);
                    txtHora.ForeColor     = default(Color);
                    txtMinutos.ForeColor  = default(Color);
                    txtSegundos.ForeColor = default(Color);

                    edtTxt_horas.ForeColor    = default(Color);
                    edtTxt_minutos.ForeColor  = default(Color);
                    edtTxt_segundos.ForeColor = default(Color);

                    chkBox_dark.ForeColor = default(Color);

                    break;
            }
        }

        private void desligar(int segundos)
        {
            iniciarCmd("shutdown -s -t ", segundos, 0);
        }

        private void anularAgendamento()
        {
            iniciarCmd("shutdown -a", segundos, 1);
        }

        private void iniciarCmd(string comando, int segundos, byte ctrl)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.RedirectStandardInput = true;
            process.StartInfo.UseShellExecute = false;
            process.Start();

            if(ctrl == 0) //Agendar Desligamento
                process.StandardInput.WriteLine(comando + segundos);
            if(ctrl == 1) //Cancelar Agendamento
                process.StandardInput.WriteLine(comando);

            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();
        }
    }
}
