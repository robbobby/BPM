using System.Collections.Generic;
using AutoMapper;
using BPMWebApi.Data;
using BPMWebApi.Library.Dtos;
using BPMWebApi.Library.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BPMWebApi.Controllers {
    [Route("/api/users")]
    [ApiController]
    public class UsersController : ControllerBase {
        private readonly IUserRepo _userRepo;
        private readonly IMapper _mapper;

        public UsersController(IUserRepo userRepo, IMapper mapper) {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        [HttpGet] // /api/users
        public ActionResult<IEnumerable<UserReadDto>> GetAllUsers() {
            IEnumerable<User> allUsers = _userRepo.GetAllUsers();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(allUsers));
        }

        [HttpGet("{id:int}", Name="GetUserById")] // /api/users/1
        [Authorize]
        public ActionResult<UserReadDto> GetUserById(int id) {
            User user = _userRepo.GetUserById(id);
            if(user != null)
                return Ok(_mapper.Map<UserReadDto>(user));
            return NotFound();
        }

        [HttpPost]
        public ActionResult<UserReadDto> CreateUser(UserCreateDto user) {
            User userModel = _mapper.Map<User>(user);
            _userRepo.CreateUser(userModel);
            _userRepo.SaveChanges();
            UserReadDto userReadDto = _mapper.Map<UserReadDto>(userModel);

            return CreatedAtRoute(nameof(GetUserById), new { id = userModel.Id}, userReadDto);
        }
    }
}
