namespace BlazerWebApp.Models
{
    public class CourseCardModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string ImageUri { get; set; }
        public string ImageHeaderUri { get; set; }
        public bool IsBestSeller { get; set; }
        public bool IsDigital { get; set; }
        public List<string> Categories { get; set; }
        public string Subtitle { get; set; }
        public int StarRating { get; set; }
        public string Reviews { get; set; }
        public string LikesPercent { get; set; }
        public string Likes { get; set; }
        public string Duration { get; set; }
        public List<AuthorObject> Authors { get; set; }
        public PricesObject Prices { get; set; }
        public ContentObject Content { get; set; }
    }
}
