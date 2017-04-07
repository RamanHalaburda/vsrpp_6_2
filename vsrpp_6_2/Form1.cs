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
        
        BookList bl = new BookList();

        private void Form1_Load(object sender, EventArgs e)
        {
            Book item1 = new Book("encyclopedy","dal","moscow");
            Book item2 = new Book("perfect code", "macconel", "san francisko");
            Book item3 = new Book("sherlok holmes", "jack london", "berminghem");
            Book item4 = new Book("skazki", "barto", "paris");
            bl.Add(item1, item2, item3, item4);

            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                Book item = new Book(textBox1.Text, textBox2.Text, textBox3.Text);
                bl.Add(item);
            }
            else { throw new Exception("Some fialds are empty!"); }
        }        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StartSort sortDelegateItem;
            sortDelegateItem = new StartSort(bl.Sort);
            sortDelegateItem((UInt16)comboBox1.SelectedIndex);

            for (int i = 0; i < bl.listBook.Count; ++i)
            {
                listBox1.Items.Add(bl.listBook[i].ToString());
            }            
        }
    }
}
