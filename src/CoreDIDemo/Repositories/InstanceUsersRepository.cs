using CoreDIDemo.Interfaces;
using CoreDIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDIDemo.Repositories
{
    public class InstanceUsersRepository : IInstanceUsersRepository
    {
        private int _random;

        public InstanceUsersRepository()
        {
            _random = new Random().Next(1, 10);
        }

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

        public int GetCurrentRandomValue()
        {
            return _random;
        }
    }
}
