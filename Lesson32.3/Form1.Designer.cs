namespace Lesson32._3
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
            tbxWidth = new TextBox();
            label2 = new Label();
            txbHeight = new TextBox();
            lbxMaterial = new ListBox();
            pbxMaterial = new PictureBox();
            lbResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 23);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Ширина";
            label1.Click += label1_Click;
            // 
            // tbxWidth
            // 
            tbxWidth.Location = new Point(100, 23);
            tbxWidth.Name = "tbxWidth";
            tbxWidth.Size = new Size(134, 23);
            tbxWidth.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 73);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Высота";
            // 
            // txbHeight
            // 
            txbHeight.Location = new Point(100, 73);
            txbHeight.Name = "txbHeight";
            txbHeight.Size = new Size(134, 23);
            txbHeight.TabIndex = 3;
            // 
            // lbxMaterial
            // 
            lbxMaterial.FormattingEnabled = true;
            lbxMaterial.ItemHeight = 15;
            lbxMaterial.Items.AddRange(new object[] { "Алюминий", "Пластик", "Дерево", "Бамбук" });
            lbxMaterial.Location = new Point(34, 126);
            lbxMaterial.Name = "lbxMaterial";
            lbxMaterial.Size = new Size(200, 304);
            lbxMaterial.TabIndex = 4;
            lbxMaterial.SelectedIndexChanged += lbxMaterial_SelectedIndexChanged;
            // 
            // pbxMaterial
            // 
            pbxMaterial.Location = new Point(262, 23);
            pbxMaterial.Name = "pbxMaterial";
            pbxMaterial.Size = new Size(329, 302);
            pbxMaterial.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxMaterial.TabIndex = 5;
            pbxMaterial.TabStop = false;
            // 
            // lbResult
            // 
            lbResult.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lbResult.Location = new Point(267, 348);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(324, 72);
            lbResult.TabIndex = 7;
            lbResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(lbResult);
            Controls.Add(pbxMaterial);
            Controls.Add(lbxMaterial);
            Controls.Add(txbHeight);
            Controls.Add(label2);
            Controls.Add(tbxWidth);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Жалюзи";
            ((System.ComponentModel.ISupportInitialize)pbxMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbxWidth;
        private Label label2;
        private TextBox txbHeight;
        private ListBox lbxMaterial;
        private PictureBox pbxMaterial;
        private Label lbResult;
    }
}