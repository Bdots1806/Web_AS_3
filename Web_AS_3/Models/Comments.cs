namespace Web_AS_3.Models
{
    public class Comments
    {
        public int commentId { get; set; }
        public string productID { get; set; }
        public string UserID { get; set; }
        public int rating { get; set; }
        public string imgurl { get; set; }
        public string text { get; set; }
    }
}
