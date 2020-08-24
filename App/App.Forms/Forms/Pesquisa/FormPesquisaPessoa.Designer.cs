namespace App.Forms.Forms.Pesquisa
{
    partial class FormPesquisaPessoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.PessoaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CpfCnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBusca = new MetroFramework.Controls.MetroTextBox();
            this.txtCpfCnpj = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(568, 130);
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(568, 179);
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(568, 248);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(569, 348);
            this.metroButton4.Size = new System.Drawing.Size(51, 43);
            // 
            // metroButton5
            // 
            this.metroButton5.Location = new System.Drawing.Point(569, 74);
            this.metroButton5.Size = new System.Drawing.Size(50, 38);
            this.metroButton5.Text = "";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PessoaId,
            this.Nome,
            this.CpfCnpj});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(23, 118);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.ReadOnly = true;
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(527, 251);
            this.metroGrid1.TabIndex = 7;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PessoaId
            // 
            this.PessoaId.DataPropertyName = "id";
            this.PessoaId.HeaderText = "ID";
            this.PessoaId.Name = "PessoaId";
            this.PessoaId.ReadOnly = true;
            this.PessoaId.Width = 60;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 270;
            // 
            // CpfCnpj
            // 
            this.CpfCnpj.DataPropertyName = "cpfCnpj";
            this.CpfCnpj.HeaderText = "CPF/CNPJ";
            this.CpfCnpj.Name = "CpfCnpj";
            this.CpfCnpj.ReadOnly = true;
            this.CpfCnpj.Width = 150;
            // 
            // txtBusca
            // 
            this.txtBusca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtBusca.CustomButton.Image = null;
            this.txtBusca.CustomButton.Location = new System.Drawing.Point(350, 1);
            this.txtBusca.CustomButton.Name = "";
            this.txtBusca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBusca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusca.CustomButton.TabIndex = 1;
            this.txtBusca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusca.CustomButton.UseSelectable = true;
            this.txtBusca.CustomButton.Visible = false;
            this.txtBusca.Lines = new string[0];
            this.txtBusca.Location = new System.Drawing.Point(23, 89);
            this.txtBusca.MaxLength = 32767;
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.PasswordChar = '\0';
            this.txtBusca.PromptText = "DIGITE PARA PESQUISAR";
            this.txtBusca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusca.SelectedText = "";
            this.txtBusca.SelectionLength = 0;
            this.txtBusca.SelectionStart = 0;
            this.txtBusca.ShortcutsEnabled = true;
            this.txtBusca.Size = new System.Drawing.Size(372, 23);
            this.txtBusca.TabIndex = 8;
            this.txtBusca.UseSelectable = true;
            this.txtBusca.WaterMark = "DIGITE PARA PESQUISAR";
            this.txtBusca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtCpfCnpj
            // 
            // 
            // 
            // 
            this.txtCpfCnpj.CustomButton.Image = null;
            this.txtCpfCnpj.CustomButton.Location = new System.Drawing.Point(127, 1);
            this.txtCpfCnpj.CustomButton.Name = "";
            this.txtCpfCnpj.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCpfCnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfCnpj.CustomButton.TabIndex = 1;
            this.txtCpfCnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfCnpj.CustomButton.UseSelectable = true;
            this.txtCpfCnpj.CustomButton.Visible = false;
            this.txtCpfCnpj.Lines = new string[0];
            this.txtCpfCnpj.Location = new System.Drawing.Point(401, 89);
            this.txtCpfCnpj.MaxLength = 32767;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.PasswordChar = '\0';
            this.txtCpfCnpj.PromptText = "DIGITE PARA PESQUISAR";
            this.txtCpfCnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfCnpj.SelectedText = "";
            this.txtCpfCnpj.SelectionLength = 0;
            this.txtCpfCnpj.SelectionStart = 0;
            this.txtCpfCnpj.ShortcutsEnabled = true;
            this.txtCpfCnpj.Size = new System.Drawing.Size(149, 23);
            this.txtCpfCnpj.TabIndex = 11;
            this.txtCpfCnpj.UseSelectable = true;
            this.txtCpfCnpj.WaterMark = "DIGITE PARA PESQUISAR";
            this.txtCpfCnpj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfCnpj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(401, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 12;
            this.metroLabel1.Text = "CPF/CNPJ";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 67);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(49, 19);
            this.metroLabel2.TabIndex = 13;
            this.metroLabel2.Text = "NOME";
            // 
            // FormPesquisaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(633, 403);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.txtBusca);
            this.Controls.Add(this.metroGrid1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "FormPesquisaPessoa";
            this.Text = "MENU PESSOA";
            this.Load += new System.EventHandler(this.FormPesquisaPessoa_Load);
            this.Controls.SetChildIndex(this.metroButton1, 0);
            this.Controls.SetChildIndex(this.metroButton2, 0);
            this.Controls.SetChildIndex(this.metroButton3, 0);
            this.Controls.SetChildIndex(this.metroButton4, 0);
            this.Controls.SetChildIndex(this.metroButton5, 0);
            this.Controls.SetChildIndex(this.LblTotal, 0);
            this.Controls.SetChildIndex(this.metroGrid1, 0);
            this.Controls.SetChildIndex(this.txtBusca, 0);
            this.Controls.SetChildIndex(this.txtCpfCnpj, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroTextBox txtBusca;
        private MetroFramework.Controls.MetroTextBox txtCpfCnpj;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PessoaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CpfCnpj;
    }
}
