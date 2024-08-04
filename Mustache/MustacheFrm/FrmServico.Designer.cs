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
            dtpDuracao = new DateTimePicker();
            txtValorUnit = new TextBox();
            label6 = new Label();
            label5 = new Label();
            txtDesconto = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtNome = new TextBox();
            txtCategoria = new TextBox();
            groupbox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(363, 61);
            label1.Name = "label1";
            label1.Size = new Size(136, 40);
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
            button1.Location = new Point(185, 607);
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
            btnInserir.Location = new Point(595, 607);
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
            groupbox1.Location = new Point(243, 129);
            groupbox1.Margin = new Padding(3, 4, 3, 4);
            groupbox1.Name = "groupbox1";
            groupbox1.Padding = new Padding(3, 4, 3, 4);
            groupbox1.Size = new Size(386, 439);
            groupbox1.TabIndex = 9;
            groupbox1.TabStop = false;
            groupbox1.Text = "Cadastro";
            groupbox1.Enter += groupbox1_Enter;
            // 
            // dtpDuracao
            // 
            dtpDuracao.Format = DateTimePickerFormat.Time;
            dtpDuracao.Location = new Point(207, 201);
            dtpDuracao.Margin = new Padding(3, 4, 3, 4);
            dtpDuracao.Name = "dtpDuracao";
            dtpDuracao.ShowUpDown = true;
            dtpDuracao.Size = new Size(141, 27);
            dtpDuracao.TabIndex = 6;
            // 
            // txtValorUnit
            // 
            txtValorUnit.Location = new Point(37, 317);
            txtValorUnit.Margin = new Padding(3, 4, 3, 4);
            txtValorUnit.Name = "txtValorUnit";
            txtValorUnit.Size = new Size(137, 27);
            txtValorUnit.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(207, 177);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 5;
            label6.Text = "Duração Estimada";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 293);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 5;
            label5.Text = "Valor Unitário";
            // 
            // txtDesconto
            // 
            txtDesconto.BackColor = SystemColors.ControlLightLight;
            txtDesconto.ForeColor = SystemColors.InfoText;
            txtDesconto.Location = new Point(211, 317);
            txtDesconto.Margin = new Padding(3, 4, 3, 4);
            txtDesconto.Name = "txtDesconto";
            txtDesconto.Size = new Size(137, 27);
            txtDesconto.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 177);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 5;
            label4.Text = "Categoria";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 293);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 5;
            label3.Text = "Desconto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 68);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(37, 92);
            txtNome.Margin = new Padding(3, 4, 3, 4);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(311, 27);
            txtNome.TabIndex = 1;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(37, 201);
            txtCategoria.Margin = new Padding(3, 4, 3, 4);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(137, 27);
            txtCategoria.TabIndex = 4;
            // 
            // FrmServico
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 749);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnInserir);
            Controls.Add(groupbox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmServico";
            Text = "FrmServico";
            Load += FrmServico_Load;
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