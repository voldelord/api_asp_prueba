﻿namespace apiaprendizaje_api.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Role { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
