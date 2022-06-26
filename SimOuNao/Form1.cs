using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimOuNao
{
    public partial class F_Gerador : Form
    {
        string pergunta;
        string[] respostas = new string[4] { "Sim", "Não", "Com certeza!", "Claro que não!" };

        public F_Gerador()
        {
            InitializeComponent();
        }

        private void Btn_ObterResposta_Click(object sender, EventArgs e)
        {
            if (Tbx_Pergunta.Text == "")
            {
                MessageBox.Show("Digite a pergunta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pergunta = Tbx_Pergunta.Text;
                Random rnd = new Random();
                int valorInteiro = rnd.Next(0, 4);

                Lbl_Pergunta.Text = "Sua pergunta: " + pergunta;
                Lbl_Resposta.Text = "Sua resposta: " + respostas[valorInteiro];

                Lbl_Pergunta.Visible = true;
                Lbl_Resposta.Visible = true;

                Btn_FecharApp.Visible = true;
                Btn_ObterResposta.Text = "Fazer uma nova pergunta";
                Tbx_Pergunta.Clear();
            }
        }

        private void Btn_FecharApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
