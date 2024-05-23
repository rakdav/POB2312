namespace Lesson38._1
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
            components = new System.ComponentModel.Container();
            listBoxTitle = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            listBoxAuthor = new ListBox();
            listBoxYear = new ListBox();
            label1 = new Label();
            textBoxTitle = new TextBox();
            label2 = new Label();
            textBoxAuthor = new TextBox();
            label3 = new Label();
            textBoxYear = new TextBox();
            buttonAdd = new Button();
            buttonList = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabelCountBook = new ToolStripStatusLabel();
            textBoxFilter = new TextBox();
            contextMenuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTitle
            // 
            listBoxTitle.ContextMenuStrip = contextMenuStrip1;
            listBoxTitle.FormattingEnabled = true;
            listBoxTitle.ItemHeight = 15;
            listBoxTitle.Location = new Point(12, 37);
            listBoxTitle.Name = "listBoxTitle";
            listBoxTitle.Size = new Size(214, 424);
            listBoxTitle.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(180, 22);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.ItemHeight = 15;
            listBoxAuthor.Location = new Point(232, 38);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(233, 424);
            listBoxAuthor.TabIndex = 1;
            // 
            // listBoxYear
            // 
            listBoxYear.FormattingEnabled = true;
            listBoxYear.ItemHeight = 15;
            listBoxYear.Location = new Point(471, 39);
            listBoxYear.Name = "listBoxYear";
            listBoxYear.Size = new Size(176, 424);
            listBoxYear.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(663, 12);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(663, 30);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(276, 23);
            textBoxTitle.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(663, 56);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(663, 74);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(276, 23);
            textBoxAuthor.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(663, 109);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 7;
            label3.Text = "Год издания";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(663, 127);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(276, 23);
            textBoxYear.TabIndex = 8;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(797, 174);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(142, 23);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить книгу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonList
            // 
            buttonList.Location = new Point(797, 203);
            buttonList.Name = "buttonList";
            buttonList.Size = new Size(142, 23);
            buttonList.TabIndex = 10;
            buttonList.Text = "Выгрузить список";
            buttonList.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelCountBook });
            statusStrip1.Location = new Point(0, 467);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(951, 22);
            statusStrip1.TabIndex = 11;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountBook
            // 
            toolStripStatusLabelCountBook.Name = "toolStripStatusLabelCountBook";
            toolStripStatusLabelCountBook.Size = new Size(103, 17);
            toolStripStatusLabelCountBook.Text = "Количество книг:";
            // 
            // textBoxFilter
            // 
            textBoxFilter.Location = new Point(12, 8);
            textBoxFilter.Name = "textBoxFilter";
            textBoxFilter.Size = new Size(635, 23);
            textBoxFilter.TabIndex = 12;
            textBoxFilter.TextChanged += textBoxFilter_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 489);
            Controls.Add(textBoxFilter);
            Controls.Add(statusStrip1);
            Controls.Add(buttonList);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxYear);
            Controls.Add(label3);
            Controls.Add(textBoxAuthor);
            Controls.Add(label2);
            Controls.Add(textBoxTitle);
            Controls.Add(label1);
            Controls.Add(listBoxYear);
            Controls.Add(listBoxAuthor);
            Controls.Add(listBoxTitle);
            Name = "Form1";
            Text = "Учет библиотечных книг";
            contextMenuStrip1.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTitle;
        private ListBox listBoxAuthor;
        private ListBox listBoxYear;
        private Label label1;
        private TextBox textBoxTitle;
        private Label label2;
        private TextBox textBoxAuthor;
        private Label label3;
        private TextBox textBoxYear;
        private Button buttonAdd;
        private Button buttonList;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCountBook;
        private TextBox textBoxFilter;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}