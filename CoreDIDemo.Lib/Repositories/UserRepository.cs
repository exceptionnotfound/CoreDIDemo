using CoreDIDemo.Lib.Interfaces;
using CoreDIDemo.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDIDemo.Lib.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> GetAll()
        {
            return new List<User>()
            {
                new User()
                {
                    FirstName = "Ash",
                    LastName = "Ketchum",
                    DateOfBirth = new DateTime(1997, 12, 30),
                    Username = "ichooseyou"
                },
                new User()
                {
                    FirstName = "Brock",
                    LastName = "Harrison",
                    DateOfBirth = new DateTime(1992, 3,31),
                    Username = "rockrulez"
                },
                new User()
                {
                    FirstName = "Misty",
                    LastName = "",
                    DateOfBirth = new DateTime(1999, 5,4),
                    Username = "ihearttogepi"
                }
            };
        }
    }
}
