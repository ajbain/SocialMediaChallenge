using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaChallenege.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "This is too short of a title!")]
        public string Title { get; set; }


        [Required]
        public string Text { get; set; }

        public int CommentID { get; set; }


        [ForeignKey(nameof(CommentID))]
        public virtual Comment Comment { get; set; }

        //[ForeignKey(nameof(ApplicationUser.Email))]
        //public string Author { get; set; }
    }
}