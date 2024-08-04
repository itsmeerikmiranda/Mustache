namespace Mustache.MustacheFrm
{
    partial class FrmNivel
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
            label2 = new Label();
            btnInserir = new Button();
            btnEdit = new Button();
            txtNome = new TextBox();
            txtSigla = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 106);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 167);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(42, 20);
            label2.TabIndex = 0;
            label2.Text = "Sigla";
            label2.Click += label1_Click;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(210, 296);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(94, 55);
            btnInserir.TabIndex = 1;
            btnInserir.Text = "Inserir";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(528, 296);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 55);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "Editar";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(353, 106);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(159, 27);
            txtNome.TabIndex = 2;
            // 
            // txtSigla
            // 
            txtSigla.Location = new Point(353, 164);
            txtSigla.Name = "txtSigla";
            txtSigla.Size = new Size(159, 27);
            txtSigla.TabIndex = 2;
            // 
            // FrmNivel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSigla);
            Controls.Add(txtNome);
            Controls.Add(btnEdit);
            Controls.Add(btnInserir);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNivel";
            Text = "FormNivel";
            Load += FormNivel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnInserir;
        private Button btnEdit;
        private TextBox txtNome;
        private TextBox txtSigla;
    }
}