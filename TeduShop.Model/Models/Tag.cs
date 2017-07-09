﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [Required]
        public string ID { set; get; }
        public string Name { set; get; }
        public string Type { set; get; }

        public virtual IEnumerable<ProductTag> ProductTags { set; get; }
    }
}
