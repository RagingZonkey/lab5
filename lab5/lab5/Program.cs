using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{

    public interface IPaper
    {
        int Pages_Amount { get; set; }
        bool Firm_Binding();
        string Price(); 
    }

    // Задание 7
    public class Printer
    {
        public string IAmPrinting(IPaper InterfaceObJect)
        {

            return InterfaceObJect.ToString();
        }
    }

    public abstract class Publishing_House
    {

        public int Pages_Amount { get; set; }
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public abstract string Price();
    }

    public class Print_Edition : Publishing_House, IPaper
    {
        public Print_Edition()
        {
            string Name;
            Console.WriteLine("Введите имя автора: ");
            Name = Console.ReadLine();
            Author author = new Author(Name);

        }
        public override string ToString()
        {
            string override_message = "Print_Edition Override Method";
            return override_message;
        }

        public override string Price()
        {
            return "Цена печатных изданий нашего издательства варьируется в промежутке от 5 до 50 рублей";

        }

        string IPaper.Price()
        {
            return "Переопределенный метод интерфейса, вызванный в классе Train";
        }

        public bool Firm_Binding()
        {
            return true;
        }
    }


    public class Magazine : Print_Edition, IPaper
    {

        public override string ToString()
        {
            string override_message = "Magazine Override Method";
            return override_message;
        }

    }

    public class Book : Print_Edition, IPaper
    {
        public override string ToString()
        {
            string override_message = "Book Override Method";
            return override_message;
        }
    }

    public class TextBook : Print_Edition, IPaper
    {
        public override string ToString()
        {
            string override_message = "TextBook Override Method";
            return override_message;
        }
    }

    public abstract class Person
    {
        public string Name;
        
        public override string ToString()
        {
            return base.ToString();
        }

        public int Age { get; set; }
    
    }

    public sealed class Author : Person
    {
        public Author(string Name)
        {
            this.Name = Name;
        }
        public int Age 
        {
            get
            {
                return Age;
            }

            set
            {
                int age = 36;
                Age = age;
            }
        }
        public override string ToString()
        {
            string override_message = "Author Override Method";
            return override_message;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Print_Edition PE = new Print_Edition();
            Magazine magazine = new Magazine();
            Book book = new Book();
            TextBook TB = new TextBook();
            Console.WriteLine(PE.ToString());
            Console.WriteLine(PE.GetHashCode());
            Console.WriteLine(PE.Equals(PE));
            Console.WriteLine("PE is Print_Edition: " + (PE is Print_Edition));
            Console.WriteLine("magazine is Magazine: " + (magazine is Magazine));
            Console.WriteLine("book is Print_Edition: " + (book is Print_Edition));


            // Задание 7
            List<IPaper> Bookshop = new List<IPaper>();
            Bookshop.Add(new Print_Edition());
            Bookshop.Add(new Magazine());
            Bookshop.Add(new Book());
            Bookshop.Add(new TextBook());
            

            Printer printer = new Printer();
            foreach (IPaper Obj in Bookshop)
            {
                Console.WriteLine(printer.IAmPrinting(Obj));
            }
        }
    }
}
