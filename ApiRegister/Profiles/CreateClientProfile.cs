using ApiRegister.DTOs.Clients;
using ApiRegister.Models;
using AutoMapper;

namespace ApiRegister.Mapper
{
    public class CreateClientProfile : Profile
    {
        public CreateClientProfile()
        {
            CreateMap<CreateClientRequest, Client>();
        }
    }
}
