using PracticeConsoleApp.Exceptions;
using PracticeConsoleApp.Models;
using PracticeConsoleApp.Utilits;

namespace PracticeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> languages = new();
            languages.Add(1910, "c++");
            languages.Add(1905, "python");
            languages.Add(1940, "c#");
            languages.Add(1900, "c");

            var sortedList = languages.OrderBy(x => x.Key);
            foreach (var item in sortedList)
            {
                Console.WriteLine(item.Value);
            }

            List<Libary> libaries = new List<Libary>();
            List<Book> books = new List<Book>();
            List<Category> categories = new List<Category>();
        restart:
            Console.WriteLine("1-Yeni kitabxana yarat");
            Console.WriteLine("2-Yeni kategoriya yarat");
            Console.WriteLine("3-Yeni kitab yarat");
            Console.WriteLine("4-Kitabxanaya daxil ol");
            Console.WriteLine("0-Exit");

            string result = Console.ReadLine();

            try
            {
                switch (result)
                {
                    case "1":
                        Console.Clear();
                        CreateLibary(libaries);
                        break;
                    case "2":
                        Console.Clear();
                        CreateCategory(categories);
                        break;
                    case "3":
                        Console.Clear();
                        CreateBook(books, categories);
                        break;
                    case "4":
                        Console.Clear();
                        LoginLibary(libaries, books);
                        break;
                    case "0":
                        return;

                    default: throw new InvalidInputException();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            goto restart;



        }


        public static void CreateLibary(List<Libary> libaries)
        {
            Console.WriteLine("Libary adi daxil edin");
            string name = Console.ReadLine();
            name = name.Capitalize();
            if (string.IsNullOrWhiteSpace(name))
                throw new InvalidInputException();
            Libary libary = new Libary(name);
            libaries.Add(libary);
            Console.WriteLine("Libary added");
        }

        public static void LoginLibary(List<Libary> libaries, List<Book> books)
        {
            var libary = SelectLibary(libaries);
            Console.WriteLine("1-Kitablari goster");
            Console.WriteLine("2-kitab elave et");
            bool isParse = int.TryParse(Console.ReadLine(), out int result);
            if (!isParse)
            {
                throw new InvalidInputException();
            }
            if (result == 1)
            {
                libary.ListAllBooks();
            }
            else if (result == 2)
            {
                AddBookToLibary(libary, books);
            }
            else
            {
                throw new InvalidInputException();
            }
        }
        public static Libary SelectLibary(List<Libary> libaries)
        {

            Console.WriteLine("Libary id daxil edin \n");
            foreach (Libary libary in libaries)
            {
                Console.WriteLine(libary);
            }
            bool isParse = int.TryParse(Console.ReadLine(), out int id);
            if (!isParse)
            {
                throw new InvalidInputException();
            }
            foreach (var item in libaries)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new LibaryNotFoundException();


        }

        public static void AddBookToLibary(Libary libary, List<Book> books)
        {

            var book = SelectBook(books);
    

            libary.AddBook(book);

        }

        public static void CreateBook(List<Book> books, List<Category> categories)
        {
            Console.WriteLine("Kitab adi daxil edin");
            string name = Console.ReadLine();
            name = name.Capitalize();
            Console.WriteLine("Author kimdir");
            string author = Console.ReadLine();
            author = author.Capitalize();

            if (String.IsNullOrWhiteSpace(author) || String.IsNullOrWhiteSpace(name))
                throw new InvalidInputException();
            var category = selectCategory(categories);
            Book book = new(name, author, category);
            books.Add(book);
            Console.WriteLine("kitab elave olundu");


        }
        public static void CreateCategory(List<Category> categories)
        {
            Console.WriteLine("Ad daxil edin");
            string name = Console.ReadLine();
            name = name.Capitalize();
            if (
            String.IsNullOrWhiteSpace(name))
                throw new InvalidInputException();
                Category category = new Category(name);
            categories.Add(category);
            Console.WriteLine("Category elave olundu");



        }
        public static Book SelectBook(List<Book> books)
        {
            Console.WriteLine("Book id daxil edin \n");
            foreach (var item in books)
            {
                Console.WriteLine(item);
            }
            bool isParse = int.TryParse(Console.ReadLine(), out int id);
            if (!isParse)
            {
                throw new InvalidInputException();
            }
            foreach (var item in books)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new BookNotFoundException();
        }
        public static Category selectCategory(List<Category> categories)
        {
            Console.WriteLine("Id daxil edin \n");
            foreach (var item in categories)
            {
                Console.WriteLine(item);
            }
            bool isParse = int.TryParse(Console.ReadLine(), out int id);
            if (!isParse)
            {
                throw new InvalidInputException();
            }
            foreach (var item in categories)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }
            throw new CategoryNotFoundException();

        }
    }
}