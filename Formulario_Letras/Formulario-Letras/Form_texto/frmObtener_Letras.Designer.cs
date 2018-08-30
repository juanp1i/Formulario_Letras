namespace Form_texto
{
    partial class frmObtener_Letras
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCopiar = new System.Windows.Forms.Button();
            this.cmbInicial = new System.Windows.Forms.ComboBox();
            this.cmbCopiar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posición de inicio en el texto inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de caracteres a copiar";
            // 
            // btnCopiar
            // 
            this.btnCopiar.Location = new System.Drawing.Point(110, 132);
            this.btnCopiar.Name = "btnCopiar";
            this.btnCopiar.Size = new System.Drawing.Size(104, 33);
            this.btnCopiar.TabIndex = 2;
            this.btnCopiar.Text = "Copiar Caracteres";
            this.btnCopiar.UseVisualStyleBackColor = true;
            this.btnCopiar.Click += new System.EventHandler(this.btnCopiar_Click);
            // 
            // cmbInicial
            // 
            this.cmbInicial.FormattingEnabled = true;
            this.cmbInicial.Location = new System.Drawing.Point(227, 17);
            this.cmbInicial.Name = "cmbInicial";
            this.cmbInicial.Size = new System.Drawing.Size(73, 21);
            this.cmbInicial.TabIndex = 6;
            this.cmbInicial.SelectedIndexChanged += new System.EventHandler(this.cmbInicial_SelectedIndexChanged);
            // 
            // cmbCopiar
            // 
            this.cmbCopiar.FormattingEnabled = true;
            this.cmbCopiar.Location = new System.Drawing.Point(227, 72);
            this.cmbCopiar.Name = "cmbCopiar";
            this.cmbCopiar.Size = new System.Drawing.Size(73, 21);
            this.cmbCopiar.TabIndex = 7;
            // 
            // frmObtener_Letras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 191);
            this.Controls.Add(this.cmbCopiar);
            this.Controls.Add(this.cmbInicial);
            this.Controls.Add(this.btnCopiar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmObtener_Letras";
            this.Text = "Obtencion de Letras";
            this.Load += new System.EventHandler(this.frmObtener_Letras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCopiar;
        private System.Windows.Forms.ComboBox cmbInicial;
        private System.Windows.Forms.ComboBox cmbCopiar;
    }
}