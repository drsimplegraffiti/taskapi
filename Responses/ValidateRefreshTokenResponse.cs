﻿namespace TasksApi.Responses
{
    public class ValidateRefreshTokenResponse : BaseResponse
    {
        public int UserId { get; set; }
        public string? Email {get; set;}

    }
}
