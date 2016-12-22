using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace library.Models
{
    public class Link
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public byte[] Book { get; set; }
    }

    public class BookMeta
    {
        [Key]
        public int Id { get; set; }

        public int BookId { get; set; }

        public int LinkId { get; set; }

        public BookFormat Format { get; set; }
    }

    public enum BookFormat
    {
        fb2,
        epub,
        doc,
        rtf
    }
}