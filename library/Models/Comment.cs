using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public string Text { get; set; }
    }
}