using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using MediatR;

namespace Application.UseCases.CreateUser
{
    public class CreateUserHandle :
        IRequestHandler<CreateUserRequest, CreateUserResponse>

    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public CreateUserHandle(IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) {
            _unitOfWork = unitOfWork;;
            _userRepository = userRepository;
            _mapper = mapper;

        }

        public async Task<CreateUserResponse> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user  = _mapper.Map<User>(request);
            _userRepository.Create(user);
            await _unitOfWork.Commit(cancellationToken);
            return _mapper.Map<CreateUserResponse>(user);
        }
    }

}