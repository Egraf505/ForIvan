using System;
using System.Collections.Generic;
using System.Text;

namespace TestListView
{
    public class Book
    {
        private string _name;
        public string Name { get { return _name; }}

        private string _autor;
        public string Autor { get { return _autor; }}

        public Book(string name, string autor)
        {
            _name = name;
            _autor = autor; 
        }

        public override string ToString()
        {
            return $"Название книги: {_name} Автор: {_autor}";
        }
    }
}
