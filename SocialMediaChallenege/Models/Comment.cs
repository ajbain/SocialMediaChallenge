using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        //[Required]

        //public Guid Author { get; set; }



        //Guid Author (using user ID)
        //(virtual list of Replies)
        //public virtual List<Rating> Ratings { get; set; } = new List<Rating>();
        // (Foreign Key to Post via Id w/ virtual Post) 
    }
}