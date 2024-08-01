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
            txtSigla = new TextBox();
            txtName = new TextBox();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(272, 28);
            label1.Name = "label1";
            label1.Size = new Size(151, 33);
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
            button1.Location = new Point(133, 435);
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
            btnInserir.Location = new Point(492, 435);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(67, 30);
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
            groupbox1.Location = new Point(210, 85);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(293, 309);
            groupbox1.TabIndex = 9;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 40);
            label5.Name = "label5";
            label5.Size = new Size(17, 15);
            label5.TabIndex = 5;
            label5.Text = "Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 204);
            label4.Name = "label4";
            label4.Size = new Size(32, 15);
            label4.TabIndex = 5;
            label4.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 124);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 5;
            label2.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(32, 142);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(216, 23);
            txtDescricao.TabIndex = 1;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(36, 222);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(121, 23);
            txtSigla.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(32, 58);
            txtName.Name = "txtName";
            txtName.Size = new Size(73, 23);
            txtName.TabIndex = 4;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(724, 514);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
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