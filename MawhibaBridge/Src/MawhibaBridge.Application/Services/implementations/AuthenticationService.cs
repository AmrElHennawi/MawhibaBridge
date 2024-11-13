﻿using MawhibaBridge.Application.DTOs;
using MawhibaBridge.Application.Services.Interfaces;
using MawhibaBridge.Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace MawhibaBridge.Application.Services.implementations
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly TokenService _tokenService;
        public AuthenticationService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, TokenService tokenService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenService = tokenService;
        }


        public async Task<string> Login(LoginDto loginData)
        {
            var user = await _userManager.FindByEmailAsync(loginData.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginData.Password))
            {
                var tokenString = await _tokenService.GenerateToken(user, loginData.RememberMe);
                return tokenString;
            }
            throw new UnauthorizedAccessException("Invalid login credentials.");
        }


        public async Task<string> Register(RegisterDto registerData)
        {
            var user = new AppUser
            {
                FirstName = registerData.FirstName,
                LastName = registerData.LastName,
                Email = registerData.Email,
                PhoneNumber = registerData.PhoneNumber,
                UserName = registerData.Email, 
                Age = registerData.Age,
                Degree = registerData.Degree,
                LinkedIdUrl = registerData.LinkedIdUrl,
                Visability = registerData.Visability,

                //Resume = registerData.Resume ?? string.Empty,
                //Image = registerData.Image ?? string.Empty,
                IsActive = true,  
            };

            var result = await _userManager.CreateAsync(user, registerData.Password);
            if (!result.Succeeded)
            {
                throw new Exception("Registration failed: " + string.Join(", ", result.Errors.Select(e => e.Description)));
            }

            await _userManager.AddToRoleAsync(user, "User");

            var newUserData = new LoginDto()
            {
                Email = registerData.Email,
                Password = registerData.Password,
                RememberMe = true
            };

            return await Login(newUserData);
        }
    }
}