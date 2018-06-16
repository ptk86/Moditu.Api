using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Moditu.Api.Model
{
  public class Moditu
  {
    public string Id { get; set; }
    public ICollection<Question> Questions { get; set; }
  }
}