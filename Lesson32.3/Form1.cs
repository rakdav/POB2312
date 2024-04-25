using System.Runtime.Versioning;

namespace Lesson32._3
{
    public partial class Form1 : Form
    {
        private double Price;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (lbxMaterial.SelectedIndex)
                {
                    case 0:
                        Calculate("aluminium.jpg", 300);
                        break;
                    case 1:
                        Calculate("plastik.jpg", 150);
                        break;
                    case 2:
                        Calculate("wood.jpg", 120);
                        break;
                    case 3:
                        Calculate("bambuk.jpg", 180);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click()
        {
            lbResult.Text = (double.Parse(tbxWidth.Text) * double.Parse(txbHeight.Text) * Price).ToString("c");
        }
        private void Calculate(string path, double price)
        {
            pbxMaterial.Image = Image.FromFile(path);
            Price = price;
            button1_Click();
        }
    }
}