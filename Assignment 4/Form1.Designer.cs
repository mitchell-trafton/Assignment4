/************************************************************
* Assignment 4
* Programmers: Robert Tyler Trotter z1802019
*              Mitchell Trafton     z1831076
***********************************************************/
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lineBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.apply_btn = new System.Windows.Forms.Button();
            this.yintvl_txt = new System.Windows.Forms.TextBox();
            this.yintvl_lbl = new System.Windows.Forms.Label();
            this.ymax_txt = new System.Windows.Forms.TextBox();
            this.ymax_lbl = new System.Windows.Forms.Label();
            this.ymin_txt = new System.Windows.Forms.TextBox();
            this.ymin_lbl = new System.Windows.Forms.Label();
            this.xintvl_txt = new System.Windows.Forms.TextBox();
            this.xintvl_lbl = new System.Windows.Forms.Label();
            this.xmax_txt = new System.Windows.Forms.TextBox();
            this.xmax_lbl = new System.Windows.Forms.Label();
            this.xmin_txt = new System.Windows.Forms.TextBox();
            this.xmin_lbl = new System.Windows.Forms.Label();
            this.tip1 = new System.Windows.Forms.ToolTip();
            this.tip2 = new System.Windows.Forms.ToolTip();
            this.tip3 = new System.Windows.Forms.ToolTip();
            this.tip4 = new System.Windows.Forms.ToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 400);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(44, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(44, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(156, 20);
            this.textBox2.TabIndex = 2;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(44, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(156, 20);
            this.textBox3.TabIndex = 3;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(44, 141);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(156, 20);
            this.textBox4.TabIndex = 4;
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
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
            this.equationBox.Location = new System.Drawing.Point(363, 35);
            this.equationBox.Name = "equationBox";
            this.equationBox.Size = new System.Drawing.Size(209, 21);
            this.equationBox.TabIndex = 5;
            this.equationBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 106);
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
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "M=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "B=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "H=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "K=";
            // 
            // equationLabel
            // 
            this.equationLabel.AutoSize = true;
            this.equationLabel.Location = new System.Drawing.Point(284, 35);
            this.equationLabel.Name = "equationLabel";
            this.equationLabel.Size = new System.Drawing.Size(54, 13);
            this.equationLabel.TabIndex = 11;
            this.equationLabel.Text = "Equations";
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Location = new System.Drawing.Point(266, 71);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(72, 13);
            this.lineLabel.TabIndex = 12;
            this.lineLabel.Text = "Line selection";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(410, 135);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 23);
            this.clearButton.TabIndex = 14;
            this.clearButton.Text = "Clear Line";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // lineBox
            // 
            this.lineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lineBox.FormattingEnabled = true;
            this.lineBox.Items.AddRange(new object[] {
            "Line 1 (Black)",
            "Line 2 (Red)",
            "Line 3 (Green)",
            "Line 4 (Blue)"});
            this.lineBox.Location = new System.Drawing.Point(363, 68);
            this.lineBox.Name = "lineBox";
            this.lineBox.Size = new System.Drawing.Size(209, 21);
            this.lineBox.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.lineBox);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.lineLabel);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.equationLabel);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.equationBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 420);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 192);
            this.panel1.TabIndex = 16;
            // 
            // apply_btn
            // 
            this.apply_btn.Location = new System.Drawing.Point(626, 252);
            this.apply_btn.Name = "apply_btn";
            this.apply_btn.Size = new System.Drawing.Size(75, 23);
            this.apply_btn.TabIndex = 28;
            this.apply_btn.Text = "Apply";
            this.apply_btn.UseVisualStyleBackColor = true;
            this.apply_btn.Click += new System.EventHandler(this.apply_btn_Click);
            // 
            // yintvl_txt
            // 
            this.yintvl_txt.Location = new System.Drawing.Point(589, 226);
            this.yintvl_txt.Name = "yintvl_txt";
            this.yintvl_txt.Size = new System.Drawing.Size(156, 20);
            this.yintvl_txt.TabIndex = 26;
            this.yintvl_txt.Text = "1";
            this.yintvl_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yintvl_txt_KeyPress);
            // 
            // yintvl_lbl
            // 
            this.yintvl_lbl.AutoSize = true;
            this.yintvl_lbl.Location = new System.Drawing.Point(528, 229);
            this.yintvl_lbl.Name = "yintvl_lbl";
            this.yintvl_lbl.Size = new System.Drawing.Size(55, 13);
            this.yintvl_lbl.TabIndex = 27;
            this.yintvl_lbl.Text = "y-interval=";
            // 
            // ymax_txt
            // 
            this.ymax_txt.Location = new System.Drawing.Point(589, 200);
            this.ymax_txt.Name = "ymax_txt";
            this.ymax_txt.Size = new System.Drawing.Size(156, 20);
            this.ymax_txt.TabIndex = 24;
            this.ymax_txt.Text = "10";
            this.ymax_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ymax_txt_KeyPress);
            // 
            // ymax_lbl
            // 
            this.ymax_lbl.AutoSize = true;
            this.ymax_lbl.Location = new System.Drawing.Point(543, 203);
            this.ymax_lbl.Name = "ymax_lbl";
            this.ymax_lbl.Size = new System.Drawing.Size(40, 13);
            this.ymax_lbl.TabIndex = 25;
            this.ymax_lbl.Text = "y-max=";
            // 
            // ymin_txt
            // 
            this.ymin_txt.Location = new System.Drawing.Point(589, 174);
            this.ymin_txt.Name = "ymin_txt";
            this.ymin_txt.Size = new System.Drawing.Size(156, 20);
            this.ymin_txt.TabIndex = 22;
            this.ymin_txt.Text = "-10";
            this.ymin_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ymin_txt_KeyPress);
            // 
            // ymin_lbl
            // 
            this.ymin_lbl.AutoSize = true;
            this.ymin_lbl.Location = new System.Drawing.Point(546, 177);
            this.ymin_lbl.Name = "ymin_lbl";
            this.ymin_lbl.Size = new System.Drawing.Size(37, 13);
            this.ymin_lbl.TabIndex = 23;
            this.ymin_lbl.Text = "y-min=";
            // 
            // xintvl_txt
            // 
            this.xintvl_txt.Location = new System.Drawing.Point(589, 150);
            this.xintvl_txt.Name = "xintvl_txt";
            this.xintvl_txt.Size = new System.Drawing.Size(156, 20);
            this.xintvl_txt.TabIndex = 20;
            this.xintvl_txt.Text = "1";
            this.xintvl_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xintvl_txt_KeyPress);
            // 
            // xintvl_lbl
            // 
            this.xintvl_lbl.AutoSize = true;
            this.xintvl_lbl.Location = new System.Drawing.Point(528, 155);
            this.xintvl_lbl.Name = "xintvl_lbl";
            this.xintvl_lbl.Size = new System.Drawing.Size(55, 13);
            this.xintvl_lbl.TabIndex = 21;
            this.xintvl_lbl.Text = "x-interval=";
            // 
            // xmax_txt
            // 
            this.xmax_txt.Location = new System.Drawing.Point(589, 128);
            this.xmax_txt.Name = "xmax_txt";
            this.xmax_txt.Size = new System.Drawing.Size(156, 20);
            this.xmax_txt.TabIndex = 18;
            this.xmax_txt.Text = "10";
            this.xmax_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xmax_txt_KeyPress);
            // 
            // xmax_lbl
            // 
            this.xmax_lbl.AutoSize = true;
            this.xmax_lbl.Location = new System.Drawing.Point(543, 131);
            this.xmax_lbl.Name = "xmax_lbl";
            this.xmax_lbl.Size = new System.Drawing.Size(40, 13);
            this.xmax_lbl.TabIndex = 19;
            this.xmax_lbl.Text = "x-max=";
            // 
            // xmin_txt
            // 
            this.xmin_txt.Location = new System.Drawing.Point(589, 102);
            this.xmin_txt.Name = "xmin_txt";
            this.xmin_txt.Size = new System.Drawing.Size(156, 20);
            this.xmin_txt.TabIndex = 16;
            this.xmin_txt.Text = "-10";
            this.xmin_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.xmin_txt_KeyPress);
            // 
            // xmin_lbl
            // 
            this.xmin_lbl.AutoSize = true;
            this.xmin_lbl.Location = new System.Drawing.Point(546, 105);
            this.xmin_lbl.Name = "xmin_lbl";
            this.xmin_lbl.Size = new System.Drawing.Size(37, 13);
            this.xmin_lbl.TabIndex = 17;
            this.xmin_lbl.Text = "x-min=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 612);
            this.Controls.Add(this.apply_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.yintvl_txt);
            this.Controls.Add(this.yintvl_lbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ymax_txt);
            this.Controls.Add(this.xmin_lbl);
            this.Controls.Add(this.ymax_lbl);
            this.Controls.Add(this.xmin_txt);
            this.Controls.Add(this.ymin_txt);
            this.Controls.Add(this.xmax_lbl);
            this.Controls.Add(this.ymin_lbl);
            this.Controls.Add(this.xmax_txt);
            this.Controls.Add(this.xintvl_txt);
            this.Controls.Add(this.xintvl_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1; // first label
        private System.Windows.Forms.Label label2;// second label
        private System.Windows.Forms.Label label3;// third label
        private System.Windows.Forms.Label label4;// fourth label
        private System.Windows.Forms.Label equationLabel;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button clearButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox lineBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button apply_btn;
        private System.Windows.Forms.TextBox yintvl_txt;
        private System.Windows.Forms.Label yintvl_lbl;
        private System.Windows.Forms.TextBox ymax_txt;
        private System.Windows.Forms.Label ymax_lbl;
        private System.Windows.Forms.TextBox ymin_txt;
        private System.Windows.Forms.Label ymin_lbl;
        private System.Windows.Forms.TextBox xintvl_txt;
        private System.Windows.Forms.Label xintvl_lbl;
        private System.Windows.Forms.TextBox xmax_txt;
        private System.Windows.Forms.Label xmax_lbl;
        private System.Windows.Forms.TextBox xmin_txt;
        private System.Windows.Forms.Label xmin_lbl;
        private System.Windows.Forms.ToolTip tip1;
        private System.Windows.Forms.ToolTip tip2;
        private System.Windows.Forms.ToolTip tip3;
        private System.Windows.Forms.ToolTip tip4;
    }
}

