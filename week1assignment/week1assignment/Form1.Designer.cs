namespace week1assignment
{
    partial class Form1
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
            this.sumButton = new System.Windows.Forms.Button();
            this.title1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.resultText = new System.Windows.Forms.TextBox();
            this.diffButton = new System.Windows.Forms.Button();
            this.prodButton = new System.Windows.Forms.Button();
            this.quotButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.subtitle = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            this.SuspendLayout();
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(73, 251);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(85, 37);
            this.sumButton.TabIndex = 0;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // title1
            // 
            this.title1.AutoSize = true;
            this.title1.Location = new System.Drawing.Point(103, 26);
            this.title1.Name = "title1";
            this.title1.Size = new System.Drawing.Size(264, 20);
            this.title1.TabIndex = 1;
            this.title1.Text = "Week 1 Assigment - Marceu Martins";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Second Number:";
            // 
            // resultText
            // 
            this.resultText.Location = new System.Drawing.Point(73, 192);
            this.resultText.Name = "resultText";
            this.resultText.Size = new System.Drawing.Size(358, 26);
            this.resultText.TabIndex = 6;
            // 
            // diffButton
            // 
            this.diffButton.Location = new System.Drawing.Point(164, 251);
            this.diffButton.Name = "diffButton";
            this.diffButton.Size = new System.Drawing.Size(85, 37);
            this.diffButton.TabIndex = 7;
            this.diffButton.Text = "Diff";
            this.diffButton.UseVisualStyleBackColor = true;
            this.diffButton.Click += new System.EventHandler(this.diffButton_Click);
            // 
            // prodButton
            // 
            this.prodButton.Location = new System.Drawing.Point(255, 251);
            this.prodButton.Name = "prodButton";
            this.prodButton.Size = new System.Drawing.Size(85, 37);
            this.prodButton.TabIndex = 8;
            this.prodButton.Text = "Prod";
            this.prodButton.UseVisualStyleBackColor = true;
            this.prodButton.Click += new System.EventHandler(this.prodButton_Click);
            // 
            // quotButton
            // 
            this.quotButton.Location = new System.Drawing.Point(346, 251);
            this.quotButton.Name = "quotButton";
            this.quotButton.Size = new System.Drawing.Size(85, 37);
            this.quotButton.TabIndex = 9;
            this.quotButton.Text = "Quot";
            this.quotButton.UseVisualStyleBackColor = true;
            this.quotButton.Click += new System.EventHandler(this.quotButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(112, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(85, 37);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(255, 325);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(85, 37);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // subtitle
            // 
            this.subtitle.AutoSize = true;
            this.subtitle.Location = new System.Drawing.Point(173, 58);
            this.subtitle.Name = "subtitle";
            this.subtitle.Size = new System.Drawing.Size(147, 20);
            this.subtitle.TabIndex = 12;
            this.subtitle.Text = "Simple Calculations";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(268, 98);
            this.input1.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.input1.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(163, 26);
            this.input1.TabIndex = 13;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(268, 140);
            this.input2.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.input2.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(163, 26);
            this.input2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 397);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.subtitle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.quotButton);
            this.Controls.Add(this.prodButton);
            this.Controls.Add(this.diffButton);
            this.Controls.Add(this.resultText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.sumButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox resultText;
        private System.Windows.Forms.Button diffButton;
        private System.Windows.Forms.Button prodButton;
        private System.Windows.Forms.Button quotButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label subtitle;
        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.NumericUpDown input2;
    }
}

