namespace Lesson35._3
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
            label1 = new Label();
            tbResult = new TextBox();
            label2 = new Label();
            label3 = new Label();
            tbFrom = new TextBox();
            tbUntil = new TextBox();
            btGenerate = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tbNumber = new TextBox();
            label4 = new Label();
            cbxLong = new ComboBox();
            label5 = new Label();
            cbxTemp = new ComboBox();
            label6 = new Label();
            cbxPressure = new ComboBox();
            label7 = new Label();
            lbResult = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Случайное число:";
            // 
            // tbResult
            // 
            tbResult.Location = new Point(20, 58);
            tbResult.Margin = new Padding(5);
            tbResult.Name = "tbResult";
            tbResult.ReadOnly = true;
            tbResult.Size = new Size(392, 32);
            tbResult.TabIndex = 1;
            tbResult.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 95);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 25);
            label2.TabIndex = 2;
            label2.Text = "От:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(257, 95);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(40, 25);
            label3.TabIndex = 3;
            label3.Text = "До:";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(20, 137);
            tbFrom.Margin = new Padding(5);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(155, 32);
            tbFrom.TabIndex = 4;
            tbFrom.TextAlign = HorizontalAlignment.Center;
            // 
            // tbUntil
            // 
            tbUntil.Location = new Point(257, 137);
            tbUntil.Margin = new Padding(5);
            tbUntil.Name = "tbUntil";
            tbUntil.Size = new Size(155, 32);
            tbUntil.TabIndex = 5;
            tbUntil.TextAlign = HorizontalAlignment.Center;
            // 
            // btGenerate
            // 
            btGenerate.Location = new Point(20, 193);
            btGenerate.Margin = new Padding(5);
            btGenerate.Name = "btGenerate";
            btGenerate.Size = new Size(392, 117);
            btGenerate.TabIndex = 6;
            btGenerate.Text = "Сгенерировать";
            btGenerate.UseVisualStyleBackColor = true;
            btGenerate.Click += btGenerate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btGenerate);
            groupBox1.Controls.Add(tbResult);
            groupBox1.Controls.Add(tbUntil);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbFrom);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(458, 335);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Задача №1";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbResult);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(cbxPressure);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cbxTemp);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cbxLong);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(tbNumber);
            groupBox2.Location = new Point(488, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 336);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задача №2";
            // 
            // tbNumber
            // 
            tbNumber.Location = new Point(21, 59);
            tbNumber.Name = "tbNumber";
            tbNumber.Size = new Size(469, 32);
            tbNumber.TabIndex = 0;
            tbNumber.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 28);
            label4.Name = "label4";
            label4.Size = new Size(139, 25);
            label4.TabIndex = 1;
            label4.Text = "Введите число";
            // 
            // cbxLong
            // 
            cbxLong.FormattingEnabled = true;
            cbxLong.Items.AddRange(new object[] { "сантиметры", "дециметры", "метры", "километры" });
            cbxLong.Location = new Point(21, 137);
            cbxLong.Name = "cbxLong";
            cbxLong.Size = new Size(139, 33);
            cbxLong.TabIndex = 2;
            cbxLong.SelectedIndexChanged += cbxLong_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 96);
            label5.Name = "label5";
            label5.Size = new Size(84, 25);
            label5.TabIndex = 3;
            label5.Text = "Из мм в:";
            // 
            // cbxTemp
            // 
            cbxTemp.FormattingEnabled = true;
            cbxTemp.Items.AddRange(new object[] { "Кельвины", "Фаренгейты" });
            cbxTemp.Location = new Point(168, 137);
            cbxTemp.Name = "cbxTemp";
            cbxTemp.Size = new Size(152, 33);
            cbxTemp.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(168, 96);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 5;
            label6.Text = "Из градусов С в:";
            // 
            // cbxPressure
            // 
            cbxPressure.FormattingEnabled = true;
            cbxPressure.Items.AddRange(new object[] { "мм.рт.ст", "бары", "атмосферы", "кгС" });
            cbxPressure.Location = new Point(326, 137);
            cbxPressure.Name = "cbxPressure";
            cbxPressure.Size = new Size(164, 33);
            cbxPressure.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(326, 96);
            label7.Name = "label7";
            label7.Size = new Size(141, 25);
            label7.TabIndex = 7;
            label7.Text = "Из Паскалей в:";
            // 
            // lbResult
            // 
            lbResult.Location = new Point(21, 194);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(469, 117);
            lbResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 361);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Случайное число";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox tbResult;
        private Label label2;
        private Label label3;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbNumber;
        private ComboBox cbxTemp;
        private Label label5;
        private ComboBox cbxLong;
        private Label label4;
        private Label lbResult;
        private Label label7;
        private ComboBox cbxPressure;
        private Label label6;
    }
}