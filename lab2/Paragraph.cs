using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Paragraph : IElement
    {
        public string Text { get; set; }

        #region Constructors
        public Paragraph()
        {

        }

        public Paragraph(string text)
        {
            Text = text;
        }
        #endregion

        public void Print()
        {
            Console.WriteLine($"Paragraph: {Text}");
        }
    }
}
