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
    public class PostController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // GET: api/Post

        [HttpPost]
        public async Task<IHttpActionResult> Create(Post post)
        {
            if (ModelState.IsValid)
            {
               // Comment comment = await _context.Comment.FindAsync(post.Comment);
                //if (comment == null)
                //{
                //    return post.CommentID;
                //        //("No comments on this post yet");
                //}

                _context.Post.Add(post);
                await _context.SaveChangesAsync();
                return Ok();

            }
            return BadRequest(ModelState);
        }
        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            List<Post> posts = await _context.Post.ToListAsync();
            return Ok(posts);
        }
        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Post post = await _context.Post.FindAsync(id);
            if (post != null)
            {
                return Ok(post); // 200
            }
            return NotFound(); // 404
        }
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/Post/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Post
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Post/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Post/5
        //public void Delete(int id)
        //{
        //}
    }
}
