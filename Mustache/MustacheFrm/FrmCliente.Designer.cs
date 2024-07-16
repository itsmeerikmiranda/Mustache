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
            btnInserir = new Button();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtCpf = new TextBox();
            txtTelefone = new TextBox();
            groupbox1 = new GroupBox();
            dtpData_nasc = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.BackColor = SystemColors.InfoText;
            btnInserir.BackgroundImageLayout = ImageLayout.None;
            btnInserir.FlatStyle = FlatStyle.Popup;
            btnInserir.Font = new Font("Century Gothic", 11F);
            btnInserir.ForeColor = SystemColors.ButtonHighlight;
            btnInserir.Location = new Point(441, 457);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(67, 30);
            btnInserir.TabIndex = 0;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(36, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 23);
            txtNome.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ControlLightLight;
            txtEmail.ForeColor = SystemColors.InfoText;
            txtEmail.Location = new Point(36, 189);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(273, 23);
            txtEmail.TabIndex = 3;
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(36, 129);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(121, 23);
            txtCpf.TabIndex = 4;
            txtCpf.TextChanged += textBox4_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(181, 129);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(128, 23);
            txtTelefone.TabIndex = 3;
            // 
            // groupbox1
            // 
            groupbox1.BackColor = SystemColors.ButtonFace;
            groupbox1.Controls.Add(dtpData_nasc);
            groupbox1.Controls.Add(txtTelefone);
            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(txtEmail);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(txtNome);
            groupbox1.Controls.Add(txtCpf);
            groupbox1.Location = new Point(133, 99);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(338, 336);
            groupbox1.TabIndex = 5;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            groupbox1.Enter += groupBox1_Enter;
            // 
            // dtpData_nasc
            // 
            dtpData_nasc.Format = DateTimePickerFormat.Short;
            dtpData_nasc.Location = new Point(185, 234);
            dtpData_nasc.MaxDate = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            dtpData_nasc.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            dtpData_nasc.Name = "dtpData_nasc";
            dtpData_nasc.Size = new Size(92, 23);
            dtpData_nasc.TabIndex = 6;
            dtpData_nasc.Value = new DateTime(2024, 7, 15, 0, 0, 0, 0);
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 240);
            label6.Name = "label6";
            label6.Size = new Size(114, 15);
            label6.TabIndex = 5;
            label6.Text = "Data de Nascimento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 111);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 5;
            label5.Text = "Telefone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 111);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 171);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(238, 48);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 6;
            label1.Text = "Cliente";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 11F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(82, 457);
            button1.Name = "button1";
            button1.Size = new Size(67, 30);
            button1.TabIndex = 0;
            button1.Text = "&Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnInserir_Click;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(625, 546);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            ForeColor = SystemColors.ControlText;
            Name = "FrmCliente";
            Padding = new Padding(0, 3, 3, 0);
            Text = "FrmCliente";
            groupbox1.ResumeLayout(false);
            groupbox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtCpf;
        private TextBox txtTelefone;
        private GroupBox groupbox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpData_nasc;
        private Button button1;
    }
}