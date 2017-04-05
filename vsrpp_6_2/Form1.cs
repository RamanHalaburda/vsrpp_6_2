using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vsrpp_6_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
