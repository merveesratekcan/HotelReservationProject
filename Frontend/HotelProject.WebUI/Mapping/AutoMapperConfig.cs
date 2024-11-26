using AutoMapper;
using HotelProject.DtoLayer.Dtos.RoomDto;
using HotelProject.DtoLayer.Dtos.TestimonialDto;
using HotelProject.EntityLayer.Concrete;
using HotelProject.WebUI.Dtos.AboutDto;
using HotelProject.WebUI.Dtos.LoginDto;
using HotelProject.WebUI.Dtos.RegisterDto;
using HotelProject.WebUI.Dtos.ServiceDto;

namespace HotelProject.WebUI.Mapping;

public class AutoMapperConfig: Profile
{
    public AutoMapperConfig()
    {
       CreateMap<ResultServisDto,Service>().ReverseMap();
       CreateMap<UpdateServiceDto,Service>().ReverseMap();
       CreateMap<CreateServiceDto,Service>().ReverseMap();

       CreateMap<CreateNewUserDto,AppUser>().ReverseMap();
       CreateMap<LoginUserDto,AppUser>().ReverseMap();

       CreateMap<ResultAboutDto,About>().ReverseMap();
       CreateMap<UpdateAboutDto, About>().ReverseMap();

    }
}

