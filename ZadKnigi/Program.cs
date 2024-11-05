using System.Collections;
using System.Runtime.InteropServices;

namespace ZadKnigi
{
    internal class Program
    {
        static ArrayList list = new ArrayList() { "Бай Ганьо", "Алеко Константинов", "Под Игото", "Иван Вазов" };
        static void Main(string[] args)
        {

            string answer = null;
            do
            {
                Console.WriteLine("====================");
                Console.WriteLine("Add a book - add\nRemove a book - remove\nSearch a book by title - search\nPrint all books in library - print");
                answer = Console.ReadLine().ToLower();
                Console.WriteLine("====================");
                switch (answer)
                {
                    case "add":
                        AddBook();
                        break;
                    case "remove":
                        RemoveBookByTitle();
                        break;
                    case "search":
                        SearchBookByTitle();
                        break;
                    case "print":
                        PrintAllBooks();
                        break;
                }
                Console.WriteLine("====================");
                Console.WriteLine("Would you like to do something else?");
                answer = Console.ReadLine().ToLower();

            } while (answer != "no");
        }
        static void AddBook()
        {
            Console.WriteLine("Whats the title of the book");
            string answer = Console.ReadLine();
            list.Add(answer);
            Console.WriteLine("Whats the name of the author");
            answer = Console.ReadLine();
            list.Add(answer);
        }
        static void RemoveBookByTitle()
        {
            Console.WriteLine("Whats the title of the book you want to remove");
            string answer = Console.ReadLine();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (string.Compare(answer, (string)list[i], true) == 0)
                {
                    list.RemoveAt(i);
                    list.RemoveAt(i);
                }
            }
        }
        static void SearchBookByTitle()
        {
            Console.WriteLine("Whats the title of the book you want to find");
            string answer = Console.ReadLine();
            for (int i  = 0; i  < list.Count; i+=2)
            {
                if (string.Compare(answer, (string)list[i], true) == 0)
                {
                    Console.WriteLine($"Book {list[i]}(Author:{list[i+1]}) found, at index #{i}");
                    return;
                }
            }
            Console.WriteLine("Book not found");
        }
        static void PrintAllBooks()
        {
            for (int i = 0; i < list.Count; i += 2)
            {
                Console.WriteLine($"\"{list[i]}\" from {list[i + 1]}");
            }
        }
    }
}
