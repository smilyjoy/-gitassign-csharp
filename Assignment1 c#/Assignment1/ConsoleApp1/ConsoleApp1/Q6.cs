﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Q6
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.book_id = 234;
            b.title = "Comic";
            b.price = 90;

            Console.WriteLine("Details of the book");
            Console.WriteLine("Id of the book:" + b.book_id);
            Console.WriteLine("title of the book:" + b.title);
            Console.WriteLine("price of the book:" + b.price);
            //Console.WriteLine("type of the book");
            Console.ReadKey();

        }
        enum bookType
        {
            Mazagine,
            Novels,
            Referenebook,
            Misellonories

        }

        public struct Book
        {
            public int book_id;
            public string title;
            public int price;

        }

    }
}
