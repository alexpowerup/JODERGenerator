namespace JODERGenerator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MinSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxSize = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.TextGenerated = new System.Windows.Forms.TextBox();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSize)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MinSize);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MaxSize);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 69);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MinSize
            // 
            this.MinSize.Location = new System.Drawing.Point(198, 13);
            this.MinSize.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.MinSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MinSize.Name = "MinSize";
            this.MinSize.Size = new System.Drawing.Size(58, 20);
            this.MinSize.TabIndex = 2;
            this.MinSize.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.MinSize.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Longitud mínima";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // MaxSize
            // 
            this.MaxSize.Location = new System.Drawing.Point(198, 41);
            this.MaxSize.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.MaxSize.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MaxSize.Name = "MaxSize";
            this.MaxSize.Size = new System.Drawing.Size(58, 20);
            this.MaxSize.TabIndex = 3;
            this.MaxSize.Value = new decimal(new int[] {
            140,
            0,
            0,
            0});
            this.MaxSize.ValueChanged += new System.EventHandler(this.MaxSize_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longitud máxima";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextGenerated
            // 
            this.TextGenerated.Location = new System.Drawing.Point(13, 88);
            this.TextGenerated.Multiline = true;
            this.TextGenerated.Name = "TextGenerated";
            this.TextGenerated.ReadOnly = true;
            this.TextGenerated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextGenerated.Size = new System.Drawing.Size(282, 100);
            this.TextGenerated.TabIndex = 5;
            this.TextGenerated.TabStop = false;
            this.TextGenerated.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CopyBTN
            // 
            this.CopyBTN.Location = new System.Drawing.Point(220, 194);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(75, 23);
            this.CopyBTN.TabIndex = 1;
            this.CopyBTN.Text = "Copiar";
            this.CopyBTN.UseVisualStyleBackColor = true;
            this.CopyBTN.Click += new System.EventHandler(this.CopyBTN_Click);
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.Location = new System.Drawing.Point(12, 223);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(283, 34);
            this.GenerateBTN.TabIndex = 0;
            this.GenerateBTN.Text = "GENERAR UN JODER";
            this.GenerateBTN.UseVisualStyleBackColor = true;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(307, 269);
            this.Controls.Add(this.GenerateBTN);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.TextGenerated);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "JODER Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown MaxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MinSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextGenerated;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.Button GenerateBTN;
    }
}

