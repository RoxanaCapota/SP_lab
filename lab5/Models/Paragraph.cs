using DessignPatternsHomework.Interfaces;
using DessignPatternsHomework.Strategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Paragraph : IElement
    {
        #region Properties
        public string Text { get; set; }

        public IAlignStrategy Strategy { get; private set; } = null;
        #endregion

        #region Constructors
        public Paragraph()
        {

        }

        public Paragraph(string text)
        {
            Text = text;
        }
        #endregion

        #region Methods
        public void Print()
        {
            if (Strategy == null)
                Console.WriteLine($"Paragraph: {Text}");
            else
                Strategy.Render(this);
        }
        
        public void SetAlignStrategy(IAlignStrategy strategy)
        {
            Strategy = strategy;
        }
        public void Add(IElement element)
        {
            throw new NotImplementedException();
        }

        public void Remove(IElement element)
        {
            throw new NotImplementedException();
        }

        public IElement Get(int index)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
