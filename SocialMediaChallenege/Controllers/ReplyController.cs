using SocialMediaChallenege.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace SocialMediaChallenege.Controllers
{
    public class ReplyController : ApiController
    {
        // GET: Restaurant
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // POST
        [HttpPost]
        public async Task<IHttpActionResult> Post(Reply model)
        {
            if (ModelState.IsValid)
            {
                _context.Reply.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Reply> replies = await _context.Reply.ToListAsync();
            return Ok(replies);
        }
    }
}
