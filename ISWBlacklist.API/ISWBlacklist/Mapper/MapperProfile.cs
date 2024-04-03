﻿using AutoMapper;
using ISWBlacklist.Application.DTOs.User;
using ISWBlacklist.Domain.Entities;

namespace ISWBlacklist.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AddUserDto, AppUser>();
            CreateMap<AppUser, UserResponseDto>();
            CreateMap<UpdateUserDto, AppUser>();
            CreateMap<AppUser, UpdateUserResponseDto>();
        }
    }
}
