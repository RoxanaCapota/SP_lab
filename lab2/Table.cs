using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Table : IElement
    {
        #region Properties
        public string Title { get; set; }
        #endregion

        #region Constructors
        public Table()
        {

        }

        public Table(string title)
        {
            Title = title;
        }
        #endregion

        #region Methods
        public void Print() 
        {
            Console.WriteLine($"Table with Title: {Title}");
        }
        #endregion
    }
}
