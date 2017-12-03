namespace Interface
{
    partial class interface_alarms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(interface_alarms));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.led_green = new System.Windows.Forms.PictureBox();
            this.led_red = new System.Windows.Forms.PictureBox();
            this.stop_alarm = new System.Windows.Forms.Button();
            this.timer_alarms = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.led_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_red)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(325, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attention!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "The next component failed:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // led_green
            // 
            this.led_green.Image = ((System.Drawing.Image)(resources.GetObject("led_green.Image")));
            this.led_green.Location = new System.Drawing.Point(315, 176);
            this.led_green.Name = "led_green";
            this.led_green.Size = new System.Drawing.Size(153, 132);
            this.led_green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.led_green.TabIndex = 2;
            this.led_green.TabStop = false;
            this.led_green.Click += new System.EventHandler(this.led_green_Click);
            // 
            // led_red
            // 
            this.led_red.Image = ((System.Drawing.Image)(resources.GetObject("led_red.Image")));
            this.led_red.Location = new System.Drawing.Point(315, 176);
            this.led_red.Name = "led_red";
            this.led_red.Size = new System.Drawing.Size(154, 132);
            this.led_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.led_red.TabIndex = 3;
            this.led_red.TabStop = false;
            this.led_red.Click += new System.EventHandler(this.led_red_Click);
            // 
            // stop_alarm
            // 
            this.stop_alarm.AutoSize = true;
            this.stop_alarm.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.stop_alarm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_alarm.Location = new System.Drawing.Point(331, 374);
            this.stop_alarm.Name = "stop_alarm";
            this.stop_alarm.Size = new System.Drawing.Size(130, 36);
            this.stop_alarm.TabIndex = 4;
            this.stop_alarm.Text = "stop alarm";
            this.stop_alarm.UseVisualStyleBackColor = false;
            this.stop_alarm.Click += new System.EventHandler(this.stop_alarm_Click);
            // 
            // timer_alarms
            // 
            this.timer_alarms.Interval = 500;
            this.timer_alarms.Tick += new System.EventHandler(this.timer_alarms_Tick);
            // 
            // interface_alarms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.stop_alarm);
            this.Controls.Add(this.led_red);
            this.Controls.Add(this.led_green);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "interface_alarms";
            this.Size = new System.Drawing.Size(774, 482);
            ((System.ComponentModel.ISupportInitialize)(this.led_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.led_red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox led_green;
        private System.Windows.Forms.PictureBox led_red;
        private System.Windows.Forms.Button stop_alarm;
        private System.Windows.Forms.Timer timer_alarms;
    }
}
