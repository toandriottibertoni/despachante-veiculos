namespace App.Forms.Forms.Report.Forms
{
    partial class FormReportRelacao
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.txtPessoa = new MetroFramework.Controls.MetroTextBox();
            this.txtLicenciamento = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel23 = new MetroFramework.Controls.MetroLabel();
            this.txtEspecie = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.txtCategoria = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.btPesquisar = new MetroFramework.Controls.MetroButton();
            this.btLimpar = new MetroFramework.Controls.MetroButton();
            this.txtCpfCnpj = new MetroFramework.Controls.MetroTextBox();
            this.btLimparPessoa = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App.Forms.Forms.Report.Modelos.ReportRelacao.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 219);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.ShowCredentialPrompts = false;
            this.reportViewer1.ShowDocumentMapButton = false;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.ShowParameterPrompts = false;
            this.reportViewer1.ShowPromptAreaButton = false;
            this.reportViewer1.ShowStopButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(1014, 565);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.WaitControlDisplayAfter = 1;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.Resize += new System.EventHandler(this.reportViewer1_Resize);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(760, 42);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtPessoa
            // 
            this.txtPessoa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPessoa.CustomButton.Image = null;
            this.txtPessoa.CustomButton.Location = new System.Drawing.Point(432, 1);
            this.txtPessoa.CustomButton.Name = "";
            this.txtPessoa.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPessoa.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPessoa.CustomButton.TabIndex = 1;
            this.txtPessoa.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPessoa.CustomButton.UseSelectable = true;
            this.txtPessoa.CustomButton.Visible = false;
            this.txtPessoa.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPessoa.Lines = new string[0];
            this.txtPessoa.Location = new System.Drawing.Point(37, 84);
            this.txtPessoa.MaxLength = 32767;
            this.txtPessoa.Name = "txtPessoa";
            this.txtPessoa.PasswordChar = '\0';
            this.txtPessoa.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPessoa.SelectedText = "";
            this.txtPessoa.SelectionLength = 0;
            this.txtPessoa.SelectionStart = 0;
            this.txtPessoa.ShortcutsEnabled = true;
            this.txtPessoa.Size = new System.Drawing.Size(454, 23);
            this.txtPessoa.TabIndex = 2;
            this.txtPessoa.UseSelectable = true;
            this.txtPessoa.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPessoa.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtLicenciamento
            // 
            this.txtLicenciamento.FormattingEnabled = true;
            this.txtLicenciamento.ItemHeight = 23;
            this.txtLicenciamento.Location = new System.Drawing.Point(482, 166);
            this.txtLicenciamento.Name = "txtLicenciamento";
            this.txtLicenciamento.Size = new System.Drawing.Size(149, 29);
            this.txtLicenciamento.TabIndex = 52;
            this.txtLicenciamento.UseSelectable = true;
            // 
            // metroLabel23
            // 
            this.metroLabel23.AutoSize = true;
            this.metroLabel23.Location = new System.Drawing.Point(482, 144);
            this.metroLabel23.Name = "metroLabel23";
            this.metroLabel23.Size = new System.Drawing.Size(111, 19);
            this.metroLabel23.TabIndex = 51;
            this.metroLabel23.Text = "LICENCIAMENTO";
            // 
            // txtEspecie
            // 
            this.txtEspecie.FormattingEnabled = true;
            this.txtEspecie.ItemHeight = 23;
            this.txtEspecie.Location = new System.Drawing.Point(245, 166);
            this.txtEspecie.Name = "txtEspecie";
            this.txtEspecie.Size = new System.Drawing.Size(187, 29);
            this.txtEspecie.TabIndex = 50;
            this.txtEspecie.UseSelectable = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(245, 144);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(60, 19);
            this.metroLabel22.TabIndex = 49;
            this.metroLabel22.Text = "ESPÉCIE:";
            // 
            // txtCategoria
            // 
            this.txtCategoria.FormattingEnabled = true;
            this.txtCategoria.ItemHeight = 23;
            this.txtCategoria.Location = new System.Drawing.Point(37, 166);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(174, 29);
            this.txtCategoria.TabIndex = 48;
            this.txtCategoria.UseSelectable = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(37, 144);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(82, 19);
            this.metroLabel21.TabIndex = 47;
            this.metroLabel21.Text = "CATEGORIA:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Location = new System.Drawing.Point(513, 84);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(93, 29);
            this.btPesquisar.TabIndex = 53;
            this.btPesquisar.Text = "PESQUISAR";
            this.btPesquisar.UseSelectable = true;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // btLimpar
            // 
            this.btLimpar.Location = new System.Drawing.Point(655, 166);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(54, 29);
            this.btLimpar.TabIndex = 54;
            this.btLimpar.Text = "LIMPAR";
            this.btLimpar.UseSelectable = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // txtCpfCnpj
            // 
            // 
            // 
            // 
            this.txtCpfCnpj.CustomButton.Image = null;
            this.txtCpfCnpj.CustomButton.Location = new System.Drawing.Point(150, 1);
            this.txtCpfCnpj.CustomButton.Name = "";
            this.txtCpfCnpj.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCpfCnpj.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCpfCnpj.CustomButton.TabIndex = 1;
            this.txtCpfCnpj.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCpfCnpj.CustomButton.UseSelectable = true;
            this.txtCpfCnpj.CustomButton.Visible = false;
            this.txtCpfCnpj.Enabled = false;
            this.txtCpfCnpj.Lines = new string[0];
            this.txtCpfCnpj.Location = new System.Drawing.Point(582, 42);
            this.txtCpfCnpj.MaxLength = 32767;
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.PasswordChar = '\0';
            this.txtCpfCnpj.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCpfCnpj.SelectedText = "";
            this.txtCpfCnpj.SelectionLength = 0;
            this.txtCpfCnpj.SelectionStart = 0;
            this.txtCpfCnpj.ShortcutsEnabled = true;
            this.txtCpfCnpj.Size = new System.Drawing.Size(172, 23);
            this.txtCpfCnpj.TabIndex = 55;
            this.txtCpfCnpj.UseSelectable = true;
            this.txtCpfCnpj.Visible = false;
            this.txtCpfCnpj.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCpfCnpj.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btLimparPessoa
            // 
            this.btLimparPessoa.Location = new System.Drawing.Point(851, 42);
            this.btLimparPessoa.Name = "btLimparPessoa";
            this.btLimparPessoa.Size = new System.Drawing.Size(54, 23);
            this.btLimparPessoa.TabIndex = 56;
            this.btLimparPessoa.Text = "LIMPAR";
            this.btLimparPessoa.UseSelectable = true;
            this.btLimparPessoa.Visible = false;
            this.btLimparPessoa.Click += new System.EventHandler(this.btLimparPessoa_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(37, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 57;
            this.metroLabel1.Text = "NOME:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(582, 18);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 58;
            this.metroLabel2.Text = "CPF/CNPJ";
            this.metroLabel2.Visible = false;
            // 
            // FormReportRelacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1015, 784);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btLimparPessoa);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.btLimpar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.txtPessoa);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtLicenciamento);
            this.Controls.Add(this.metroLabel23);
            this.Controls.Add(this.txtEspecie);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.reportViewer1);
            this.MinimizeBox = false;
            this.Name = "FormReportRelacao";
            this.Text = "RELAÇÃO DE VEICULOS";
            this.Load += new System.EventHandler(this.FormReportRelacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox txtPessoa;
        private MetroFramework.Controls.MetroComboBox txtLicenciamento;
        private MetroFramework.Controls.MetroLabel metroLabel23;
        private MetroFramework.Controls.MetroComboBox txtEspecie;
        private MetroFramework.Controls.MetroLabel metroLabel22;
        private MetroFramework.Controls.MetroComboBox txtCategoria;
        private MetroFramework.Controls.MetroLabel metroLabel21;
        private MetroFramework.Controls.MetroButton btPesquisar;
        private MetroFramework.Controls.MetroButton btLimpar;
        private MetroFramework.Controls.MetroTextBox txtCpfCnpj;
        private MetroFramework.Controls.MetroButton btLimparPessoa;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
