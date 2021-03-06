﻿using Microsoft.AspNet.Identity;
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
    public class CommentController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        // POST
        [HttpPost]
        public async Task<IHttpActionResult> Post(Comment model)
        {
            List<Reply> replies = await _context.Reply.ToListAsync();

            if (ModelState.IsValid)
            {
                var userId = Guid.Parse(User.Identity.GetUserId());
                model.AuthorId = userId;
                _context.Comment.Add(model);
                await _context.SaveChangesAsync();

                return Ok();
            }

            return BadRequest(ModelState); // 400
        }

        // GET ALL
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            List<Comment> comments = await _context.Comment.ToListAsync();


            /*  .Select(r => new Comment()
              {
                  Id = r.Id,
                  Text = r.Text,
                 /// CleanlinessScore = r.CleanlinessScore,
                 // EnvironmentScore = r.EnvironmentScore,
                 // CommentId = r.CommentId,
                 // CommentName = r.Comment.Name,
              })*/
            return Ok(comments);
        }
        // GET BY ID
        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            Comment comment = await _context.Comment.FindAsync(id);
            if (comment != null)
            {
                return Ok(comment); // 200
            }
            return NotFound(); // 404
        }

        // GET Ratings by comment
        /* [HttpGet]
         public async Task<IHttpActionResult> Get(int id)
         {
             List<Rating> ratings = await _context.Ratings.Where(
                 r => r.CommentId == id
                 ).ToListAsync();
             return Ok(ratings);
         }*/
    }
}
