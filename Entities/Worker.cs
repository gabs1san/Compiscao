using System;
using System.Security.Principal;
using Compiscao.Entities.Enums;

namespace Compiscao.Entities
{
    class Worker
    {
        public String Name { get; set; }
        public WorkerLevel Level {get; set; }
        public double BaseSalary{ get; set; }
        public Department Department { get; set; }
    }
}
