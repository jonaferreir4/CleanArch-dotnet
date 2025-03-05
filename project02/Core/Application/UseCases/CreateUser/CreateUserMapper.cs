using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;

namespace Application.UseCases.CreateUser
{
    public sealed class CreateUserMapper: Profile
    {
        public CreateUserMapper() {
            CreateMap<CreateUserRequest, User>();
            CreateMap<User, CreateUserResponse>();
        }
    }
}