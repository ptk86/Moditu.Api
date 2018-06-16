namespace Moditu.Api.Model
{
  public class Question
  {
    public int Id { get; set; }
    public string Text { get; set; }
    public int LikeCount { get; set; }
    public bool IsDisDistinguished { get; set; }
  }
}
