using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaChallenege.Models
{
    public class Comment
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }

        [ForeignKey(nameof(Post))]
        public int PostID { get; set; }

        public virtual Post Post { get; set; }
        public virtual List<Reply> Reply { get; set; }


        //[Required]

        //public Guid Author { get; set; }



        //Guid Author (using user ID)
        //(virtual list of Replies)
        //public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
        // (Foreign Key to Post via Id w/ virtual Post) 
    }
}