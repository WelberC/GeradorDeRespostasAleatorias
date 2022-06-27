
namespace SimOuNao
{
    partial class F_Gerador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tbx_Pergunta = new System.Windows.Forms.TextBox();
            this.Btn_FecharApp = new System.Windows.Forms.Button();
            this.Btn_ObterResposta = new System.Windows.Forms.Button();
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Pergunta = new System.Windows.Forms.Label();
            this.Lbl_Resposta = new System.Windows.Forms.Label();
            this.Lbl_Digite = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tbx_Pergunta
            // 
            this.Tbx_Pergunta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Tbx_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbx_Pergunta.Location = new System.Drawing.Point(242, 195);
            this.Tbx_Pergunta.Name = "Tbx_Pergunta";
            this.Tbx_Pergunta.Size = new System.Drawing.Size(352, 26);
            this.Tbx_Pergunta.TabIndex = 0;
            // 
            // Btn_FecharApp
            // 
            this.Btn_FecharApp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_FecharApp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.Btn_FecharApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_FecharApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_FecharApp.Location = new System.Drawing.Point(242, 345);
            this.Btn_FecharApp.Name = "Btn_FecharApp";
            this.Btn_FecharApp.Size = new System.Drawing.Size(352, 58);
            this.Btn_FecharApp.TabIndex = 1;
            this.Btn_FecharApp.Text = "Fechar app";
            this.Btn_FecharApp.UseVisualStyleBackColor = false;
            this.Btn_FecharApp.Visible = false;
            this.Btn_FecharApp.Click += new System.EventHandler(this.Btn_FecharApp_Click);
            // 
            // Btn_ObterResposta
            // 
            this.Btn_ObterResposta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Btn_ObterResposta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(133)))), ((int)(((byte)(139)))));
            this.Btn_ObterResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ObterResposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Btn_ObterResposta.Location = new System.Drawing.Point(242, 251);
            this.Btn_ObterResposta.Name = "Btn_ObterResposta";
            this.Btn_ObterResposta.Size = new System.Drawing.Size(352, 57);
            this.Btn_ObterResposta.TabIndex = 2;
            this.Btn_ObterResposta.Text = "Pedir a resposta";
            this.Btn_ObterResposta.UseVisualStyleBackColor = false;
            this.Btn_ObterResposta.Click += new System.EventHandler(this.Btn_ObterResposta_Click);
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Lbl_Titulo.Location = new System.Drawing.Point(237, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(320, 25);
            this.Lbl_Titulo.TabIndex = 3;
            this.Lbl_Titulo.Text = "Gerador de respostas aleatórias";
            // 
            // Lbl_Pergunta
            // 
            this.Lbl_Pergunta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_Pergunta.AutoSize = true;
            this.Lbl_Pergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Pergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Lbl_Pergunta.Location = new System.Drawing.Point(2, 71);
            this.Lbl_Pergunta.Name = "Lbl_Pergunta";
            this.Lbl_Pergunta.Size = new System.Drawing.Size(99, 25);
            this.Lbl_Pergunta.TabIndex = 4;
            this.Lbl_Pergunta.Text = "Pergunta";
            this.Lbl_Pergunta.Visible = false;
            // 
            // Lbl_Resposta
            // 
            this.Lbl_Resposta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Lbl_Resposta.AutoSize = true;
            this.Lbl_Resposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Resposta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Lbl_Resposta.Location = new System.Drawing.Point(2, 120);
            this.Lbl_Resposta.Name = "Lbl_Resposta";
            this.Lbl_Resposta.Size = new System.Drawing.Size(95, 25);
            this.Lbl_Resposta.TabIndex = 5;
            this.Lbl_Resposta.Text = "resposta";
            this.Lbl_Resposta.Visible = false;
            // 
            // Lbl_Digite
            // 
            this.Lbl_Digite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lbl_Digite.AutoSize = true;
            this.Lbl_Digite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Digite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Lbl_Digite.Location = new System.Drawing.Point(311, 156);
            this.Lbl_Digite.Name = "Lbl_Digite";
            this.Lbl_Digite.Size = new System.Drawing.Size(246, 25);
            this.Lbl_Digite.TabIndex = 6;
            this.Lbl_Digite.Text = "Digite sua pergunta aqui";
            this.Lbl_Digite.Visible = false;
            // 
            // F_Gerador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(762, 485);
            this.Controls.Add(this.Lbl_Digite);
            this.Controls.Add(this.Lbl_Resposta);
            this.Controls.Add(this.Lbl_Pergunta);
            this.Controls.Add(this.Lbl_Titulo);
            this.Controls.Add(this.Btn_ObterResposta);
            this.Controls.Add(this.Btn_FecharApp);
            this.Controls.Add(this.Tbx_Pergunta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "F_Gerador";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerador de Respostas (Sim ou Não)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tbx_Pergunta;
        private System.Windows.Forms.Button Btn_FecharApp;
        private System.Windows.Forms.Button Btn_ObterResposta;
        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Pergunta;
        private System.Windows.Forms.Label Lbl_Resposta;
        private System.Windows.Forms.Label Lbl_Digite;
    }
}

