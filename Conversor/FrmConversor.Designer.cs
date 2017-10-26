namespace Conversor
{
    partial class FrmConversor
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
            this.tbcConversor = new System.Windows.Forms.TabControl();
            this.tabConverter = new System.Windows.Forms.TabPage();
            this.lblResultado = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnConverter = new System.Windows.Forms.Button();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.gbNumerosConvertidos = new System.Windows.Forms.GroupBox();
            this.dgvNumerosConvertidos = new System.Windows.Forms.DataGridView();
            this.Arabico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Romano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtResultadoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPesquisar = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbcConversor.SuspendLayout();
            this.tabConverter.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            this.gbNumerosConvertidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosConvertidos)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcConversor
            // 
            this.tbcConversor.Controls.Add(this.tabConverter);
            this.tbcConversor.Controls.Add(this.tabConsulta);
            this.tbcConversor.Location = new System.Drawing.Point(5, 5);
            this.tbcConversor.Name = "tbcConversor";
            this.tbcConversor.SelectedIndex = 0;
            this.tbcConversor.Size = new System.Drawing.Size(394, 400);
            this.tbcConversor.TabIndex = 0;
            // 
            // tabConverter
            // 
            this.tabConverter.Controls.Add(this.lblResultado);
            this.tabConverter.Controls.Add(this.lblNumero);
            this.tabConverter.Controls.Add(this.txtResultado);
            this.tabConverter.Controls.Add(this.txtNumero);
            this.tabConverter.Controls.Add(this.btnConverter);
            this.tabConverter.Location = new System.Drawing.Point(4, 22);
            this.tabConverter.Name = "tabConverter";
            this.tabConverter.Padding = new System.Windows.Forms.Padding(3);
            this.tabConverter.Size = new System.Drawing.Size(386, 374);
            this.tabConverter.TabIndex = 0;
            this.tabConverter.Text = "Converter";
            this.tabConverter.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(263, 33);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(55, 33);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(44, 13);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(230, 62);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(100, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(27, 62);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // btnConverter
            // 
            this.btnConverter.Location = new System.Drawing.Point(142, 105);
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.Size = new System.Drawing.Size(75, 23);
            this.btnConverter.TabIndex = 2;
            this.btnConverter.Text = "Converter";
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.gbNumerosConvertidos);
            this.tabConsulta.Controls.Add(this.txtResultadoConsulta);
            this.tabConsulta.Controls.Add(this.label1);
            this.tabConsulta.Controls.Add(this.txtNumeroPesquisar);
            this.tabConsulta.Controls.Add(this.btnPesquisar);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(386, 374);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            this.tabConsulta.Enter += new System.EventHandler(this.tabConsulta_Enter);
            // 
            // gbNumerosConvertidos
            // 
            this.gbNumerosConvertidos.Controls.Add(this.dgvNumerosConvertidos);
            this.gbNumerosConvertidos.Location = new System.Drawing.Point(9, 49);
            this.gbNumerosConvertidos.Name = "gbNumerosConvertidos";
            this.gbNumerosConvertidos.Size = new System.Drawing.Size(367, 308);
            this.gbNumerosConvertidos.TabIndex = 5;
            this.gbNumerosConvertidos.TabStop = false;
            this.gbNumerosConvertidos.Text = "Números Convertidos";
            // 
            // dgvNumerosConvertidos
            // 
            this.dgvNumerosConvertidos.AllowUserToAddRows = false;
            this.dgvNumerosConvertidos.AllowUserToDeleteRows = false;
            this.dgvNumerosConvertidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNumerosConvertidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNumerosConvertidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Arabico,
            this.Romano});
            this.dgvNumerosConvertidos.Location = new System.Drawing.Point(6, 19);
            this.dgvNumerosConvertidos.Name = "dgvNumerosConvertidos";
            this.dgvNumerosConvertidos.ReadOnly = true;
            this.dgvNumerosConvertidos.Size = new System.Drawing.Size(355, 272);
            this.dgvNumerosConvertidos.TabIndex = 4;
            // 
            // Arabico
            // 
            this.Arabico.HeaderText = "Arábico";
            this.Arabico.Name = "Arabico";
            this.Arabico.ReadOnly = true;
            // 
            // Romano
            // 
            this.Romano.HeaderText = "Romano";
            this.Romano.Name = "Romano";
            this.Romano.ReadOnly = true;
            // 
            // txtResultadoConsulta
            // 
            this.txtResultadoConsulta.Location = new System.Drawing.Point(198, 23);
            this.txtResultadoConsulta.Name = "txtResultadoConsulta";
            this.txtResultadoConsulta.Size = new System.Drawing.Size(178, 20);
            this.txtResultadoConsulta.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero";
            // 
            // txtNumeroPesquisar
            // 
            this.txtNumeroPesquisar.Location = new System.Drawing.Point(52, 22);
            this.txtNumeroPesquisar.Name = "txtNumeroPesquisar";
            this.txtNumeroPesquisar.Size = new System.Drawing.Size(62, 20);
            this.txtNumeroPesquisar.TabIndex = 1;
            this.txtNumeroPesquisar.Leave += new System.EventHandler(this.txtNumeroPesquisar_Leave);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(119, 20);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FrmConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 411);
            this.Controls.Add(this.tbcConversor);
            this.KeyPreview = true;
            this.Name = "FrmConversor";
            this.Text = "Conversor Decimal-Romano";
            this.tbcConversor.ResumeLayout(false);
            this.tabConverter.ResumeLayout(false);
            this.tabConverter.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            this.gbNumerosConvertidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNumerosConvertidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcConversor;
        private System.Windows.Forms.TabPage tabConverter;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnConverter;
        private System.Windows.Forms.TabPage tabConsulta;
        private System.Windows.Forms.GroupBox gbNumerosConvertidos;
        private System.Windows.Forms.DataGridView dgvNumerosConvertidos;
        private System.Windows.Forms.TextBox txtResultadoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arabico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Romano;
    }
}

