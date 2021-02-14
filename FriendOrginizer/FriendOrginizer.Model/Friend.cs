﻿using System.ComponentModel.DataAnnotations;

namespace FriendOrginizer.Model
{
    public class Friend
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]  //moze i MaxLength
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}