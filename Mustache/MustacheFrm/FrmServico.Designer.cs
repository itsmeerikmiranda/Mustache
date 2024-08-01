namespace Mustache.MustacheFrm
{
    partial class FrmServico
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
            txtValorUnit = new TextBox();
            label5 = new Label();
            txtDesconto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            dtpDuracao = new DateTimePicker();
            label6 = new Label();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 46);
            label1.Name = "label1";
            label1.Size = new Size(112, 33);
            label1.TabIndex = 10;
            label1.Text = "Serviço";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InfoText;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Century Gothic", 11F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(162, 455);
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
            btnInserir.Location = new Point(521, 455);
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
            groupbox1.Controls.Add(dtpDuracao);
            groupbox1.Controls.Add(txtValorUnit);
            groupbox1.Controls.Add(label6);
            groupbox1.Controls.Add(label5);
            groupbox1.Controls.Add(txtDesconto);
            groupbox1.Controls.Add(label4);
            groupbox1.Controls.Add(label3);
            groupbox1.Controls.Add(label2);
            groupbox1.Controls.Add(txtNome);
            groupbox1.Controls.Add(txtCategoria);
            groupbox1.Location = new Point(213, 97);
            groupbox1.Name = "groupbox1";
            groupbox1.Size = new Size(338, 329);
            groupbox1.TabIndex = 9;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            groupbox1.Enter += groupbox1_Enter;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(32, 238);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(120, 23);
            txtValorUnit.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 220);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 5;
            label5.Text = "Valor Unitário";
            // 
            // txtDesconto
            // 
            txtDesconto.BackColor = SystemColors.ControlLightLight;
            txtDesconto.ForeColor = SystemColors.InfoText;
            txtDesconto.Location = new Point(185, 238);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(120, 23);
            txtDesconto.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 133);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 5;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 220);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 51);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(32, 69);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(273, 23);
            txtNome.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(32, 151);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(120, 23);
            txtCategoria.TabIndex = 4;
            // 
            // dtpDuracao
            // 
            dtpDuracao.Format = DateTimePickerFormat.Time;
            dtpDuracao.Location = new Point(181, 151);
            dtpDuracao.Name = "dtpDuracao";
            dtpDuracao.ShowUpDown = true;
            dtpDuracao.Size = new Size(124, 23);
            dtpDuracao.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(181, 133);
            label6.Name = "label6";
            label6.Size = new Size(102, 15);
            label6.TabIndex = 5;
            label6.Text = "Duração Estimada";
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            Name = "FrmServico";
            Text = "FrmServico";
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
        private TextBox txtValorUnit;
        private Label label5;
        private TextBox txtDesconto;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtNome;
        private TextBox txtCategoria;
        private DateTimePicker dtpDuracao;
        private Label label6;
    }
}