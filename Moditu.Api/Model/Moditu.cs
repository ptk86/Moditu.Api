using System.Collections.Generic;

namespace Moditu.Api.Model
{
  public class Moditu
  {
    public string Id { get; set; }
    public ICollection<string> Questions { get; set; }
  }
}