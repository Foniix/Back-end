using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    class Book
    {
        Title title = new Title();
        Author author = new Author();
        Content content = new Content();

        public Book(string title, string author, string content)
        {
            this.title.title = title;
            this.author.author = author;
            this.content.content = content;
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
