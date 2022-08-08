using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject.DTOs
{
    public class UpdateGroupChatDTO
    {
        public int Id { get; set; }
        public IFormFile ImageFile { get; set; }
    }
}
