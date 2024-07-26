namespace Mustache.MustacheFrm
{
    partial class FrmUsuario
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
            label1 = new Label();
            button1 = new Button();
            btnInserir = new Button();
            groupbox1 = new GroupBox();
            txtNivel = new TextBox();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            label7 = new Label();
            txtSenha = new TextBox();
            label8 = new Label();
            label6 = new Label();
            txtConfirme = new TextBox();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 25);
            label1.Name = "label1";
            label1.Size = new Size(108, 33);
            label1.TabIndex = 10;
            label1.Text = "Usuário";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 11F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(83, 434);
            button1.Name = "button1";
            button1.Size = new Size(67, 30);
            button1.TabIndex = 7;
            button1.Text = "&Editar";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnInserir
            // 
            btnInserir.BackColor = SystemColors.InfoText;
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Century Gothic", 11F);
            btnInserir.ForeColor = SystemColors.ButtonHighlight;
            btnInserir.Location = new Point(442, 434);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(67, 30);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            // 
            // groupbox1
            // 
            groupbox1.BackColor = SystemColors.ButtonFace;
            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(txtConfirme);
            groupbox1.Controls.Add(txtNivel);
            groupbox1.Controls.Add(txtEmail);
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(label7);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(label8);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(txtNome);
            groupbox1.Controls.Add(txtSenha);
            groupbox1.Controls.Add(txtCpf);
            groupbox1.Location = new Point(134, 76);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(338, 295);
            groupbox1.TabIndex = 9;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            // 
            // txtNivel
            // 
            txtNivel.Location = new Point(181, 118);
            txtNivel.Name = "txtNivel";
            txtNivel.Size = new Size(128, 23);
            txtNivel.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 100);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 5;
            label5.Text = "Nivel";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(36, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += this.txtEmail_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 100);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(209, -18);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(36, 118);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(121, 23);
            txtCpf.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(36, 155);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 5;
            label7.Text = "Email";
            label7.Click += label7_Click;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(36, 226);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(121, 23);
            txtSenha.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 208);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = "Senha";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(191, 208);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 7;
            label6.Text = "Confirme a Senha";
            // 
            // txtConfirme
            // 
            txtConfirme.Location = new Point(188, 226);
            txtConfirme.Name = "txtConfirme";
            txtConfirme.Size = new Size(121, 23);
            txtConfirme.TabIndex = 6;
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 522);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button btnInserir;
        private GroupBox groupbox1;
        private TextBox txtNivel;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCpf;
        private Label label7;
        private Label label8;
        private TextBox txtSenha;
        private Label label6;
        private TextBox txtConfirme;
    }
}