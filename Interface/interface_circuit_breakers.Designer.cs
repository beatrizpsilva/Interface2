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
            this.Table_Flaws = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_graph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text_Flaws = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Table_Flaws)).BeginInit();
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
            this.lifetime.Location = new System.Drawing.Point(554, 223);
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
            this.label_result2.Location = new System.Drawing.Point(571, 316);
            this.label_result2.Name = "label_result2";
            this.label_result2.Size = new System.Drawing.Size(68, 22);
            this.label_result2.TabIndex = 5;
            this.label_result2.Text = "Result";
            // 
            // Table_Flaws
            // 
            this.Table_Flaws.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table_Flaws.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_ID,
            this.Col_Date,
            this.Col_Severity,
            this.Col_Cause,
            this.Col_graph});
            this.Table_Flaws.Location = new System.Drawing.Point(0, 205);
            this.Table_Flaws.Name = "Table_Flaws";
            this.Table_Flaws.Size = new System.Drawing.Size(398, 221);
            this.Table_Flaws.TabIndex = 7;
            this.Table_Flaws.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_Flaws_CellContentClick);
            // 
            // Col_ID
            // 
            this.Col_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Col_ID.HeaderText = "ID";
            this.Col_ID.Name = "Col_ID";
            this.Col_ID.Width = 43;
            // 
            // Col_Date
            // 
            this.Col_Date.HeaderText = "Date";
            this.Col_Date.Name = "Col_Date";
            this.Col_Date.Width = 80;
            // 
            // Col_Severity
            // 
            this.Col_Severity.HeaderText = "Severity";
            this.Col_Severity.Name = "Col_Severity";
            this.Col_Severity.Width = 80;
            // 
            // Col_Cause
            // 
            this.Col_Cause.HeaderText = "Cause";
            this.Col_Cause.Name = "Col_Cause";
            // 
            // Col_graph
            // 
            this.Col_graph.HeaderText = "Graphs";
            this.Col_graph.Name = "Col_graph";
            this.Col_graph.Width = 55;
            // 
            // Text_Flaws
            // 
            this.Text_Flaws.AutoSize = true;
            this.Text_Flaws.Location = new System.Drawing.Point(75, 152);
            this.Text_Flaws.Name = "Text_Flaws";
            this.Text_Flaws.Size = new System.Drawing.Size(99, 13);
            this.Text_Flaws.TabIndex = 9;
            this.Text_Flaws.Text = "Last flaws occured:";
            // 
            // interface_circuit_breakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Text_Flaws);
            this.Controls.Add(this.Table_Flaws);
            this.Controls.Add(this.label_result2);
            this.Controls.Add(this.lifetime);
            this.Controls.Add(this.label1);
            this.Name = "interface_circuit_breakers";
            this.Size = new System.Drawing.Size(774, 482);
            ((System.ComponentModel.ISupportInitialize)(this.Table_Flaws)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lifetime;
        private System.Windows.Forms.Label label_result2;
        private System.Windows.Forms.DataGridView Table_Flaws;
        private System.Windows.Forms.Label Text_Flaws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cause;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_graph;
    }
}
