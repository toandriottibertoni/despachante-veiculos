namespace App.Forms.Forms.Cadastro
{
    partial class FormCadastroCidade
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
            this.TxtNome = new MetroFramework.Controls.MetroTextBox();
            this.CmbUf = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btSalvar
            // 
            this.btSalvar.Location = new System.Drawing.Point(260, 154);
            this.btSalvar.TabIndex = 2;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // TxtNome
            // 
            this.TxtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.TxtNome.CustomButton.Image = null;
            this.TxtNome.CustomButton.Location = new System.Drawing.Point(320, 1);
            this.TxtNome.CustomButton.Name = "";
            this.TxtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtNome.CustomButton.TabIndex = 1;
            this.TxtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtNome.CustomButton.UseSelectable = true;
            this.TxtNome.CustomButton.Visible = false;
            this.TxtNome.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNome.Lines = new string[0];
            this.TxtNome.Location = new System.Drawing.Point(23, 85);
            this.TxtNome.MaxLength = 32767;
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.PasswordChar = '\0';
            this.TxtNome.PromptText = "Digite o Nome da cidade";
            this.TxtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtNome.SelectedText = "";
            this.TxtNome.SelectionLength = 0;
            this.TxtNome.SelectionStart = 0;
            this.TxtNome.ShortcutsEnabled = true;
            this.TxtNome.Size = new System.Drawing.Size(342, 23);
            this.TxtNome.TabIndex = 0;
            this.TxtNome.UseSelectable = true;
            this.TxtNome.WaterMark = "Digite o Nome da cidade";
            this.TxtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // CmbUf
            // 
            this.CmbUf.DropDownHeight = 120;
            this.CmbUf.FormattingEnabled = true;
            this.CmbUf.IntegralHeight = false;
            this.CmbUf.ItemHeight = 23;
            this.CmbUf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.CmbUf.Location = new System.Drawing.Point(23, 137);
            this.CmbUf.Name = "CmbUf";
            this.CmbUf.Size = new System.Drawing.Size(116, 29);
            this.CmbUf.TabIndex = 1;
            this.CmbUf.UseSelectable = true;
            this.CmbUf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbUf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "UF:";
            // 
            // FormCadastroCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(386, 220);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmbUf);
            this.Controls.Add(this.TxtNome);
            this.Name = "FormCadastroCidade";
            this.Load += new System.EventHandler(this.FormCadastroCidade_Load);
            this.Controls.SetChildIndex(this.btSalvar, 0);
            this.Controls.SetChildIndex(this.TxtNome, 0);
            this.Controls.SetChildIndex(this.CmbUf, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtNome;
        private MetroFramework.Controls.MetroComboBox CmbUf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
