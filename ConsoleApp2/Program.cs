using System;

namespace ConsoleApp2
{
    class Program
    {
        class Book
        {
            public string nameBook;

            public void Show()
            {
                Console.Write($"Название киги: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(nameBook);
                Console.ResetColor();
            }

        }

        class Title 
        {
            public string nameTitle;

            public void Show()
            {
                Console.Write($"Заголовок: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(nameTitle);
                Console.ResetColor();
            }

        }
       
        class Author
        {
            
            public string nameAuthor;

            public void Show()
            {
                Console.Write($"Автор: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(nameAuthor);
                Console.ResetColor();
            }

        }
        
        class Content
        {
            public string content;

            public void Show()
            {
                Console.Write($"Содержание: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(content);
                Console.ResetColor();
            }

        }
        static void Main(string[] args)
        {
            Book book = new Book();
            Title title = new Title();
            Author author = new Author();
            Content content = new Content();

            Console.WriteLine("Введите название книги: ");
            book.nameBook = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите заголовку: ");
            title.nameTitle = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите имя автора: ");
            author.nameAuthor = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Введите содержание книги: ");
            content.content = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            book.Show();
            title.Show();
            author.Show();
            content.Show();
        }
    }
}
