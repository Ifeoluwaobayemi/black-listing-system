﻿using ISWBlacklist.Application.DTOs.Auth;
using ISWBlacklist.Application.DTOs.User;
using ISWBlacklist.Domain;
using ISWBlacklist.Domain.Entities;

namespace ISWBlacklist.Application.Services.Interfaces
{
    public interface IAuthenticationServices
    {
        Task<ApiResponse<UserResponseDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<ApiResponse<string>> ValidateTokenAsync(string token);
        Task<ApiResponse<LoginResponseDto>> LoginAsync(AppUserLoginDto loginDTO);
        Task<ApiResponse<string>> ResetPasswordAsync(string email, string token, string newPassword);
        Task<ApiResponse<string>> ChangePasswordAsync(AppUser user, string currentPassword, string newPassword);
        Task<ApiResponse<string>> SetPasswordAsync(string email, string newPassword, string confirmPassword);
        Task<ApiResponse<string>> LogoutAsync();
    }
}
