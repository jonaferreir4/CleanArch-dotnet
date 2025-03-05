using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace Application.UseCases.CreateUser
{
    public sealed record CreateUserRequest(string Name, string Email): 
                                    IRequest<CreateUserResponse>;
}