namespace Lesson35._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Genaration genaration = new Genaration(int.Parse(tbFrom.Text),
                    int.Parse(tbUntil.Text));
                tbResult.Text = genaration.getNumber().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}