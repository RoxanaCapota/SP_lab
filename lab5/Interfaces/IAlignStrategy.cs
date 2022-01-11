using DessignPatternsHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatternsHomework.Strategy
{
    public interface IAlignStrategy
    {
        void Render(Paragraph paragraph);
    }
}
