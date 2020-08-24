namespace App.Forms.Forms.Base.Add
{
    partial class FormBaseCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btSalvar = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSalvar.Location = new System.Drawing.Point(272, 224);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(103, 43);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseSelectable = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // FormBaseCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(398, 279);
            this.Controls.Add(this.btSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBaseCadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBaseCadastro_FormClosing_1);
            this.Load += new System.EventHandler(this.FormBaseCadastro_Load_1);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormBaseCadastro_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroButton btSalvar;
    }
}
