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
            this.btn_pause = new System.Windows.Forms.Button();
            this.lbl_counter = new System.Windows.Forms.Label();
            this.nmr_interval = new System.Windows.Forms.NumericUpDown();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_currently_placed_items = new System.Windows.Forms.Label();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.lbl_capacity = new System.Windows.Forms.Label();
            this.nmr_capacity = new System.Windows.Forms.NumericUpDown();
            this.lbl_start_hint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Enabled = false;
            this.btn_start.Location = new System.Drawing.Point(12, 76);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(159, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_pause
            // 
            this.btn_pause.Enabled = false;
            this.btn_pause.Location = new System.Drawing.Point(177, 76);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(92, 23);
            this.btn_pause.TabIndex = 1;
            this.btn_pause.Text = "⏸Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            this.btn_pause.Click += new System.EventHandler(this.btn_pause_Click);
            // 
            // lbl_counter
            // 
            this.lbl_counter.AutoSize = true;
            this.lbl_counter.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_counter.Location = new System.Drawing.Point(128, 107);
            this.lbl_counter.Name = "lbl_counter";
            this.lbl_counter.Size = new System.Drawing.Size(18, 19);
            this.lbl_counter.TabIndex = 2;
            this.lbl_counter.Text = "0";
            // 
            // nmr_interval
            // 
            this.nmr_interval.Location = new System.Drawing.Point(212, 38);
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
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lbl_currently_placed_items
            // 
            this.lbl_currently_placed_items.AutoSize = true;
            this.lbl_currently_placed_items.Location = new System.Drawing.Point(12, 111);
            this.lbl_currently_placed_items.Name = "lbl_currently_placed_items";
            this.lbl_currently_placed_items.Size = new System.Drawing.Size(110, 13);
            this.lbl_currently_placed_items.TabIndex = 2;
            this.lbl_currently_placed_items.Text = "Currently placed items";
            // 
            // lbl_interval
            // 
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.Location = new System.Drawing.Point(12, 42);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(159, 13);
            this.lbl_interval.TabIndex = 2;
            this.lbl_interval.Text = "Furniture placement interval [ms]";
            // 
            // lbl_capacity
            // 
            this.lbl_capacity.AutoSize = true;
            this.lbl_capacity.Location = new System.Drawing.Point(12, 14);
            this.lbl_capacity.Name = "lbl_capacity";
            this.lbl_capacity.Size = new System.Drawing.Size(167, 13);
            this.lbl_capacity.TabIndex = 2;
            this.lbl_capacity.Text = "Borrowed BC items capacity (max)";
            // 
            // nmr_capacity
            // 
            this.nmr_capacity.Location = new System.Drawing.Point(212, 12);
            this.nmr_capacity.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nmr_capacity.Name = "nmr_capacity";
            this.nmr_capacity.Size = new System.Drawing.Size(57, 20);
            this.nmr_capacity.TabIndex = 3;
            this.nmr_capacity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // lbl_start_hint
            // 
            this.lbl_start_hint.AutoSize = true;
            this.lbl_start_hint.ForeColor = System.Drawing.Color.Red;
            this.lbl_start_hint.Location = new System.Drawing.Point(12, 60);
            this.lbl_start_hint.Name = "lbl_start_hint";
            this.lbl_start_hint.Size = new System.Drawing.Size(254, 13);
            this.lbl_start_hint.TabIndex = 2;
            this.lbl_start_hint.Text = "Place a stackable BC furniture in your room to begin!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 142);
            this.Controls.Add(this.nmr_capacity);
            this.Controls.Add(this.nmr_interval);
            this.Controls.Add(this.lbl_capacity);
            this.Controls.Add(this.lbl_start_hint);
            this.Controls.Add(this.lbl_interval);
            this.Controls.Add(this.lbl_currently_placed_items);
            this.Controls.Add(this.lbl_counter);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Builders Club Designer Sequencer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmr_interval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_capacity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Label lbl_counter;
        private System.Windows.Forms.NumericUpDown nmr_interval;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl_currently_placed_items;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.Label lbl_capacity;
        private System.Windows.Forms.NumericUpDown nmr_capacity;
        private System.Windows.Forms.Label lbl_start_hint;
    }
}

