using DessignPatternsHomework.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DessignPatternsHomework
{
    public class Book
    {
        #region Properties
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public List<Chapter> Chapters { get; set; }
        #endregion

        #region Constructors
        public Book()
        {
            Authors = new List<Author>();
            Chapters = new List<Chapter>();
        }

        public Book(string title)
        {
            Authors = new List<Author>();
            Chapters = new List<Chapter>();
            Title = title;
        }
        #endregion

        #region Methods
        public void AddAuthor(Author author)
        {
            Authors.Add(author);
        }

        public int CreateChapter(string chapterName)
        {
            Chapter chapter = new Chapter(chapterName);

            Chapters.Add(chapter);

            return Chapters.IndexOf(chapter);
        }

        public Chapter GetChapter(int index)
        {
            return Chapters.ElementAt(index);
        }

        public void Print() 
        {
            Console.WriteLine($"Book: {Title}");
            
            Console.WriteLine("Authors:");
            Authors.ForEach(author => author.Print());
            
            Console.WriteLine("Chapters:");
            Chapters.ForEach(chapter => chapter.Print());
        }

        #endregion
    }
}
