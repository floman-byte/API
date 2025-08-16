using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interface
{
    public interface IUserRepository
    {
        // Define methods for user data access
        Users GetUserById(int id);
    }
}
