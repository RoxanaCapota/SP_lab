using DessignPatternsHomework.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Models
{
    public class Image : IElement
    {
        #region Properties
        public string ImageName { get; set; }
        #endregion

        #region Constructors
        public Image()
        {

        }

        public Image(string imageName)
        {
            ImageName = imageName;
        }
        #endregion

        #region Methods
        public void Print() 
        {
            Console.WriteLine($"Image with name: {ImageName}");
        }
        #endregion
    }
}
