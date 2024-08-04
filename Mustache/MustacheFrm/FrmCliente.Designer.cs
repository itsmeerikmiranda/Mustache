namespace Mustache.MustacheFrm
{
    partial class FrmCliente
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            cbAtivo = new CheckBox();
            dtpData_nasc = new DateTimePicker();
            txtTelefone = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCpf = new TextBox();
            tabPage2 = new TabPage();
            txtComplemento = new TextBox();
            label7 = new Label();
            txtBairro = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtLogradouro = new TextBox();
            txtNumero = new TextBox();
            label1 = new Label();
            txtCidade = new TextBox();
            txtUf = new TextBox();
            label11 = new Label();
            txtCep = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtTipo = new TextBox();
            button1 = new Button();
            btnInserir = new Button();
            button2 = new Button();
            button3 = new Button();
            label14 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(118, 97);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(501, 477);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(btnInserir);
            tabPage1.Controls.Add(cbAtivo);
            tabPage1.Controls.Add(dtpData_nasc);
            tabPage1.Controls.Add(txtTelefone);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtNome);
            tabPage1.Controls.Add(txtCpf);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(493, 449);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Dados Pessoais";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // cbAtivo
            // 
            cbAtivo.AutoSize = true;
            cbAtivo.Location = new Point(319, 290);
            cbAtivo.Name = "cbAtivo";
            cbAtivo.Size = new Size(54, 19);
            cbAtivo.TabIndex = 17;
            cbAtivo.Text = "Ativo";
            cbAtivo.UseVisualStyleBackColor = true;
            // 
            // dtpData_nasc
            // 
            dtpData_nasc.Format = DateTimePickerFormat.Short;
            dtpData_nasc.Location = new Point(100, 290);
            dtpData_nasc.MaxDate = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            dtpData_nasc.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpData_nasc.Name = "dtpData_nasc";
            dtpData_nasc.Size = new Size(114, 23);
            dtpData_nasc.TabIndex = 16;
            dtpData_nasc.Value = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(245, 143);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(99, 272);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 11;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 125);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Telefone";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(100, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(100, 125);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 13;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(100, 200);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 15;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(99, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 23);
            txtNome.TabIndex = 7;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(100, 143);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(121, 23);
            txtCpf.TabIndex = 10;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(txtTipo);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(txtComplemento);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtUf);
            tabPage2.Controls.Add(txtCidade);
            tabPage2.Controls.Add(txtBairro);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(txtCep);
            tabPage2.Controls.Add(txtLogradouro);
            tabPage2.Controls.Add(txtNumero);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(493, 449);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Endereços";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(240, 121);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(128, 23);
            txtComplemento.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(240, 103);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 23;
            label7.Text = "Complemento";
            // 
            // txtBairro
            // 
            txtBairro.BackColor = SystemColors.ControlLightLight;
            txtBairro.ForeColor = SystemColors.InfoText;
            txtBairro.Location = new Point(95, 181);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(273, 23);
            txtBairro.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(95, 103);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 24;
            label8.Text = "Número";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(95, 163);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 25;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(95, 43);
            label10.Name = "label10";
            label10.Size = new Size(69, 15);
            label10.TabIndex = 26;
            label10.Text = "Logradouro";
            // 
            // txtLogradouro
            // 
            txtLogradouro.Location = new Point(95, 61);
            txtLogradouro.Name = "txtLogradouro";
            txtLogradouro.Size = new Size(273, 23);
            txtLogradouro.TabIndex = 18;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(95, 121);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(121, 23);
            txtNumero.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(95, 223);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 25;
            label1.Text = "Cidade";
            // 
            // txtCidade
            // 
            txtCidade.BackColor = SystemColors.ControlLightLight;
            txtCidade.ForeColor = SystemColors.InfoText;
            txtCidade.Location = new Point(95, 241);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(179, 23);
            txtCidade.TabIndex = 20;
            // 
            // txtUf
            // 
            txtUf.BackColor = SystemColors.ControlLightLight;
            txtUf.ForeColor = SystemColors.InfoText;
            txtUf.Location = new Point(300, 241);
            txtUf.Name = "txtUf";
            txtUf.Size = new Size(68, 23);
            txtUf.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(303, 223);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 25;
            label11.Text = "UF";
            // 
            // txtCep
            // 
            txtCep.Location = new Point(95, 303);
            txtCep.Name = "txtCep";
            txtCep.Size = new Size(121, 23);
            txtCep.TabIndex = 21;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(95, 285);
            label12.Name = "label12";
            label12.Size = new Size(28, 15);
            label12.TabIndex = 24;
            label12.Text = "CEP";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(240, 285);
            label13.Name = "label13";
            label13.RightToLeft = RightToLeft.Yes;
            label13.Size = new Size(30, 15);
            label13.TabIndex = 23;
            label13.Text = "Tipo";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(240, 303);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(128, 23);
            txtTipo.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 11F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(89, 357);
            button1.Name = "button1";
            button1.Size = new Size(67, 30);
            button1.TabIndex = 1;
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
            btnInserir.Location = new Point(319, 357);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(67, 30);
            btnInserir.TabIndex = 2;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InfoText;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Century Gothic", 11F);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(84, 368);
            button2.Name = "button2";
            button2.Size = new Size(67, 30);
            button2.TabIndex = 27;
            button2.Text = "&Editar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.InfoText;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Font = new Font("Century Gothic", 11F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(317, 368);
            button3.Name = "button3";
            button3.Size = new Size(67, 30);
            button3.TabIndex = 28;
            button3.Text = "&Inserir";
            button3.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(297, 38);
            label14.Name = "label14";
            label14.Size = new Size(111, 33);
            label14.TabIndex = 7;
            label14.Text = "Cliente";
            // 
            // FrmClienteNovo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 665);
            Controls.Add(label14);
            Controls.Add(tabControl1);
            Name = "FrmClienteNovo";
            Text = "FrmClienteNovo";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DateTimePicker dtpData_nasc;
        private TextBox txtTelefone;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCpf;
        private CheckBox cbAtivo;
        private TextBox txtComplemento;
        private Label label7;
        private TextBox txtUf;
        private TextBox txtCidade;
        private TextBox txtBairro;
        private Label label11;
        private Label label1;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtLogradouro;
        private TextBox txtNumero;
        private TextBox txtTipo;
        private Label label13;
        private Label label12;
        private TextBox txtCep;
        private Button button1;
        private Button btnInserir;
        private Button button2;
        private Button button3;
        private Label label14;
    }
}