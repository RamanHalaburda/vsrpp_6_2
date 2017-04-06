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
    class BookList
    {
        private List<Book> listBook;

        public BookList() { listBook = new List<Book>(); }

        public void Sort(UInt16 _op)        {
            List<Book> sortedBook = new List<Book>();            switch(_op)            {                case 1:                    // sort by title
                    
                    //listBook.Sort((x, y) => x.title.CompareTo(y.title));
                    
                    /*
                    listBook.Sort( (x, y) =>
                        x == null ? (y == null ? 0 : -1)
                        : (y == null ? 1 : x.title.CompareTo(y.title))                        );                    */
                    
                    //var newList = listBook.Sort(n => n.title);
                                        //List<Book> sortedList = listBook.OrderBy(o => o.title).ToList();                    var temp1 = from o in listBook orderby o.title select o;
                    sortedBook = temp1.ToList();                    break;                case 2:                    // sort by author                    var temp2 = from o in listBook orderby o.title select o;
                    sortedBook = temp2.ToList();                    break;                case 3:                    // sort by publishingHouse                    var temp3 = from o in listBook orderby o.title select o;
                    sortedBook = temp3.ToList();                    break;                        }        }

    }
}
