namespace FredsBoats.Web.Models
{
    public class Comment {
        public int CommentId {get; set;}
        public string Content {get; set;} = string.Empty;
        public string Author {get; set;} = string.Empty;
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public int BoatId {get; set;}
        public Boat? Boat {get; set;}
    }
}