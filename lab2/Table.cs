using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Table : IElement
    {
        public string Title { get; set; }

        #region Constructors
        public Table()
        {

        }

        public Table(string title)
        {
            Title = title;
        }
        #endregion
        public void Print() 
        {
            Console.WriteLine($"Table with Title: {Title}");
        }
    }
}
