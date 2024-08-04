namespace Mustache.MustacheFrm
{
    partial class FrmCategoria
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
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txtDescricao = new TextBox();
            txtName = new TextBox();
            txtSigla = new TextBox();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(311, 37);
            label1.Name = "label1";
            label1.Size = new Size(187, 40);
            label1.TabIndex = 10;
            label1.Text = "Categoria";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 11F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(152, 580);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(77, 40);
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
            btnInserir.Location = new Point(562, 580);
            btnInserir.Margin = new Padding(3, 4, 3, 4);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(77, 40);
            btnInserir.TabIndex = 8;
            btnInserir.Text = "&Inserir";
            btnInserir.UseVisualStyleBackColor = false;
            btnInserir.Click += btnInserir_Click;
            // 
            // groupbox1
            // 
            groupbox1.BackColor = SystemColors.ButtonFace;
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(txtDescricao);
            groupbox1.Controls.Add(txtName);
            groupbox1.Controls.Add(txtSigla);
            groupbox1.Location = new Point(240, 113);
            groupbox1.Margin = new Padding(3, 4, 3, 4);
            groupbox1.Name = "groupbox1";
            groupbox1.Padding = new Padding(3, 4, 3, 4);
            groupbox1.Size = new Size(335, 412);
            groupbox1.TabIndex = 9;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 53);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 5;
            label5.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 272);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 165);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(37, 189);
            txtDescricao.Margin = new Padding(3, 4, 3, 4);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(246, 27);
            txtDescricao.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(37, 77);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(83, 27);
            txtName.TabIndex = 4;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(41, 296);
            txtSigla.Margin = new Padding(3, 4, 3, 4);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(138, 27);
            txtSigla.TabIndex = 4;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(827, 685);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
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
        private DateTimePicker dtpData_nasc;
        private TextBox txtTelefone;
        private Label label6;
        private Label label5;
        private TextBox txtEmail;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtDescricao;
        private TextBox txtSigla;
        private TextBox txtName;
    }
}