namespace App.Forms.Forms.Report.Forms
{
    partial class FormPrintFicha
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.FichaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtPlaca = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblPropNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblCpfCnpj = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.lblRenavam = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.lblCor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.lblCategoria = new MetroFramework.Controls.MetroLabel();
            this.lblEspecie = new MetroFramework.Controls.MetroLabel();
            this.Imprimir = new MetroFramework.Controls.MetroButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.btPDF = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.FichaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // FichaBindingSource
            // 
            this.FichaBindingSource.DataSource = typeof(App.Forms.Entidades.Relatorios.Ficha);
            // 
            // txtPlaca
            // 
            this.txtPlaca.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txtPlaca.CustomButton.Image = null;
            this.txtPlaca.CustomButton.Location = new System.Drawing.Point(87, 1);
            this.txtPlaca.CustomButton.Name = "";
            this.txtPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPlaca.CustomButton.TabIndex = 1;
            this.txtPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPlaca.CustomButton.UseSelectable = true;
            this.txtPlaca.CustomButton.Visible = false;
            this.txtPlaca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPlaca.Lines = new string[0];
            this.txtPlaca.Location = new System.Drawing.Point(24, 55);
            this.txtPlaca.MaxLength = 32767;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.SelectionLength = 0;
            this.txtPlaca.SelectionStart = 0;
            this.txtPlaca.ShortcutsEnabled = true;
            this.txtPlaca.Size = new System.Drawing.Size(109, 23);
            this.txtPlaca.TabIndex = 0;
            this.txtPlaca.UseSelectable = true;
            this.txtPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPlaca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyDown);
            this.txtPlaca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPlaca_KeyUp);
            this.txtPlaca.Leave += new System.EventHandler(this.txtPlaca_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(51, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "PLACA";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(18, 201);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(83, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Proprietário:";
            // 
            // lblPropNome
            // 
            this.lblPropNome.AutoSize = true;
            this.lblPropNome.Location = new System.Drawing.Point(105, 201);
            this.lblPropNome.Name = "lblPropNome";
            this.lblPropNome.Size = new System.Drawing.Size(0, 0);
            this.lblPropNome.TabIndex = 5;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 220);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(72, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "CPF/CNPJ:";
            // 
            // lblCpfCnpj
            // 
            this.lblCpfCnpj.AutoSize = true;
            this.lblCpfCnpj.Location = new System.Drawing.Point(96, 220);
            this.lblCpfCnpj.Name = "lblCpfCnpj";
            this.lblCpfCnpj.Size = new System.Drawing.Size(0, 0);
            this.lblCpfCnpj.TabIndex = 7;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(18, 239);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(73, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "RENAVAM:";
            // 
            // lblRenavam
            // 
            this.lblRenavam.AutoSize = true;
            this.lblRenavam.Location = new System.Drawing.Point(105, 239);
            this.lblRenavam.Name = "lblRenavam";
            this.lblRenavam.Size = new System.Drawing.Size(0, 0);
            this.lblRenavam.TabIndex = 9;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(19, 258);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(84, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "DESCRIÇÃO:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(108, 258);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(0, 0);
            this.lblDescricao.TabIndex = 11;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(19, 277);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(40, 19);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "COR:";
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(75, 277);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(0, 0);
            this.lblCor.TabIndex = 13;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(18, 296);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(82, 19);
            this.metroLabel13.TabIndex = 14;
            this.metroLabel13.Text = "CATEGORIA:";
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(19, 315);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(60, 19);
            this.metroLabel14.TabIndex = 15;
            this.metroLabel14.Text = "ESPÉCIE:";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(104, 296);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(0, 0);
            this.lblCategoria.TabIndex = 16;
            // 
            // lblEspecie
            // 
            this.lblEspecie.AutoSize = true;
            this.lblEspecie.Location = new System.Drawing.Point(85, 315);
            this.lblEspecie.Name = "lblEspecie";
            this.lblEspecie.Size = new System.Drawing.Size(0, 0);
            this.lblEspecie.TabIndex = 17;
            // 
            // Imprimir
            // 
            this.Imprimir.Location = new System.Drawing.Point(253, 51);
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(161, 27);
            this.Imprimir.TabIndex = 2;
            this.Imprimir.Text = "IMPRIMIR";
            this.Imprimir.UseSelectable = true;
            this.Imprimir.Click += new System.EventHandler(this.Imprimir_Click);
            // 
            // reportViewer1
            // 
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.FichaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "App.Forms.Forms.Report.Modelos.ReportFicha.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(263, 188);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(151, 89);
            this.reportViewer1.TabIndex = 19;
            this.reportViewer1.Visible = false;
            this.reportViewer1.RenderingComplete += new Microsoft.Reporting.WinForms.RenderingCompleteEventHandler(this.reportViewer1_RenderingComplete);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(139, 55);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "BUSCAR";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton3
            // 
            this.metroButton3.Enabled = false;
            this.metroButton3.Location = new System.Drawing.Point(253, 84);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(161, 27);
            this.metroButton3.TabIndex = 78;
            this.metroButton3.Text = "SALVAR WORD .DOCX";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click_1);
            // 
            // btPDF
            // 
            this.btPDF.Enabled = false;
            this.btPDF.Location = new System.Drawing.Point(253, 118);
            this.btPDF.Name = "btPDF";
            this.btPDF.Size = new System.Drawing.Size(161, 27);
            this.btPDF.TabIndex = 79;
            this.btPDF.Text = "SALVAR PDF";
            this.btPDF.UseSelectable = true;
            this.btPDF.Click += new System.EventHandler(this.btPDF_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Enabled = false;
            this.metroButton2.Location = new System.Drawing.Point(253, 151);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(161, 27);
            this.metroButton2.TabIndex = 80;
            this.metroButton2.Text = "SALVAR EXCEL .XLSX";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FormPrintFicha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(509, 356);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.btPDF);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.Imprimir);
            this.Controls.Add(this.lblEspecie);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.metroLabel14);
            this.Controls.Add(this.metroLabel13);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.metroLabel11);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.metroLabel9);
            this.Controls.Add(this.lblRenavam);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.lblCpfCnpj);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.lblPropNome);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtPlaca);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrintFicha";
            this.Text = "";
            this.Load += new System.EventHandler(this.FormPrintFicha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FichaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtPlaca;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lblPropNome;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblCpfCnpj;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblRenavam;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel lblCor;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel lblCategoria;
        private MetroFramework.Controls.MetroLabel lblEspecie;
        private MetroFramework.Controls.MetroButton Imprimir;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FichaBindingSource;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton btPDF;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}
