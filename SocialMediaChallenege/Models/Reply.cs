using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SocialMediaChallenege.Models
{
    public class Reply
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ReplyComment { get; set; }

        [ForeignKey(nameof(Comment))]
        public int CommentID { get; set; }

        public virtual Comment Comment { get; set; }
    }
}