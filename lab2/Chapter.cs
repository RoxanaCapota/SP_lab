using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DessignPatternsHomework.Models
{
    public class Chapter
    {
        public string Name { get; set; }
        public List<SubChapter> SubChapters { get; set; }

        #region Constructors
        public Chapter()
        {
            SubChapters = new List<SubChapter>();
        }

        public Chapter(string chapterName)
        {
            SubChapters = new List<SubChapter>();
            Name = chapterName;
        }
        #endregion


        public int CreateSubChapter(string subChapterName)
        {
            SubChapter subChapter = new SubChapter(subChapterName);

            SubChapters.Add(subChapter);

            return SubChapters.IndexOf(subChapter);

        }

        public SubChapter GetSubChapter(int index)
        {
            return SubChapters.ElementAt(index);
        }
        public void Print() { }
    }
}
