using CoreDIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDIDemo.ViewModels
{
    public class InstanceUsersVM
    {
        public List<User> Users { get; set; }
        public int RandomNumber { get; set; }
    }
}
