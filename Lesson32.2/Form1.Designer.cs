namespace Lesson32._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            tb9x13 = new TextBox();
            tb10x15 = new TextBox();
            tb15x20 = new TextBox();
            rb9x13 = new RadioButton();
            rb10x15 = new RadioButton();
            rb15x20 = new RadioButton();
            tbCount = new TextBox();
            label1 = new Label();
            btOk = new Button();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb9x13);
            groupBox1.Controls.Add(tb10x15);
            groupBox1.Controls.Add(tb15x20);
            groupBox1.Controls.Add(rb9x13);
            groupBox1.Controls.Add(rb10x15);
            groupBox1.Controls.Add(rb15x20);
            groupBox1.Location = new Point(17, 18);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(371, 159);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Размеры и цены";
            // 
            // tb9x13
            // 
            tb9x13.Enabled = false;
            tb9x13.Location = new Point(117, 108);
            tb9x13.Name = "tb9x13";
            tb9x13.Size = new Size(231, 30);
            tb9x13.TabIndex = 5;
            tb9x13.KeyPress += tb9x13_KeyPress;
            // 
            // tb10x15
            // 
            tb10x15.Enabled = false;
            tb10x15.Location = new Point(117, 73);
            tb10x15.Name = "tb10x15";
            tb10x15.Size = new Size(231, 30);
            tb10x15.TabIndex = 4;
            tb10x15.KeyPress += tb10x15_KeyPress;
            // 
            // tb15x20
            // 
            tb15x20.Enabled = false;
            tb15x20.Location = new Point(117, 37);
            tb15x20.Name = "tb15x20";
            tb15x20.Size = new Size(231, 30);
            tb15x20.TabIndex = 3;
            tb15x20.KeyPress += tb15x20_KeyPress;
            // 
            // rb9x13
            // 
            rb9x13.AutoSize = true;
            rb9x13.Location = new Point(19, 106);
            rb9x13.Name = "rb9x13";
            rb9x13.Size = new Size(69, 27);
            rb9x13.TabIndex = 2;
            rb9x13.TabStop = true;
            rb9x13.Text = "9X13";
            rb9x13.UseVisualStyleBackColor = true;
            rb9x13.CheckedChanged += rb9x13_CheckedChanged;
            // 
            // rb10x15
            // 
            rb10x15.AutoSize = true;
            rb10x15.Location = new Point(19, 73);
            rb10x15.Name = "rb10x15";
            rb10x15.Size = new Size(79, 27);
            rb10x15.TabIndex = 1;
            rb10x15.TabStop = true;
            rb10x15.Text = "10X15";
            rb10x15.UseVisualStyleBackColor = true;
            rb10x15.CheckedChanged += rb10x15_CheckedChanged;
            // 
            // rb15x20
            // 
            rb15x20.AutoSize = true;
            rb15x20.Location = new Point(19, 40);
            rb15x20.Name = "rb15x20";
            rb15x20.Size = new Size(79, 27);
            rb15x20.TabIndex = 0;
            rb15x20.TabStop = true;
            rb15x20.Text = "15X20";
            rb15x20.UseVisualStyleBackColor = true;
            rb15x20.CheckedChanged += rb15x20_CheckedChanged;
            // 
            // tbCount
            // 
            tbCount.Location = new Point(134, 200);
            tbCount.Name = "tbCount";
            tbCount.Size = new Size(231, 30);
            tbCount.TabIndex = 1;
            tbCount.KeyPress += tbCount_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 200);
            label1.Name = "label1";
            label1.Size = new Size(111, 23);
            label1.TabIndex = 2;
            label1.Text = "Количество";
            // 
            // btOk
            // 
            btOk.Location = new Point(134, 251);
            btOk.Name = "btOk";
            btOk.Size = new Size(231, 58);
            btOk.TabIndex = 3;
            btOk.Text = "Расчитать";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Tahoma", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(17, 321);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(371, 132);
            lbResult.TabIndex = 4;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 479);
            Controls.Add(lbResult);
            Controls.Add(btOk);
            Controls.Add(label1);
            Controls.Add(tbCount);
            Controls.Add(groupBox1);
            Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Фотоателье";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb9x13;
        private RadioButton rb10x15;
        private RadioButton rb15x20;
        private TextBox tb15x20;
        private TextBox tb9x13;
        private TextBox tb10x15;
        private TextBox tbCount;
        private Label label1;
        private Button btOk;
        private Label lbResult;
    }
}