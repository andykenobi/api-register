using ApiRegister.DTOs.Clients;
using ApiRegister.Models;
using AutoMapper;

namespace ApiRegister.Mapper
{
    public class GetClientProfile : Profile
    {
        public GetClientProfile()
        {
            CreateMap<Client, GetClientResponse>();
        }
    }
}
