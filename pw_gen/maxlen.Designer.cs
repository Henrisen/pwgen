namespace pw_gen
{
    partial class maxlen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.len = new System.Windows.Forms.NumericUpDown();
            this.quit = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.cpm = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.len)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpm)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password Length";
            // 
            // len
            // 
            this.len.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.len.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.len.Location = new System.Drawing.Point(277, 11);
            this.len.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.len.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.len.Name = "len";
            this.len.Size = new System.Drawing.Size(170, 34);
            this.len.TabIndex = 1;
            this.len.ThousandsSeparator = true;
            this.len.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // quit
            // 
            this.quit.Location = new System.Drawing.Point(12, 101);
            this.quit.Name = "quit";
            this.quit.Size = new System.Drawing.Size(190, 38);
            this.quit.TabIndex = 2;
            this.quit.Text = "Cancel";
            this.quit.UseVisualStyleBackColor = true;
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(257, 101);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(190, 38);
            this.ok.TabIndex = 3;
            this.ok.Text = "Confirm";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cpm
            // 
            this.cpm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpm.Location = new System.Drawing.Point(277, 60);
            this.cpm.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.cpm.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.cpm.Name = "cpm";
            this.cpm.Size = new System.Drawing.Size(170, 34);
            this.cpm.TabIndex = 5;
            this.cpm.ThousandsSeparator = true;
            this.cpm.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "CPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "(Affects Performance)";
            // 
            // maxlen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 151);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cpm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.quit);
            this.Controls.Add(this.len);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "maxlen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Password Generator";
            this.Load += new System.EventHandler(this.maxlen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.len)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown len;
        private System.Windows.Forms.Button quit;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.NumericUpDown cpm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}