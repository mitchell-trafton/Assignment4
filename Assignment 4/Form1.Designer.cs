
namespace Assignment_4
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
            System.Windows.Forms.ComboBox lineBox;
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.equationBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.equationLabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.lineBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            //
            // line initialization, the key UInt denotes which line is being accessed, the four 0s following are for the four variables for a line. 
            //The fifth is for line type -1 is unused
            //
            Globals.line.Add(0, new int[] { 0, 0, 0, 0, -1 });
            Globals.line.Add(1, new int[] { 0, 0, 0, 0, -1 });
            Globals.line.Add(2, new int[] { 0, 0, 0, 0, -1 });
            Globals.line.Add(3, new int[] { 0, 0, 0, 0, -1 });
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 256);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 320);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(43, 357);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(43, 393);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 4;
            // 
            // equationBox
            // 
            this.equationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equationBox.FormattingEnabled = true;
            this.equationBox.Items.AddRange(new object[] {
            "Y = MX + B",
            "Y = AX² +BX + C",
            "Y = AX³ + BX² + CX + D",
            "R² = (x -h)² + (y-k)²"});
            this.equationBox.Location = new System.Drawing.Point(555, 312);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(209, 21);
            this.equationBox.TabIndex = 5;
            this.equationBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "M=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "B=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "H=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "K=";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Location = new System.Drawing.Point(476, 312);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(54, 13);
            this.equationLabel.TabIndex = 11;
            this.equationLabel.Text = "Equations";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Location = new System.Drawing.Point(458, 348);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(72, 13);
            this.lineLabel.TabIndex = 12;
            this.lineLabel.Text = "Line selection";
            // 
            // lineBox
            // 
            this.lineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineBox.FormattingEnabled = true;
            this.lineBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lineBox.Items.AddRange(new object[] {
            "Line 1 (Black)",
            "Line 2 (Red)",
            "Line 3 (Green)",
            "Line 4 (Blue)"});
            this.lineBox.Location = new System.Drawing.Point(555, 348);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(209, 21);
            this.lineBox.TabIndex = 13;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(602, 412);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Line";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.lineBox);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.equationLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.equationBox);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1; //first text box
        private System.Windows.Forms.TextBox textBox2; //second textbox
        private System.Windows.Forms.TextBox textBox3; //third textbox
        private System.Windows.Forms.TextBox textBox4; //fourth textbox
        private System.Windows.Forms.ComboBox equationBox;
        private System.Windows.Forms.ComboBox lineBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1; // first label
        private System.Windows.Forms.Label label2;// second label
        private System.Windows.Forms.Label label3;// third label
        private System.Windows.Forms.Label label4;// fourth label
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button clearButton;
    }
}

