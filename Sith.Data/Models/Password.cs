// Copyright 2017 Vasylyk Andriy
using System.ComponentModel.DataAnnotations;

namespace Sith.Data.Models
{
    public class Password
    {
        [Key]
        public int Id { get; set; }

        public PasswordStore Store { get; set; }
        public string EncryptedPassword { get; set; }
    }
}