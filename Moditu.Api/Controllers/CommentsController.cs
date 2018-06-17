using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moditu.Api.Data;
using Moditu.Api.Model;

namespace Moditu.Api.Controllers
{
    [Route("api/comments")]
    [Produces("application/json")]
    public class CommentsController : Controller
    {
        private readonly ApplicationDbContext _ctx;

        public CommentsController(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }

        [HttpGet]
        public async Task<IActionResult> Get(int sessionId)
        {
            var comments = _ctx.Comments.OrderByDescending(c => c.Id);
            return Ok(comments);
        }

        public class CreateCromment
        {
            public string Text { get; set; }
        }

        public async Task<IActionResult> Post([FromBody]CreateCromment createCromment)
        {
            if (createCromment == null || string.IsNullOrEmpty(createCromment.Text))
            {
                return BadRequest();
            }

            var newComment = new Comment
            {
                Text = createCromment.Text
            };

            await _ctx.Comments.AddAsync(newComment);
            await _ctx.SaveChangesAsync();
            return Ok(newComment);
        }
    }
}
