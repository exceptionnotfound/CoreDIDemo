using CoreDIDemo.Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDIDemo.Lib.Interfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
