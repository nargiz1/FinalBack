using FinalProject.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DTOs
{
    public class CommentDTO
    {
        [Required, MaxLength(1000)]
        public string Text { get; set; }
        public int PostId { get; set; }
        public int? CommentId { get; set; } //in case you are answering the comment, otherwise null

    }
}
