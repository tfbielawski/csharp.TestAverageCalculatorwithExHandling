namespace Test_Average_Calculator_with_Ex_Handling
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
            this.test1Label = new System.Windows.Forms.Label();
            this.test3Label = new System.Windows.Forms.Label();
            this.test2Label = new System.Windows.Forms.Label();
            this.test1TextBox = new System.Windows.Forms.TextBox();
            this.test2TextBox = new System.Windows.Forms.TextBox();
            this.test3TextBox = new System.Windows.Forms.TextBox();
            this.testAvgLabel = new System.Windows.Forms.Label();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // test1Label
            // 
            this.test1Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.test1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test1Label.Location = new System.Drawing.Point(67, 80);
            this.test1Label.Name = "test1Label";
            this.test1Label.Size = new System.Drawing.Size(200, 48);
            this.test1Label.TabIndex = 0;
            this.test1Label.Text = "Test Score 1";
            // 
            // test3Label
            // 
            this.test3Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.test3Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test3Label.Location = new System.Drawing.Point(67, 325);
            this.test3Label.Name = "test3Label";
            this.test3Label.Size = new System.Drawing.Size(200, 48);
            this.test3Label.TabIndex = 1;
            this.test3Label.Text = "Test Score 3";
            // 
            // test2Label
            // 
            this.test2Label.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.test2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.test2Label.Location = new System.Drawing.Point(67, 198);
            this.test2Label.Name = "test2Label";
            this.test2Label.Size = new System.Drawing.Size(200, 48);
            this.test2Label.TabIndex = 2;
            this.test2Label.Text = "Test Score 2";
            // 
            // test1TextBox
            // 
            this.test1TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.test1TextBox.Location = new System.Drawing.Point(570, 78);
            this.test1TextBox.Name = "test1TextBox";
            this.test1TextBox.Size = new System.Drawing.Size(400, 44);
            this.test1TextBox.TabIndex = 1;
            // 
            // test2TextBox
            // 
            this.test2TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.test2TextBox.Location = new System.Drawing.Point(570, 196);
            this.test2TextBox.Name = "test2TextBox";
            this.test2TextBox.Size = new System.Drawing.Size(400, 44);
            this.test2TextBox.TabIndex = 2;
            // 
            // test3TextBox
            // 
            this.test3TextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.test3TextBox.Location = new System.Drawing.Point(576, 329);
            this.test3TextBox.Name = "test3TextBox";
            this.test3TextBox.Size = new System.Drawing.Size(400, 44);
            this.test3TextBox.TabIndex = 3;
            // 
            // testAvgLabel
            // 
            this.testAvgLabel.BackColor = System.Drawing.SystemColors.Info;
            this.testAvgLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.testAvgLabel.Location = new System.Drawing.Point(57, 471);
            this.testAvgLabel.Name = "testAvgLabel";
            this.testAvgLabel.Size = new System.Drawing.Size(232, 48);
            this.testAvgLabel.TabIndex = 6;
            this.testAvgLabel.Text = "Your Average";
            // 
            // resultsLabel
            // 
            this.resultsLabel.BackColor = System.Drawing.SystemColors.Info;
            this.resultsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultsLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.resultsLabel.Location = new System.Drawing.Point(576, 471);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(400, 48);
            this.resultsLabel.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calcButton);
            this.groupBox1.Controls.Add(this.exitButton);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Location = new System.Drawing.Point(57, 570);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 238);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(0, 71);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(253, 110);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "&CALCULATE";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(660, 71);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(253, 110);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "EXI&T";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(324, 71);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(253, 110);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "C&LEAR";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 834);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.testAvgLabel);
            this.Controls.Add(this.test3TextBox);
            this.Controls.Add(this.test2TextBox);
            this.Controls.Add(this.test1TextBox);
            this.Controls.Add(this.test2Label);
            this.Controls.Add(this.test3Label);
            this.Controls.Add(this.test1Label);
            this.Name = "Form1";
            this.Text = "Test Scores Calculator";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label test1Label;
        private System.Windows.Forms.Label test3Label;
        private System.Windows.Forms.Label test2Label;
        private System.Windows.Forms.TextBox test1TextBox;
        private System.Windows.Forms.TextBox test2TextBox;
        private System.Windows.Forms.TextBox test3TextBox;
        private System.Windows.Forms.Label testAvgLabel;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
    }
}

