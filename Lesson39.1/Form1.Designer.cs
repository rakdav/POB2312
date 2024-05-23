namespace Lesson39._1
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
            treeView1 = new TreeView();
            buttonChoice = new Button();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(547, 372);
            treeView1.TabIndex = 0;
            // 
            // buttonChoice
            // 
            buttonChoice.Location = new Point(12, 402);
            buttonChoice.Name = "buttonChoice";
            buttonChoice.Size = new Size(547, 36);
            buttonChoice.TabIndex = 1;
            buttonChoice.Text = "Выбрать";
            buttonChoice.UseVisualStyleBackColor = true;
            buttonChoice.Click += buttonChoice_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 450);
            Controls.Add(buttonChoice);
            Controls.Add(treeView1);
            Name = "Form1";
            Text = "Дерево";
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView1;
        private Button buttonChoice;
        private OpenFileDialog openFileDialog1;
    }
}