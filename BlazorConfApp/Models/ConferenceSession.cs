namespace BlazorConfApp.Models
{
    public class ConferenceSession
    {
        public int Id {  get; set; }
        public string? Title { get; set; }
        public string? Speaker { get; set; }
        public string? Abstract { get; set; }
        public string? TechnicalDomain { get; set; }
        public int Duration { get; set; }
        public bool IsPublished { get; set; }
    }
}
