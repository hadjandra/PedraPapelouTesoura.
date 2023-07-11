namespace PedraPapelouTesoura_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_pedra = new Button();
            btn_papel = new Button();
            btn_tesoura = new Button();
            label1 = new Label();
            txt_usuario = new TextBox();
            resultado = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            placarUsuario = new TextBox();
            placarComputador = new TextBox();
            label5 = new Label();
            txt_maquina = new TextBox();
            SuspendLayout();
            // 
            // btn_pedra
            // 
            btn_pedra.Location = new Point(197, 118);
            btn_pedra.Name = "btn_pedra";
            btn_pedra.Size = new Size(112, 34);
            btn_pedra.TabIndex = 0;
            btn_pedra.Text = "Pedra";
            btn_pedra.UseVisualStyleBackColor = true;
            btn_pedra.Click += btn_pedra_Click;
            // 
            // btn_papel
            // 
            btn_papel.Location = new Point(332, 118);
            btn_papel.Name = "btn_papel";
            btn_papel.Size = new Size(112, 34);
            btn_papel.TabIndex = 1;
            btn_papel.Text = "Papel";
            btn_papel.UseVisualStyleBackColor = true;
            btn_papel.Click += btn_papel_Click;
            // 
            // btn_tesoura
            // 
            btn_tesoura.Location = new Point(463, 118);
            btn_tesoura.Name = "btn_tesoura";
            btn_tesoura.Size = new Size(112, 34);
            btn_tesoura.TabIndex = 2;
            btn_tesoura.Text = "Tesoura";
            btn_tesoura.UseVisualStyleBackColor = true;
            btn_tesoura.Click += btn_tesoura_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 191);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 3;
            label1.Text = "Escolha do Usuário";
            // 
            // txt_usuario
            // 
            txt_usuario.Enabled = false;
            txt_usuario.Location = new Point(387, 191);
            txt_usuario.Name = "txt_usuario";
            txt_usuario.Size = new Size(150, 31);
            txt_usuario.TabIndex = 4;
            // 
            // resultado
            // 
            resultado.AutoSize = true;
            resultado.Location = new Point(381, 318);
            resultado.Name = "resultado";
            resultado.Size = new Size(33, 25);
            resultado.TabIndex = 5;
            resultado.Text = "---";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(332, 18);
            label2.Name = "label2";
            label2.Size = new Size(108, 26);
            label2.TabIndex = 6;
            label2.Text = "PLACAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(223, 44);
            label3.Name = "label3";
            label3.Size = new Size(72, 25);
            label3.TabIndex = 7;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(461, 44);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 8;
            label4.Text = "Computador";
            // 
            // placarUsuario
            // 
            placarUsuario.Enabled = false;
            placarUsuario.Location = new Point(197, 72);
            placarUsuario.Name = "placarUsuario";
            placarUsuario.Size = new Size(121, 31);
            placarUsuario.TabIndex = 9;
            placarUsuario.Text = "0";
            placarUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // placarComputador
            // 
            placarComputador.Enabled = false;
            placarComputador.Location = new Point(461, 81);
            placarComputador.Name = "placarComputador";
            placarComputador.Size = new Size(127, 31);
            placarComputador.TabIndex = 10;
            placarComputador.Text = "0";
            placarComputador.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 233);
            label5.Name = "label5";
            label5.Size = new Size(170, 25);
            label5.TabIndex = 11;
            label5.Text = "Escolha da Máquina";
            // 
            // txt_maquina
            // 
            txt_maquina.Enabled = false;
            txt_maquina.Location = new Point(387, 233);
            txt_maquina.Name = "txt_maquina";
            txt_maquina.Size = new Size(150, 31);
            txt_maquina.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_maquina);
            Controls.Add(label5);
            Controls.Add(placarComputador);
            Controls.Add(placarUsuario);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(resultado);
            Controls.Add(txt_usuario);
            Controls.Add(label1);
            Controls.Add(btn_tesoura);
            Controls.Add(btn_papel);
            Controls.Add(btn_pedra);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_pedra;
        private Button btn_papel;
        private Button btn_tesoura;
        private Label label1;
        private TextBox txt_usuario;
        private Label resultado;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox placarUsuario;
        private TextBox placarComputador;
        private Label label5;
        private TextBox txt_maquina;
    }
}