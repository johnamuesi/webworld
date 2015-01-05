using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebWorld.Data
{
    public class Topic
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [Column(TypeName="varchar")]
        [StringLength(50)]
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }
        public bool Flag { get; set; }

        public ICollection<Reply> Replies { get; set; }
        public Category Priority { get; set; }

    }
}