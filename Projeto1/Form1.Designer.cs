namespace Projeto1
{
    partial class frmJuros
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
            this.lblValor = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorCalculado = new System.Windows.Forms.TextBox();
            this.lblValorCaculado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(82, 43);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(119, 36);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(89, 20);
            this.txtValor.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(119, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(89, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click_1);
            // 
            // txtValorCalculado
            // 
            this.txtValorCalculado.Location = new System.Drawing.Point(119, 123);
            this.txtValorCalculado.Name = "txtValorCalculado";
            this.txtValorCalculado.ReadOnly = true;
            this.txtValorCalculado.Size = new System.Drawing.Size(89, 20);
            this.txtValorCalculado.TabIndex = 3;
            // 
            // lblValorCaculado
            // 
            this.lblValorCaculado.AutoSize = true;
            this.lblValorCaculado.Location = new System.Drawing.Point(32, 130);
            this.lblValorCaculado.Name = "lblValorCaculado";
            this.lblValorCaculado.Size = new System.Drawing.Size(81, 13);
            this.lblValorCaculado.TabIndex = 3;
            this.lblValorCaculado.Text = "Valor Calculado";
            // 
            // frmJuros
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 193);
            this.Controls.Add(this.txtValorCalculado);
            this.Controls.Add(this.lblValorCaculado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblValor);
            this.Name = "frmJuros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtValorCalculado;
        private System.Windows.Forms.Label lblValorCaculado;
    }
}

