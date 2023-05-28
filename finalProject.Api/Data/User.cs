﻿namespace finalProject.Api.Data
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public SaveGame[] Saves { get; set; } = new SaveGame[3];
    }
}