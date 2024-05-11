namespace Lesson36
{
    public partial class Form1 : Form
    {
        private List<MyTask> myTasks;
        public Form1()
        {
            InitializeComponent();
            myTasks = new List<MyTask>();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            AddTask(tbTask.Text, dtpTaskDate.Value, lbxPririty.SelectedItem.ToString()!);
        }
        private void ClearForm()
        {
            tbTask.Text = "";
            dtpTaskDate.Value = DateTime.Now;
            lbxPririty.SelectedIndex = -1;
        }
        private void AddTask(string task, DateTime dt, string p)
        {
            MyTask myTask = new MyTask(task, dt, p);
            myTasks.Add(myTask);
            lbxTask.Items.Add(tbTask.Text);
            lbxTaskDate.Items.Add(dtpTaskDate.Value);
            lbxTaskPririty.Items.Add(lbxPririty.SelectedItem.ToString()!);
            ClearForm();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            int index = lbxTask.SelectedIndex;
            myTasks.RemoveAt(index);
            lbxTask.Items.RemoveAt(index);
            lbxTaskDate.Items.RemoveAt(index);
            lbxTaskPririty.Items.RemoveAt(index);
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            string selected = lbxTask.SelectedItem.ToString()!;
            MyTask currentTask = myTasks.FirstOrDefault(p=>p.getTaskName()==selected)!;
            int index = myTasks.IndexOf(currentTask);
            currentTask.setTaskName(tbTask.Text);
            currentTask.setPriority(lbxPririty.Text);
            currentTask.setTaskDateTime(dtpTaskDate.Value);
            lbxTask.Items[index]= currentTask.getTaskName();
            lbxTaskDate.Items[index] = currentTask.getTaskDateTime();
            lbxTaskPririty.Items[index] = currentTask.getPriority();
        }
        private void lbxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxTask.SelectedIndex != -1)
            {
                int index = lbxTask.SelectedIndex;
                MyTask currentTask = myTasks[index];
                tbTask.Text = currentTask.getTaskName();
                lbxPririty.Text = currentTask.getPriority();
                dtpTaskDate.Value = currentTask.getTaskDateTime();
            }
        }
    }
}