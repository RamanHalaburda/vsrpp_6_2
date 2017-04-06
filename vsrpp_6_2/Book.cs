using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vsrpp_6_2
{
    class Book
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

        public String title {get; set; }
        public String author { get; set; }
        public String publishingHouse { get; set; }

        public Book()
        { 
            this.title = "";
            this.author = "";
            this.publishingHouse = "";
        }

        public Book(String _t, String _a, String _ph)
        {
            this.title = _t;
            this.author = _a;
            this.publishingHouse = _ph;
        }        
    }
}
