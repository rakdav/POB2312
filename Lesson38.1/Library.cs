using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson38._1
{
    internal class Library
    {
        private List<Book> list;
        public Library()
        {
            list = new List<Book>();
        }
        public void Add(Book book)
        {
            list.Add(book);
        }
        public void Remove(string title)
        {
            Book book = list.FirstOrDefault(p=>p.getTitle()==title)!;
            list.Remove(book);
        }
        public int getCount() => list.Count;
        public List<Book> getBooks() => list;
    }
}
