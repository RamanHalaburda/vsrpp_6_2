﻿using System;
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
        
        //delegate void myDel(int x);
        private void Form1_Load(object sender, EventArgs e)
        {
            Book b = new Book();
            StartSort sort;
            BookList bl = new BookList();
            sort = new StartSort(bl.Sort);            
            
            sort(1);
            // must print;

            sort(2);
            // must print;

            sort(3);
            // must print;


            //myDel md = new myDel(start);
            //md(10);
        }
        /*
        static void start(int x)
        { x = 10; }
        static void stop(int x)
        { x = 0; }*/
    }
}
