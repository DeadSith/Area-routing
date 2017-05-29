// Copyright 2017 Vasylyk Andriy
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sith.Data.Models
{
    public class PasswordStore
    {
        [Key]
        public string StoreId { get; set; }

        public ApplicationUser Owner { get; set; }
        public virtual List<Password> Passwords { get; set; }
    }
}