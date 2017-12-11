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
            this.Table_Flaws = new System.Windows.Forms.DataGridView();
            this.Col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Severity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cause = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_graph = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Text_Flaws = new System.Windows.Forms.Label();
            this.label_result2 = new System.Windows.Forms.Label();
            this.circularProgressBar1 = new CircularProgressBar.CircularProgressBar();
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
            this.lifetime.Location = new System.Drawing.Point(552, 325);
            this.lifetime.Name = "lifetime";
            this.lifetime.Size = new System.Drawing.Size(104, 40);
            this.lifetime.TabIndex = 2;
            this.lifetime.Text = "lifetime";
            this.lifetime.UseVisualStyleBackColor = false;
            this.lifetime.Click += new System.EventHandler(this.lifetime_Click);
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
            this.Table_Flaws.Location = new System.Drawing.Point(40, 189);
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
            this.Text_Flaws.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text_Flaws.Location = new System.Drawing.Point(36, 143);
            this.Text_Flaws.Name = "Text_Flaws";
            this.Text_Flaws.Size = new System.Drawing.Size(192, 24);
            this.Text_Flaws.TabIndex = 9;
            this.Text_Flaws.Text = "Last flaws occured:";
            // 
            // label_result2
            // 
            this.label_result2.AutoSize = true;
            this.label_result2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_result2.Location = new System.Drawing.Point(571, 383);
            this.label_result2.Name = "label_result2";
            this.label_result2.Size = new System.Drawing.Size(68, 22);
            this.label_result2.TabIndex = 5;
            this.label_result2.Text = "Result";
            this.label_result2.Click += new System.EventHandler(this.label_result2_Click);
            // 
            // circularProgressBar1
            // 
            this.circularProgressBar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.circularProgressBar1.AnimationSpeed = 500;
            this.circularProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.circularProgressBar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circularProgressBar1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgressBar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.circularProgressBar1.InnerMargin = 2;
            this.circularProgressBar1.InnerWidth = -1;
            this.circularProgressBar1.Location = new System.Drawing.Point(516, 126);
            this.circularProgressBar1.MarqueeAnimationSpeed = 2000;
            this.circularProgressBar1.Name = "circularProgressBar1";
            this.circularProgressBar1.OuterColor = System.Drawing.Color.Red;
            this.circularProgressBar1.OuterMargin = -25;
            this.circularProgressBar1.OuterWidth = 26;
            this.circularProgressBar1.ProgressColor = System.Drawing.Color.Green;
            this.circularProgressBar1.ProgressWidth = 25;
            this.circularProgressBar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.circularProgressBar1.Size = new System.Drawing.Size(182, 176);
            this.circularProgressBar1.StartAngle = 270;
            this.circularProgressBar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.circularProgressBar1.SubscriptText = "";
            this.circularProgressBar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circularProgressBar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.circularProgressBar1.SuperscriptText = "";
            this.circularProgressBar1.TabIndex = 10;
            this.circularProgressBar1.Text = "Life%";
            this.circularProgressBar1.TextMargin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.circularProgressBar1.Value = 68;
            this.circularProgressBar1.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // interface_circuit_breakers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.circularProgressBar1);
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
        private System.Windows.Forms.DataGridView Table_Flaws;
        private System.Windows.Forms.Label Text_Flaws;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Severity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cause;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_graph;
        private System.Windows.Forms.Label label_result2;
        private CircularProgressBar.CircularProgressBar circularProgressBar1;
    }
}
