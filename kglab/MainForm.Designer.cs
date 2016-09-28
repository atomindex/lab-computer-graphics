namespace kglab {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.pbLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lblCPoint = new System.Windows.Forms.Label();
            this.lblCZ = new System.Windows.Forms.Label();
            this.nudCZ = new System.Windows.Forms.NumericUpDown();
            this.lblCY = new System.Windows.Forms.Label();
            this.nudCY = new System.Windows.Forms.NumericUpDown();
            this.lblCX = new System.Windows.Forms.Label();
            this.nudCX = new System.Windows.Forms.NumericUpDown();
            this.lblTPoint = new System.Windows.Forms.Label();
            this.lblTZ = new System.Windows.Forms.Label();
            this.nudTZ = new System.Windows.Forms.NumericUpDown();
            this.lblTY = new System.Windows.Forms.Label();
            this.nudTY = new System.Windows.Forms.NumericUpDown();
            this.lblTX = new System.Windows.Forms.Label();
            this.nudTX = new System.Windows.Forms.NumericUpDown();
            this.tmrDemoRatate = new System.Windows.Forms.Timer(this.components);
            this.pbLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTX)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLayout
            // 
            this.pbLayout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pbLayout.ColumnCount = 2;
            this.pbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pbLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pbLayout.Controls.Add(this.pb1, 0, 0);
            this.pbLayout.Controls.Add(this.pb2, 1, 0);
            this.pbLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLayout.Location = new System.Drawing.Point(0, 64);
            this.pbLayout.Name = "pbLayout";
            this.pbLayout.RowCount = 1;
            this.pbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pbLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 357F));
            this.pbLayout.Size = new System.Drawing.Size(1092, 459);
            this.pbLayout.TabIndex = 0;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb1.Location = new System.Drawing.Point(8, 8);
            this.pb1.Margin = new System.Windows.Forms.Padding(8, 8, 4, 8);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(534, 443);
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Paint += new System.Windows.Forms.PaintEventHandler(this.pb1_Paint);
            this.pb1.Resize += new System.EventHandler(this.pb1_Resize);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb2.Location = new System.Drawing.Point(550, 8);
            this.pb2.Margin = new System.Windows.Forms.Padding(4, 8, 8, 8);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(534, 443);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Paint += new System.Windows.Forms.PaintEventHandler(this.pb2_Paint);
            this.pb2.Resize += new System.EventHandler(this.pb2_Resize);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.lblCPoint);
            this.panel.Controls.Add(this.lblCZ);
            this.panel.Controls.Add(this.nudCZ);
            this.panel.Controls.Add(this.lblCY);
            this.panel.Controls.Add(this.nudCY);
            this.panel.Controls.Add(this.lblCX);
            this.panel.Controls.Add(this.nudCX);
            this.panel.Controls.Add(this.lblTPoint);
            this.panel.Controls.Add(this.lblTZ);
            this.panel.Controls.Add(this.nudTZ);
            this.panel.Controls.Add(this.lblTY);
            this.panel.Controls.Add(this.nudTY);
            this.panel.Controls.Add(this.lblTX);
            this.panel.Controls.Add(this.nudTX);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1092, 64);
            this.panel.TabIndex = 1;
            // 
            // lblCPoint
            // 
            this.lblCPoint.AutoSize = true;
            this.lblCPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCPoint.Location = new System.Drawing.Point(330, 11);
            this.lblCPoint.Name = "lblCPoint";
            this.lblCPoint.Size = new System.Drawing.Size(54, 13);
            this.lblCPoint.TabIndex = 13;
            this.lblCPoint.Text = "Точка C";
            // 
            // lblCZ
            // 
            this.lblCZ.AutoSize = true;
            this.lblCZ.Location = new System.Drawing.Point(528, 34);
            this.lblCZ.Name = "lblCZ";
            this.lblCZ.Size = new System.Drawing.Size(14, 13);
            this.lblCZ.TabIndex = 12;
            this.lblCZ.Text = "Z";
            // 
            // nudCZ
            // 
            this.nudCZ.DecimalPlaces = 1;
            this.nudCZ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCZ.Location = new System.Drawing.Point(546, 30);
            this.nudCZ.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCZ.Name = "nudCZ";
            this.nudCZ.Size = new System.Drawing.Size(68, 20);
            this.nudCZ.TabIndex = 11;
            this.nudCZ.Value = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.nudCZ.ValueChanged += new System.EventHandler(this.nudC_ValueChanged);
            // 
            // lblCY
            // 
            this.lblCY.AutoSize = true;
            this.lblCY.Location = new System.Drawing.Point(428, 34);
            this.lblCY.Name = "lblCY";
            this.lblCY.Size = new System.Drawing.Size(14, 13);
            this.lblCY.TabIndex = 10;
            this.lblCY.Text = "Y";
            // 
            // nudCY
            // 
            this.nudCY.DecimalPlaces = 1;
            this.nudCY.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCY.Location = new System.Drawing.Point(446, 30);
            this.nudCY.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCY.Name = "nudCY";
            this.nudCY.Size = new System.Drawing.Size(68, 20);
            this.nudCY.TabIndex = 9;
            this.nudCY.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudCY.ValueChanged += new System.EventHandler(this.nudC_ValueChanged);
            // 
            // lblCX
            // 
            this.lblCX.AutoSize = true;
            this.lblCX.Location = new System.Drawing.Point(330, 34);
            this.lblCX.Name = "lblCX";
            this.lblCX.Size = new System.Drawing.Size(14, 13);
            this.lblCX.TabIndex = 8;
            this.lblCX.Text = "X";
            // 
            // nudCX
            // 
            this.nudCX.DecimalPlaces = 1;
            this.nudCX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCX.Location = new System.Drawing.Point(348, 30);
            this.nudCX.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudCX.Name = "nudCX";
            this.nudCX.Size = new System.Drawing.Size(68, 20);
            this.nudCX.TabIndex = 7;
            this.nudCX.Value = new decimal(new int[] {
            35,
            0,
            0,
            65536});
            this.nudCX.ValueChanged += new System.EventHandler(this.nudC_ValueChanged);
            // 
            // lblTPoint
            // 
            this.lblTPoint.AutoSize = true;
            this.lblTPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTPoint.Location = new System.Drawing.Point(11, 11);
            this.lblTPoint.Name = "lblTPoint";
            this.lblTPoint.Size = new System.Drawing.Size(54, 13);
            this.lblTPoint.TabIndex = 6;
            this.lblTPoint.Text = "Точка T";
            // 
            // lblTZ
            // 
            this.lblTZ.AutoSize = true;
            this.lblTZ.Location = new System.Drawing.Point(209, 34);
            this.lblTZ.Name = "lblTZ";
            this.lblTZ.Size = new System.Drawing.Size(14, 13);
            this.lblTZ.TabIndex = 5;
            this.lblTZ.Text = "Z";
            // 
            // nudTZ
            // 
            this.nudTZ.Location = new System.Drawing.Point(227, 30);
            this.nudTZ.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTZ.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTZ.Name = "nudTZ";
            this.nudTZ.Size = new System.Drawing.Size(68, 20);
            this.nudTZ.TabIndex = 4;
            this.nudTZ.Value = new decimal(new int[] {
            85,
            0,
            0,
            0});
            this.nudTZ.ValueChanged += new System.EventHandler(this.nudT_ValueChanged);
            // 
            // lblTY
            // 
            this.lblTY.AutoSize = true;
            this.lblTY.Location = new System.Drawing.Point(109, 34);
            this.lblTY.Name = "lblTY";
            this.lblTY.Size = new System.Drawing.Size(14, 13);
            this.lblTY.TabIndex = 3;
            this.lblTY.Text = "Y";
            // 
            // nudTY
            // 
            this.nudTY.Location = new System.Drawing.Point(127, 30);
            this.nudTY.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTY.Name = "nudTY";
            this.nudTY.Size = new System.Drawing.Size(68, 20);
            this.nudTY.TabIndex = 2;
            this.nudTY.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTY.ValueChanged += new System.EventHandler(this.nudT_ValueChanged);
            // 
            // lblTX
            // 
            this.lblTX.AutoSize = true;
            this.lblTX.Location = new System.Drawing.Point(11, 34);
            this.lblTX.Name = "lblTX";
            this.lblTX.Size = new System.Drawing.Size(14, 13);
            this.lblTX.TabIndex = 1;
            this.lblTX.Text = "X";
            // 
            // nudTX
            // 
            this.nudTX.Location = new System.Drawing.Point(29, 30);
            this.nudTX.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nudTX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTX.Name = "nudTX";
            this.nudTX.Size = new System.Drawing.Size(68, 20);
            this.nudTX.TabIndex = 0;
            this.nudTX.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudTX.ValueChanged += new System.EventHandler(this.nudT_ValueChanged);
            // 
            // tmrDemoRatate
            // 
            this.tmrDemoRatate.Enabled = true;
            this.tmrDemoRatate.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 523);
            this.Controls.Add(this.pbLayout);
            this.Controls.Add(this.panel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа по компьютерной графике. Егоров Евгений. ПРО-406сз";
            this.pbLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pbLayout;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Label lblCPoint;
        private System.Windows.Forms.Label lblCZ;
        private System.Windows.Forms.NumericUpDown nudCZ;
        private System.Windows.Forms.Label lblCY;
        private System.Windows.Forms.NumericUpDown nudCY;
        private System.Windows.Forms.Label lblCX;
        private System.Windows.Forms.NumericUpDown nudCX;
        private System.Windows.Forms.Label lblTPoint;
        private System.Windows.Forms.Label lblTZ;
        private System.Windows.Forms.NumericUpDown nudTZ;
        private System.Windows.Forms.Label lblTY;
        private System.Windows.Forms.NumericUpDown nudTY;
        private System.Windows.Forms.Label lblTX;
        private System.Windows.Forms.NumericUpDown nudTX;
        private System.Windows.Forms.Timer tmrDemoRatate;
    }
}

