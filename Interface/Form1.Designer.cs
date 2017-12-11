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
            this.interface_transformer1 = new Interface.interface_transformer();
            this.interface_circuit_breakers1 = new Interface.interface_circuit_breakers();
            this.interface_disconnector1 = new Interface.interface_disconnector();
            this.interface_alarms1 = new Interface.interface_alarms();
            this.menu1 = new Interface.Menu();
            this.SuspendLayout();
            // 
            // Btransformer
            // 
            this.Btransformer.BackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Btransformer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btransformer.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Btransformer.Location = new System.Drawing.Point(311, 0);
            this.Btransformer.Name = "Btransformer";
            this.Btransformer.Size = new System.Drawing.Size(155, 53);
            this.Btransformer.TabIndex = 4;
            this.Btransformer.Text = "Transformer";
            this.Btransformer.UseVisualStyleBackColor = false;
            this.Btransformer.Click += new System.EventHandler(this.Btransformer_Click);
            // 
            // Bcircuitbreaker
            // 
            this.Bcircuitbreaker.BackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bcircuitbreaker.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcircuitbreaker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bcircuitbreaker.Location = new System.Drawing.Point(466, 0);
            this.Bcircuitbreaker.Name = "Bcircuitbreaker";
            this.Bcircuitbreaker.Size = new System.Drawing.Size(155, 53);
            this.Bcircuitbreaker.TabIndex = 5;
            this.Bcircuitbreaker.Text = "Circuit breaker";
            this.Bcircuitbreaker.UseVisualStyleBackColor = false;
            this.Bcircuitbreaker.Click += new System.EventHandler(this.Bcircuitbreaker_Click);
            // 
            // Balarms
            // 
            this.Balarms.BackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Balarms.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Balarms.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Balarms.Location = new System.Drawing.Point(156, 0);
            this.Balarms.Name = "Balarms";
            this.Balarms.Size = new System.Drawing.Size(155, 53);
            this.Balarms.TabIndex = 3;
            this.Balarms.Text = "Alarms";
            this.Balarms.UseVisualStyleBackColor = false;
            this.Balarms.Click += new System.EventHandler(this.Balarms_Click);
            // 
            // Bdisconnector
            // 
            this.Bdisconnector.BackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bdisconnector.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bdisconnector.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bdisconnector.Location = new System.Drawing.Point(621, 0);
            this.Bdisconnector.Name = "Bdisconnector";
            this.Bdisconnector.Size = new System.Drawing.Size(155, 53);
            this.Bdisconnector.TabIndex = 6;
            this.Bdisconnector.Text = "Disconnector";
            this.Bdisconnector.UseVisualStyleBackColor = false;
            this.Bdisconnector.Click += new System.EventHandler(this.Bdisconnector_Click);
            // 
            // Bmenu
            // 
            this.Bmenu.BackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.BorderColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.BorderSize = 0;
            this.Bmenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            this.Bmenu.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bmenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Bmenu.Location = new System.Drawing.Point(1, 0);
            this.Bmenu.Name = "Bmenu";
            this.Bmenu.Size = new System.Drawing.Size(155, 53);
            this.Bmenu.TabIndex = 2;
            this.Bmenu.Text = "Menu";
            this.Bmenu.UseVisualStyleBackColor = false;
            this.Bmenu.Click += new System.EventHandler(this.Bmenu_Click);
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
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 550);
            this.Controls.Add(this.Bdisconnector);
            this.Controls.Add(this.interface_transformer1);
            this.Controls.Add(this.Bcircuitbreaker);
            this.Controls.Add(this.interface_circuit_breakers1);
            this.Controls.Add(this.Btransformer);
            this.Controls.Add(this.interface_disconnector1);
            this.Controls.Add(this.Balarms);
            this.Controls.Add(this.interface_alarms1);
            this.Controls.Add(this.menu1);
            this.Controls.Add(this.Bmenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

