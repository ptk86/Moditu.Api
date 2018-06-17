namespace Moditu.Api.Model
{
  public class Comment
  {
    public int Id { get; set; }
    public string Text { get; set; }
    public int LikeCount { get; set; }
    public bool IsDisDistinguished { get; set; }
    
  }

    public class UserComment
    {
        public string UserId { get; set; }
        public int CommentId { get; set; }
        public bool IsLiked { get; set; }
    }
}
