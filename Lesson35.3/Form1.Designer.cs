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
            groupBox1.SuspendLayout();
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
            groupBox2.Location = new Point(488, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(511, 336);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "Задача №2";
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
    }
}