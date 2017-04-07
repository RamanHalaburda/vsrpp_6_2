using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsrpp_6_2
{
    /*
        2. Написать делегат, с помощью которого реализуется сортировка
        книг.
        Книга представляет собой класс с полями Название, Автор,
        Издательство и конструктором.
        Создать класс, являющийся контейнером для множества книг (массив
        книг). В этом классе предусмотреть метод сортировки книг. Критерий
        сортировки определяется экземпляром делегата, который передается методу
        в качестве параметра. Каждый экземпляр делегата должен сравнивать книги
        по какому-то одному полю: названию, автору, издательству.
    */
    public delegate void StartSort(UInt16 _op);

    public class BookList
    {
        public List<Book> listBook { get; set; }

        public BookList() { listBook = new List<Book>(); }
                
        public void Add(params Book[] _book)
        {
            foreach (Book o in _book)
            {
                listBook.Add(o);
            }            
        }

        public void Sort(UInt16 _op)
        {
            List<Book> sortedBook = new List<Book>();
            switch(_op)
            {
                case 0:
                    // sort by title
                    listBook.Sort(delegate(Book b1, Book b2) { return b1.title.CompareTo(b2.title); });
                    break;
                case 1:
                    // sort by author
                    listBook.Sort(delegate(Book b1, Book b2) { return b1.author.CompareTo(b2.author); });
                    break;
                case 2:
                    // sort by publishingHouse
                    listBook.Sort(delegate(Book b1, Book b2) { return b1.publishingHouse.CompareTo(b2.publishingHouse); });
                    break;            
            }
        }
    }
}
