using CoreDIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDIDemo.Interfaces
{
    public interface IInstanceUsersRepository
    {
        List<User> GetAll();

        int GetCurrentRandomValue();
    }
}
