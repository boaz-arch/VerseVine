namespace VerseVine.Models
{
    public class Topics
    {
        public int id { get; set; }
        public string topic { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public int Verse { get; set; }

        public Topics()
        {

        }

    }
}