﻿using Jinget.Blazor.Services.Contracts;
using System.Security.Claims;

namespace Jinget.Blazor.Test
{
    public class AuthenticationService : IAuthenticationService
    {
        public async Task<string> GenerateTokenAsync(IEnumerable<Claim> claims, string authenticationType)
        {
            return await Task.FromResult("abc");
        }

        public async Task<string> LoginAsync(string username, string password)
        {
            return await GenerateTokenAsync([new Claim(ClaimTypes.Name, username)], "custom");
        }
    }
}