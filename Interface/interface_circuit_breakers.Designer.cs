namespace Interface
{
    partial class interface_circuit_breakers
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lifetime = new System.Windows.Forms.Button();
            this.label_result2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Circuit breakers";
            // 
            // lifetime
            // 
            this.lifetime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lifetime.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lifetime.Location = new System.Drawing.Point(358, 216);
            this.lifetime.Name = "lifetime";
            this.lifetime.Size = new System.Drawing.Size(104, 40);
            this.lifetime.TabIndex = 2;
            this.lifetime.Text = "lifetime";
            this.lifetime.UseVisualStyleBackColor = false;
            this.lifetime.Click += new System.EventHandler(this.lifetime_Click);
            // 
            // label_result2
            // 
            this.label_result2.AutoSize = true;
            this.label_result2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result2.Location = new System.Drawing.Point(378, 320);
            this.label_result2.Name = "label_result2";
            this.label_result2.Size = new System.Drawing.Size(68, 22);
            this.label_result2.TabIndex = 5;
            this.label_result2.Text = "Result";
            // 
            // interface_circuit_breakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_result2);
            this.Controls.Add(this.lifetime);
            this.Controls.Add(this.label1);
            this.Name = "interface_circuit_breakers";
            this.Size = new System.Drawing.Size(774, 482);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lifetime;
        private System.Windows.Forms.Label label_result2;
    }
}
