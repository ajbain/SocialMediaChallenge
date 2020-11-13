using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaChallenege.Models
{
    public class Like
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        public string LikedPost { get; set; }

        //[ForeignKey("User")]
        public Guid Author { get; set; }
       // public virtual ApplicationUser User { get; set; }


    }
}