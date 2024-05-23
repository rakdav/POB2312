namespace Lesson38._1
{
    public partial class Form1 : Form
    {
        private Library library;
        private List<Book> books;
        public Form1()
        {
            InitializeComponent();
            library = new Library();
            books = library.getBooks();
            UpdateForm();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book(textBoxTitle.Text, textBoxAuthor.Text,
                int.Parse(textBoxYear.Text));
            library.Add(book);
            UpdateForm();
        }
        private void UpdateForm()
        {
            listBoxTitle.Items.Clear();
            listBoxAuthor.Items.Clear();
            listBoxYear.Items.Clear();
            foreach (Book book in books)
            {
                listBoxTitle.Items.Add(book.getTitle());
                listBoxAuthor.Items.Add(book.getAuthor());
                listBoxYear.Items.Add(book.getYear());
            }
            textBoxAuthor.Text = "";
            textBoxTitle.Text = "";
            textBoxYear.Text = "";
            toolStripStatusLabelCountBook.Text = " ÓÎË˜ÂÒÚ‚Ó ÍÌË„:" + library.getCount().ToString();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            if (textBoxFilter.Text.Length != 0)
            {
                books = library.getBookByCriteria(textBoxFilter.Text).ToList();
            }
            else
            {
                books = library.getBooks();
            }
            UpdateForm();
        }

        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title = listBoxTitle.SelectedItem.ToString()!;
            library.Remove(title);
            UpdateForm();
        }
    }
}