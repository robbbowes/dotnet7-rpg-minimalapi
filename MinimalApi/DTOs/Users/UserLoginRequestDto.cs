﻿namespace MinimalApi.DTOs.Users
{
    public class UserLoginRequestDto
    {
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
