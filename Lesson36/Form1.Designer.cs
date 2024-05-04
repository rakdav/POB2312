namespace Lesson36
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
            lbxTask = new ListBox();
            label2 = new Label();
            lbxTaskDate = new ListBox();
            label3 = new Label();
            lbxTaskPririty = new ListBox();
            label4 = new Label();
            lbxPririty = new ListBox();
            label5 = new Label();
            dtpTaskDate = new DateTimePicker();
            tbTask = new TextBox();
            label6 = new Label();
            btAdd = new Button();
            btDelete = new Button();
            btEdit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 0;
            label1.Text = "Задача";
            // 
            // lbxTask
            // 
            lbxTask.FormattingEnabled = true;
            lbxTask.ItemHeight = 25;
            lbxTask.Location = new Point(13, 43);
            lbxTask.Name = "lbxTask";
            lbxTask.Size = new Size(206, 354);
            lbxTask.TabIndex = 1;
            lbxTask.SelectedIndexChanged += lbxTask_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(238, 14);
            label2.Name = "label2";
            label2.Size = new Size(128, 25);
            label2.TabIndex = 2;
            label2.Text = "Дата и время";
            // 
            // lbxTaskDate
            // 
            lbxTaskDate.FormattingEnabled = true;
            lbxTaskDate.ItemHeight = 25;
            lbxTaskDate.Location = new Point(238, 42);
            lbxTaskDate.Name = "lbxTaskDate";
            lbxTaskDate.Size = new Size(228, 354);
            lbxTaskDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(482, 15);
            label3.Name = "label3";
            label3.Size = new Size(107, 25);
            label3.TabIndex = 4;
            label3.Text = "Приоритет";
            // 
            // lbxTaskPririty
            // 
            lbxTaskPririty.FormattingEnabled = true;
            lbxTaskPririty.ItemHeight = 25;
            lbxTaskPririty.Location = new Point(482, 43);
            lbxTaskPririty.Name = "lbxTaskPririty";
            lbxTaskPririty.Size = new Size(214, 354);
            lbxTaskPririty.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 15);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 6;
            label4.Text = "Укажите приоритет";
            // 
            // lbxPririty
            // 
            lbxPririty.FormattingEnabled = true;
            lbxPririty.ItemHeight = 25;
            lbxPririty.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            lbxPririty.Location = new Point(714, 43);
            lbxPririty.Name = "lbxPririty";
            lbxPririty.Size = new Size(238, 104);
            lbxPririty.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(714, 159);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 8;
            label5.Text = "Укажите дату и время";
            // 
            // dtpTaskDate
            // 
            dtpTaskDate.Location = new Point(716, 187);
            dtpTaskDate.Name = "dtpTaskDate";
            dtpTaskDate.Size = new Size(236, 32);
            dtpTaskDate.TabIndex = 9;
            // 
            // tbTask
            // 
            tbTask.Location = new Point(13, 437);
            tbTask.Name = "tbTask";
            tbTask.Size = new Size(683, 32);
            tbTask.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 409);
            label6.Name = "label6";
            label6.Size = new Size(199, 25);
            label6.TabIndex = 11;
            label6.Text = "Укажите текст задачи";
            // 
            // btAdd
            // 
            btAdd.Location = new Point(716, 225);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(236, 82);
            btAdd.TabIndex = 12;
            btAdd.Text = "Добавить";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(716, 313);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(236, 84);
            btDelete.TabIndex = 13;
            btDelete.Text = "Удалить";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(716, 403);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(236, 66);
            btEdit.TabIndex = 14;
            btEdit.Text = "Перезаписать";
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 490);
            Controls.Add(btEdit);
            Controls.Add(btDelete);
            Controls.Add(btAdd);
            Controls.Add(label6);
            Controls.Add(tbTask);
            Controls.Add(dtpTaskDate);
            Controls.Add(label5);
            Controls.Add(lbxPririty);
            Controls.Add(label4);
            Controls.Add(lbxTaskPririty);
            Controls.Add(label3);
            Controls.Add(lbxTaskDate);
            Controls.Add(label2);
            Controls.Add(lbxTask);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Планировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lbxTask;
        private Label label2;
        private ListBox lbxTaskDate;
        private Label label3;
        private ListBox lbxTaskPririty;
        private Label label4;
        private ListBox lbxPririty;
        private Label label5;
        private DateTimePicker dtpTaskDate;
        private TextBox tbTask;
        private Label label6;
        private Button btAdd;
        private Button btDelete;
        private Button btEdit;
    }
}