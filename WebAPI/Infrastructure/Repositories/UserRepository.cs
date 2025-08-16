using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interface;
using Domain.Entities;
using EFMigrations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly MyAppDbContext _userRepository;
        public UserRepository(MyAppDbContext userRepository)
        {
            _userRepository = userRepository;
        }

        public Users GetUserById(int id)
        {   return _userRepository.Users.FirstOrDefault(u => u.Id == id);
          
        }
    }
}
