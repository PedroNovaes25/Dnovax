namespace Dnovax
{
    partial class form_Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Entrar = new System.Windows.Forms.Button();
            this.btb_Cadastro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_ConfirmarSenha = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.mask_dataNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.mask_dataNascimento);
            this.panel1.Controls.Add(this.cb_sexo);
            this.panel1.Controls.Add(this.btn_Entrar);
            this.panel1.Controls.Add(this.btb_Cadastro);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_ConfirmarSenha);
            this.panel1.Controls.Add(this.txt_Nome);
            this.panel1.Controls.Add(this.txt_Senha);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Email);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 504);
            this.panel1.TabIndex = 0;
            // 
            // btn_Entrar
            // 
            this.btn_Entrar.BackColor = System.Drawing.Color.LightGray;
            this.btn_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Entrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Entrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Entrar.Image = global::Dnovax.Properties.Resources.logout30px__1_;
            this.btn_Entrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Entrar.Location = new System.Drawing.Point(392, 19);
            this.btn_Entrar.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.btn_Entrar.Name = "btn_Entrar";
            this.btn_Entrar.Size = new System.Drawing.Size(119, 34);
            this.btn_Entrar.TabIndex = 8;
            this.btn_Entrar.Text = "Logar";
            this.btn_Entrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Entrar.UseVisualStyleBackColor = false;
            this.btn_Entrar.Click += new System.EventHandler(this.btn_Entrar_Click);
            // 
            // btb_Cadastro
            // 
            this.btb_Cadastro.BackColor = System.Drawing.Color.LightGray;
            this.btb_Cadastro.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btb_Cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btb_Cadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_Cadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btb_Cadastro.Image = global::Dnovax.Properties.Resources.cadastro30px;
            this.btb_Cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btb_Cadastro.Location = new System.Drawing.Point(191, 430);
            this.btb_Cadastro.Name = "btb_Cadastro";
            this.btb_Cadastro.Size = new System.Drawing.Size(139, 34);
            this.btb_Cadastro.TabIndex = 7;
            this.btb_Cadastro.Text = "Cadastrar";
            this.btb_Cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btb_Cadastro.UseVisualStyleBackColor = false;
            this.btb_Cadastro.Click += new System.EventHandler(this.btb_Cadastro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "Confirmar Senha:";
            // 
            // txt_ConfirmarSenha
            // 
            this.txt_ConfirmarSenha.BackColor = System.Drawing.Color.LightGray;
            this.txt_ConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ConfirmarSenha.ForeColor = System.Drawing.Color.Transparent;
            this.txt_ConfirmarSenha.Location = new System.Drawing.Point(74, 378);
            this.txt_ConfirmarSenha.Multiline = true;
            this.txt_ConfirmarSenha.Name = "txt_ConfirmarSenha";
            this.txt_ConfirmarSenha.Size = new System.Drawing.Size(172, 25);
            this.txt_ConfirmarSenha.TabIndex = 6;
            // 
            // txt_Nome
            // 
            this.txt_Nome.BackColor = System.Drawing.Color.LightGray;
            this.txt_Nome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Nome.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Nome.Location = new System.Drawing.Point(74, 91);
            this.txt_Nome.Multiline = true;
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(172, 25);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Senha
            // 
            this.txt_Senha.BackColor = System.Drawing.Color.LightGray;
            this.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Senha.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Senha.Location = new System.Drawing.Point(74, 322);
            this.txt_Senha.Multiline = true;
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(172, 25);
            this.txt_Senha.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "E-mail:";
            // 
            // txt_Email
            // 
            this.txt_Email.BackColor = System.Drawing.Color.LightGray;
            this.txt_Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Email.ForeColor = System.Drawing.Color.Transparent;
            this.txt_Email.Location = new System.Drawing.Point(74, 266);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(172, 25);
            this.txt_Email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data Nascimento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Sexo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Dnovax.Properties.Resources.circuito220px;
            this.pictureBox2.Location = new System.Drawing.Point(298, 147);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 218);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dnovax.Properties.Resources.dnovax250;
            this.pictureBox1.Location = new System.Drawing.Point(14, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 50);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // cb_sexo
            // 
            this.cb_sexo.BackColor = System.Drawing.Color.DarkGray;
            this.cb_sexo.ForeColor = System.Drawing.SystemColors.MenuText;
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.cb_sexo.Location = new System.Drawing.Point(74, 147);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(121, 21);
            this.cb_sexo.TabIndex = 2;
            // 
            // mask_dataNascimento
            // 
            this.mask_dataNascimento.BackColor = System.Drawing.Color.LightGray;
            this.mask_dataNascimento.Location = new System.Drawing.Point(74, 206);
            this.mask_dataNascimento.Mask = "00/00/0000";
            this.mask_dataNascimento.Name = "mask_dataNascimento";
            this.mask_dataNascimento.Size = new System.Drawing.Size(172, 20);
            this.mask_dataNascimento.TabIndex = 3;
            // 
            // form_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 530);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "form_Cadastro";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.TextBox txt_ConfirmarSenha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btb_Cadastro;
        private System.Windows.Forms.Button btn_Entrar;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.MaskedTextBox mask_dataNascimento;
    }
}