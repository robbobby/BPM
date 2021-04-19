using AutoMapper;
using BPMWebApi.Library.Dtos;
using BPMWebApi.Library.Models;

namespace BPMWebApi.Profiles {
    public class UserProfile : Profile {
        public UserProfile() {
            CreateMap<User, UserReadDto>();
        }
    }
}
