using DessignPatternsHomework.Interfaces;
using DessignPatternsHomework.Models;
using System;

namespace DessignPatternsHomework
{
    class Program
    {
        static void Main(string[] args)
        {

            Book discoTitanic = new Book("Disco Titanic");
            Author rpGheo = new Author("Radu Pavel Gheo");

            discoTitanic.AddAuthor(rpGheo);

            int indexChapterOne = discoTitanic.CreateChapter("Capitolul 1");
            Chapter chp1 = discoTitanic.GetChapter(indexChapterOne);

            int indexSubChapterOneOne = chp1.CreateSubChapter("Subcapitolul 1.1");
            SubChapter scOneOne = chp1.GetSubChapter(indexSubChapterOneOne);

            scOneOne.CreateNewElement(new Paragraph("Paragraph 1"));
            scOneOne.CreateNewElement(new Paragraph("Paragraph 2"));
            scOneOne.CreateNewElement(new Paragraph("Paragraph 3"));
            scOneOne.CreateNewElement(new Image("Image 1"));
            scOneOne.CreateNewElement(new Paragraph("Paragraph 4"));
            scOneOne.CreateNewElement(new Table("Table 1"));
            scOneOne.CreateNewElement(new Paragraph("Paragraph 5"));

            //scOneOne.Print();

            discoTitanic.Print();
        }
    }
}
