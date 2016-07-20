using CoreDIDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDIDemo.Operations
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton, IOperationSingletonInstance
    {
        public Guid Guid { get; set; }

        public Operation()
        {
            Guid = Guid.NewGuid();
        }

        public Operation(Guid guid)
        {
            Guid = guid;
        }

        public Guid GetCurrentID()
        {
            return Guid;
        }
    }
}
