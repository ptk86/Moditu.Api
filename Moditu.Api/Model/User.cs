using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moditu.Api.Model
{
  public class User
  {
    public string Id { get; set; }
    public string Name { get; set; }
    public ICollection<Moditu> Moditus { get; set; }
  }
}
