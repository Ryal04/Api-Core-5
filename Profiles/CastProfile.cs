using api.Entities;
using api.Models;
using AutoMapper;

namespace api.Profiles
{
    public class CastProfile : Profile
    {
        public CastProfile(){
            CreateMap<Cast, CastDto>();
            CreateMap<CasteForCreationDto, Cast>();
            CreateMap<Cast, CasteForCreationDto>();
            CreateMap<CastForUpdateDto,Cast>().ReverseMap();
            
        }
    }
}