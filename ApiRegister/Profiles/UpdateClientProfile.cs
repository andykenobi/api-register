using ApiRegister.DTOs.Clients;
using ApiRegister.Models;
using AutoMapper;

namespace ApiRegister.Mapper
{
    public class UpdateClientProfile : Profile
    {
        public UpdateClientProfile()
        {
            CreateMap<UpdateClientRequest, Client>();
        }
    }
}
