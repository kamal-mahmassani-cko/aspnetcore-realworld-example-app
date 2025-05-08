using AutoMapper;

namespace Conduit.Features.Users;

public class MappingProfile : Profile
{
    public MappingProfile() => CreateMap<Domain.Person, User>(MemberList.None);

    //CreateMap<Domain.Person, User>()
    //.ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address));
}

