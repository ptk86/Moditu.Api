using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moditu.Api.Data;
using Moditu.Api.Model;

namespace Moditu.Api.Controllers
{
    [Route("api/questions")]
    public class QuestionController : Controller
    {
        public QuestionController()
        {

        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {

            return Ok(new List<Question>
            {
                new Question
                {
                    Id = 1,
                    IsDisDistinguished = false,
                    LikeCount = 0,
                    Text = "aaaa"
                },
                new Question
                {
                    Id = 3,
                    IsDisDistinguished = false,
                    LikeCount = 0,
                    Text = "bbb"
                },
                new Question
                {
                    Id = 3,
                    IsDisDistinguished = false,
                    LikeCount = 0,
                    Text = "ccc"
                }
            });
        }
    }
}
