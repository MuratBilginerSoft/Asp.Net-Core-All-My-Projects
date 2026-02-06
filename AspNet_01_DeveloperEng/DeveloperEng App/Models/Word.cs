namespace DeveloperEng_App.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string? WordName { get; set; }
        public string? Meaning { get; set; }
        public string? Example { get; set; }
        public string? Synonyms { get; set; }
        public string? Antonyms { get; set; }
    }
}
