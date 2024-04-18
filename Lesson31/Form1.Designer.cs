namespace Lesson31
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
            tbFirst = new TextBox();
            label2 = new Label();
            tbSecond = new TextBox();
            btAdd = new Button();
            btSub = new Button();
            btMult = new Button();
            btDiv = new Button();
            lbResult = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 159);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(228, 30);
            label1.TabIndex = 0;
            label1.Text = "Введите первое число";
            // 
            // tbFirst
            // 
            tbFirst.Location = new Point(155, 194);
            tbFirst.Margin = new Padding(5, 6, 5, 6);
            tbFirst.Name = "tbFirst";
            tbFirst.Size = new Size(400, 35);
            tbFirst.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(155, 246);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(226, 30);
            label2.TabIndex = 2;
            label2.Text = "Введите второе число";
            // 
            // tbSecond
            // 
            tbSecond.Location = new Point(155, 281);
            tbSecond.Margin = new Padding(5, 6, 5, 6);
            tbSecond.Name = "tbSecond";
            tbSecond.Size = new Size(400, 35);
            tbSecond.TabIndex = 3;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(20, 366);
            btAdd.Margin = new Padding(5, 6, 5, 6);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(128, 46);
            btAdd.TabIndex = 4;
            btAdd.Text = "+";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btSub
            // 
            btSub.Location = new Point(179, 366);
            btSub.Margin = new Padding(5, 6, 5, 6);
            btSub.Name = "btSub";
            btSub.Size = new Size(128, 46);
            btSub.TabIndex = 5;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += btSub_Click;
            // 
            // btMult
            // 
            btMult.Location = new Point(340, 366);
            btMult.Margin = new Padding(5, 6, 5, 6);
            btMult.Name = "btMult";
            btMult.Size = new Size(128, 46);
            btMult.TabIndex = 6;
            btMult.Text = "*";
            btMult.UseVisualStyleBackColor = true;
            btMult.Click += btMult_Click;
            // 
            // btDiv
            // 
            btDiv.Location = new Point(504, 370);
            btDiv.Margin = new Padding(5, 6, 5, 6);
            btDiv.Name = "btDiv";
            btDiv.Size = new Size(128, 46);
            btDiv.TabIndex = 7;
            btDiv.Text = "/";
            btDiv.UseVisualStyleBackColor = true;
            btDiv.Click += btDiv_Click;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lbResult.ForeColor = Color.IndianRed;
            lbResult.Location = new Point(20, 441);
            lbResult.Margin = new Padding(5, 0, 5, 0);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(612, 136);
            lbResult.TabIndex = 8;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(545, 494);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(105, 30);
            linkLabel1.TabIndex = 9;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "linkLabel1";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 575);
            Controls.Add(linkLabel1);
            Controls.Add(lbResult);
            Controls.Add(btDiv);
            Controls.Add(btMult);
            Controls.Add(btSub);
            Controls.Add(btAdd);
            Controls.Add(tbSecond);
            Controls.Add(label2);
            Controls.Add(tbFirst);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Моя первая программа";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbFirst;
        private Label label2;
        private TextBox tbSecond;
        private Button btAdd;
        private Button btSub;
        private Button btMult;
        private Button btDiv;
        private Label lbResult;
        private LinkLabel linkLabel1;
    }
}