using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Image : IElement
    {
        public string ImageName { get; set; }

        #region Constructors
        public Image()
        {

        }

        public Image(string imageName)
        {
            ImageName = imageName;
        }
        #endregion
        public void Print() 
        {
            Console.WriteLine($"Image with name: {ImageName}");
        }
    }
}
