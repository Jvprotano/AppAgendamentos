using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppAgendamentos.Models;
using AppAgendamentos.ViewModels;
using AutoMapper;

namespace AppAgendamentos.Mappings
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile(){
            CreateMap<Company, CompanyViewModel>();
        }
    }
}