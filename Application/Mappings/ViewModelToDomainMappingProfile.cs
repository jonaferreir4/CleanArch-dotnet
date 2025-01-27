using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.ViewModels;
using AutoMapper;
using Domain.Entities;

namespace Application.Mappings
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<ProductViewModel, Product>();
        }
    }
}