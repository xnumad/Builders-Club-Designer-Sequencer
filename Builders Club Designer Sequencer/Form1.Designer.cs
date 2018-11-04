namespace Builders_Club_Designer_Sequencer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.nmr_interval = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(0, 0);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(0, 23);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.Location = new System.Drawing.Point(75, 0);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(18, 19);
            this.lbl_counter.TabIndex = 2;
            this.lbl_counter.Text = "0";
            // 
            // nmr_interval
            // 
            this.nmr_interval.Location = new System.Drawing.Point(75, 25);
            this.nmr_interval.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nmr_interval.Name = "nmr_interval";
            this.nmr_interval.Size = new System.Drawing.Size(57, 20);
            this.nmr_interval.TabIndex = 3;
            this.nmr_interval.Value = new decimal(new int[] {
            566,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 566;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(133, 46);
            this.Controls.Add(this.nmr_interval);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Builders Club";
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.NumericUpDown nmr_interval;
        private System.Windows.Forms.Timer timer1;
    }
}

