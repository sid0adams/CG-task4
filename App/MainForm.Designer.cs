namespace App
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
            this.Output = new System.Windows.Forms.PictureBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ExportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.X0Input = new System.Windows.Forms.NumericUpDown();
            this.Y0Input = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Z0Input = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.R0Input = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.R1Input = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Z1Input = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.Y1Input = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.X1Input = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.NInput = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Output)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R0Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NInput)).BeginInit();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.Location = new System.Drawing.Point(13, 13);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(425, 425);
            this.Output.TabIndex = 0;
            this.Output.TabStop = false;
            this.Output.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Output_MouseMove);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "*.obj | obj |*.* |all";
            // 
            // ExportBtn
            // 
            this.ExportBtn.Location = new System.Drawing.Point(445, 13);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(96, 23);
            this.ExportBtn.TabIndex = 1;
            this.ExportBtn.Text = "Export To .OBJ";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "X 0";
            // 
            // X0Input
            // 
            this.X0Input.Location = new System.Drawing.Point(474, 41);
            this.X0Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.X0Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.X0Input.Name = "X0Input";
            this.X0Input.Size = new System.Drawing.Size(67, 20);
            this.X0Input.TabIndex = 3;
            // 
            // Y0Input
            // 
            this.Y0Input.Location = new System.Drawing.Point(576, 41);
            this.Y0Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Y0Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.Y0Input.Name = "Y0Input";
            this.Y0Input.Size = new System.Drawing.Size(67, 20);
            this.Y0Input.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Y 0";
            // 
            // Z0Input
            // 
            this.Z0Input.Location = new System.Drawing.Point(678, 41);
            this.Z0Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Z0Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.Z0Input.Name = "Z0Input";
            this.Z0Input.Size = new System.Drawing.Size(67, 20);
            this.Z0Input.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Z 0";
            // 
            // R0Input
            // 
            this.R0Input.Location = new System.Drawing.Point(780, 41);
            this.R0Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.R0Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.R0Input.Name = "R0Input";
            this.R0Input.Size = new System.Drawing.Size(67, 20);
            this.R0Input.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(751, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "R 0";
            // 
            // R1Input
            // 
            this.R1Input.Location = new System.Drawing.Point(780, 67);
            this.R1Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.R1Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.R1Input.Name = "R1Input";
            this.R1Input.Size = new System.Drawing.Size(67, 20);
            this.R1Input.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(751, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "R 1";
            // 
            // Z1Input
            // 
            this.Z1Input.Location = new System.Drawing.Point(678, 67);
            this.Z1Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Z1Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.Z1Input.Name = "Z1Input";
            this.Z1Input.Size = new System.Drawing.Size(67, 20);
            this.Z1Input.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Z 1";
            // 
            // Y1Input
            // 
            this.Y1Input.Location = new System.Drawing.Point(576, 67);
            this.Y1Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.Y1Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.Y1Input.Name = "Y1Input";
            this.Y1Input.Size = new System.Drawing.Size(67, 20);
            this.Y1Input.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(547, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Y 1";
            // 
            // X1Input
            // 
            this.X1Input.Location = new System.Drawing.Point(474, 67);
            this.X1Input.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.X1Input.Minimum = new decimal(new int[] {
            40,
            0,
            0,
            -2147483648});
            this.X1Input.Name = "X1Input";
            this.X1Input.Size = new System.Drawing.Size(67, 20);
            this.X1Input.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(445, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "X 1";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(466, 93);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 18;
            this.AddBtn.Text = "add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(548, 13);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 19;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // NInput
            // 
            this.NInput.Location = new System.Drawing.Point(576, 93);
            this.NInput.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NInput.Name = "NInput";
            this.NInput.Size = new System.Drawing.Size(67, 20);
            this.NInput.TabIndex = 21;
            this.NInput.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "N";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.NInput);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.R1Input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Z1Input);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Y1Input);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.X1Input);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.R0Input);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Z0Input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Y0Input);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.X0Input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExportBtn);
            this.Controls.Add(this.Output);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Output)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R0Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X1Input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Output;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown X0Input;
        private System.Windows.Forms.NumericUpDown Y0Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Z0Input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown R0Input;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown R1Input;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Z1Input;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown Y1Input;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown X1Input;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.NumericUpDown NInput;
        private System.Windows.Forms.Label label9;
    }
}

