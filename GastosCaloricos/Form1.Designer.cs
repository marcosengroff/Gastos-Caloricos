namespace GastosCaloricos
{
    partial class frmCalorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalorias));
            this.lblAtividade = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblGasto = new System.Windows.Forms.Label();
            this.cmbAtiv = new System.Windows.Forms.ComboBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtGasto = new System.Windows.Forms.TextBox();
            this.nudDuracao = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAtividade
            // 
            this.lblAtividade.AutoSize = true;
            this.lblAtividade.Location = new System.Drawing.Point(12, 22);
            this.lblAtividade.Name = "lblAtividade";
            this.lblAtividade.Size = new System.Drawing.Size(145, 13);
            this.lblAtividade.TabIndex = 0;
            this.lblAtividade.Text = "Selecione a Atividade Física:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Location = new System.Drawing.Point(12, 50);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(67, 13);
            this.lblPeso.TabIndex = 1;
            this.lblPeso.Text = "Peso em Kg:";
            // 
            // lblDuracao
            // 
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.Location = new System.Drawing.Point(160, 50);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(99, 13);
            this.lblDuracao.TabIndex = 2;
            this.lblDuracao.Text = "Duração em Horas:";
            // 
            // lblGasto
            // 
            this.lblGasto.AutoSize = true;
            this.lblGasto.Location = new System.Drawing.Point(12, 82);
            this.lblGasto.Name = "lblGasto";
            this.lblGasto.Size = new System.Drawing.Size(133, 13);
            this.lblGasto.TabIndex = 3;
            this.lblGasto.Text = "Gasto Energético em Kcal:";
            // 
            // cmbAtiv
            // 
            this.cmbAtiv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAtiv.FormattingEnabled = true;
            this.cmbAtiv.Items.AddRange(new object[] {
            "",
            "Alongamento",
            "Bicicleta",
            "Boliche",
            "Caminhada",
            "Corrida",
            "Dança",
            "Natação",
            "Patins ",
            "Ping Pong",
            "Squash"});
            this.cmbAtiv.Location = new System.Drawing.Point(163, 19);
            this.cmbAtiv.Name = "cmbAtiv";
            this.cmbAtiv.Size = new System.Drawing.Size(152, 21);
            this.cmbAtiv.TabIndex = 4;
            this.cmbAtiv.SelectedIndexChanged += new System.EventHandler(this.cmbAtiv_SelectedIndexChanged);
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(85, 46);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(46, 20);
            this.txtPeso.TabIndex = 5;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPeso.TextChanged += new System.EventHandler(this.txtPeso_TextChanged);
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(26, 127);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(127, 127);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(225, 127);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtGasto
            // 
            this.txtGasto.Location = new System.Drawing.Point(151, 79);
            this.txtGasto.Name = "txtGasto";
            this.txtGasto.Size = new System.Drawing.Size(100, 20);
            this.txtGasto.TabIndex = 9;
            this.txtGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDuracao
            // 
            this.nudDuracao.Location = new System.Drawing.Point(265, 47);
            this.nudDuracao.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.nudDuracao.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuracao.Name = "nudDuracao";
            this.nudDuracao.Size = new System.Drawing.Size(50, 20);
            this.nudDuracao.TabIndex = 10;
            this.nudDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDuracao.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // frmCalorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 174);
            this.Controls.Add(this.nudDuracao);
            this.Controls.Add(this.txtGasto);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.cmbAtiv);
            this.Controls.Add(this.lblGasto);
            this.Controls.Add(this.lblDuracao);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAtividade);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(343, 213);
            this.Name = "frmCalorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos Calóricos";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAtividade;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblDuracao;
        private System.Windows.Forms.Label lblGasto;
        private System.Windows.Forms.ComboBox cmbAtiv;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtGasto;
        private System.Windows.Forms.NumericUpDown nudDuracao;
    }
}

