namespace BlazerWebApp.Models
{
    public class ContentObject
    {
        public string Description { get; set; }
        public List<string> Includes { get; set; }
        public List<ProgramDetailObject> ProgramDetails { get; set; }
    }
}
