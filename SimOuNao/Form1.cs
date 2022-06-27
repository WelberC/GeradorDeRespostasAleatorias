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
        //O atributo "pergunta" serve para armazenar a pergunta do usuário.
        string pergunta;
        //O vetor respostas armazena as possíveis respostas para a pergunta.
        string[] respostas = new string[4] { "Sim", "Não", "Com certeza!", "Claro que não!" };

        public F_Gerador()
        {
            InitializeComponent();
            Lbl_Digite.Visible = true;
        }

        private void Btn_ObterResposta_Click(object sender, EventArgs e)
        {
            //Se a TextBox estiver vazia, ele irá pedir pro usuário digitar a pergunta.
            if (Tbx_Pergunta.Text == "")
            {
                MessageBox.Show("Digite a pergunta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Caso o usuário tenha digitado a pergunta, o programa irá gerar a resposta aleatoriamente.
            else
            {
                pergunta = Tbx_Pergunta.Text;
                //Para gerar a resposta aleatória, pensei em gerar um número aleatório, entre 0 e 3
                //No nosso vetor, temos 4 posições, e, nas posições, temos as respostas possíveis
                Random rnd = new Random();
                int NumeroRandom = rnd.Next(0, 3);

                //Este label será exibido, mostrando a pergunta
                Lbl_Pergunta.Text = "Sua pergunta: " + pergunta;

                //Então, basicamente, a resposta da pergunta será o vetor respostas, no índice do número aleatório que será gerado.
                //Assim, a resposta gerada aleatoriamente da pergunta aparecerá na tela para o usuário 
                Lbl_Resposta.Text = "Sua resposta: " + respostas[NumeroRandom];

                //Aqui permitimos que estes labels fiquem visíveis
                Lbl_Pergunta.Visible = true;
                Lbl_Resposta.Visible = true;

                //E aqui, deixamos o botão de fechar o app visível
                Btn_FecharApp.Visible = true;
                Btn_ObterResposta.Text = "Fazer uma nova pergunta";
                Tbx_Pergunta.Clear();
            }
        }

        private void Btn_FecharApp_Click(object sender, EventArgs e)
        {
            //E, para fechar o programa, utilizamos o this.close, pois, há somente este formulário rodando
            this.Close();
        }
    }
}
