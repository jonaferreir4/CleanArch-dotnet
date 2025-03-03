using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels;
using Domain.Entities;
using AutoMapper;

namespace Application.Mappings
{
    public class DomainToViewModelMappingProfile: Profile
    {
        public DomainToViewModelMappingProfile()
        {
          CreateMap<Product, ProductViewModel>();
        }
    }
}