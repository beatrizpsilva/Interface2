namespace Interface
{
    partial class Form1
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
            this.Btransformer = new System.Windows.Forms.Button();
            this.Bcircuitbreaker = new System.Windows.Forms.Button();
            this.Balarms = new System.Windows.Forms.Button();
            this.Bdisconnector = new System.Windows.Forms.Button();
            this.Bmenu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.interface_transformer1 = new Interface.interface_transformer();
            this.interface_circuit_breakers1 = new Interface.interface_circuit_breakers();
            this.interface_disconnector1 = new Interface.interface_disconnector();
            this.interface_alarms1 = new Interface.interface_alarms();
            this.menu1 = new Interface.Menu();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btransformer
            // 
            this.Btransformer.AutoSize = true;
            this.Btransformer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btransformer.BackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btransformer.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btransformer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btransformer.Location = new System.Drawing.Point(311, 3);
            this.Btransformer.Name = "Btransformer";
            this.Btransformer.Size = new System.Drawing.Size(148, 47);
            this.Btransformer.TabIndex = 4;
            this.Btransformer.Text = "Transformer";
            this.Btransformer.UseVisualStyleBackColor = false;
            this.Btransformer.Click += new System.EventHandler(this.Btransformer_Click);
            // 
            // Bcircuitbreaker
            // 
            this.Bcircuitbreaker.AutoSize = true;
            this.Bcircuitbreaker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bcircuitbreaker.BackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bcircuitbreaker.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcircuitbreaker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bcircuitbreaker.Location = new System.Drawing.Point(465, 3);
            this.Bcircuitbreaker.Name = "Bcircuitbreaker";
            this.Bcircuitbreaker.Size = new System.Drawing.Size(148, 47);
            this.Bcircuitbreaker.TabIndex = 5;
            this.Bcircuitbreaker.Text = "Circuit breaker";
            this.Bcircuitbreaker.UseVisualStyleBackColor = false;
            this.Bcircuitbreaker.Click += new System.EventHandler(this.Bcircuitbreaker_Click);
            // 
            // Balarms
            // 
            this.Balarms.AutoSize = true;
            this.Balarms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Balarms.BackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Balarms.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balarms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Balarms.Location = new System.Drawing.Point(157, 3);
            this.Balarms.Name = "Balarms";
            this.Balarms.Size = new System.Drawing.Size(148, 47);
            this.Balarms.TabIndex = 3;
            this.Balarms.Text = "Alarms";
            this.Balarms.UseVisualStyleBackColor = false;
            this.Balarms.Click += new System.EventHandler(this.Balarms_Click);
            // 
            // Bdisconnector
            // 
            this.Bdisconnector.AutoSize = true;
            this.Bdisconnector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bdisconnector.BackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bdisconnector.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdisconnector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bdisconnector.Location = new System.Drawing.Point(619, 3);
            this.Bdisconnector.Name = "Bdisconnector";
            this.Bdisconnector.Size = new System.Drawing.Size(152, 47);
            this.Bdisconnector.TabIndex = 6;
            this.Bdisconnector.Text = "Disconnector";
            this.Bdisconnector.UseVisualStyleBackColor = false;
            this.Bdisconnector.Click += new System.EventHandler(this.Bdisconnector_Click);
            // 
            // Bmenu
            // 
            this.Bmenu.AutoSize = true;
            this.Bmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Bmenu.BackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Bmenu.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.BorderSize = 0;
            this.Bmenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bmenu.Location = new System.Drawing.Point(3, 3);
            this.Bmenu.Name = "Bmenu";
            this.Bmenu.Size = new System.Drawing.Size(148, 47);
            this.Bmenu.TabIndex = 2;
            this.Bmenu.Text = "Menu";
            this.Bmenu.UseVisualStyleBackColor = false;
            this.Bmenu.Click += new System.EventHandler(this.Bmenu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Bmenu, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Bdisconnector, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Balarms, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Btransformer, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Bcircuitbreaker, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 53);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // interface_transformer1
            // 
            this.interface_transformer1.AutoSize = true;
            this.interface_transformer1.BackColor = System.Drawing.Color.White;
            this.interface_transformer1.Location = new System.Drawing.Point(1, 59);
            this.interface_transformer1.Name = "interface_transformer1";
            this.interface_transformer1.Size = new System.Drawing.Size(774, 491);
            this.interface_transformer1.TabIndex = 6;
            this.interface_transformer1.Load += new System.EventHandler(this.interface_transformer1_Load);
            // 
            // interface_circuit_breakers1
            // 
            this.interface_circuit_breakers1.BackColor = System.Drawing.Color.White;
            this.interface_circuit_breakers1.Location = new System.Drawing.Point(1, 59);
            this.interface_circuit_breakers1.Name = "interface_circuit_breakers1";
            this.interface_circuit_breakers1.Size = new System.Drawing.Size(774, 491);
            this.interface_circuit_breakers1.TabIndex = 5;
            // 
            // interface_disconnector1
            // 
            this.interface_disconnector1.BackColor = System.Drawing.Color.White;
            this.interface_disconnector1.Location = new System.Drawing.Point(1, 59);
            this.interface_disconnector1.Name = "interface_disconnector1";
            this.interface_disconnector1.Size = new System.Drawing.Size(774, 491);
            this.interface_disconnector1.TabIndex = 4;
            // 
            // interface_alarms1
            // 
            this.interface_alarms1.BackColor = System.Drawing.Color.White;
            this.interface_alarms1.Location = new System.Drawing.Point(1, 59);
            this.interface_alarms1.Name = "interface_alarms1";
            this.interface_alarms1.Size = new System.Drawing.Size(781, 491);
            this.interface_alarms1.TabIndex = 3;
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.Color.White;
            this.menu1.Location = new System.Drawing.Point(-6, 59);
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(781, 491);
            this.menu1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 550);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.interface_transformer1);
            this.Controls.Add(this.interface_circuit_breakers1);
            this.Controls.Add(this.interface_disconnector1);
            this.Controls.Add(this.interface_alarms1);
            this.Controls.Add(this.menu1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Menu menu1;
        private interface_alarms interface_alarms1;
        private interface_disconnector interface_disconnector1;
        private interface_circuit_breakers interface_circuit_breakers1;
        private interface_transformer interface_transformer1;
        private System.Windows.Forms.Button Btransformer;
        private System.Windows.Forms.Button Bcircuitbreaker;
        private System.Windows.Forms.Button Balarms;
        private System.Windows.Forms.Button Bdisconnector;
        private System.Windows.Forms.Button Bmenu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

