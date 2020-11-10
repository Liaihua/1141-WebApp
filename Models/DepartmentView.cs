using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _1141_WebApp.Models
{
    public class DepartmentView
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static implicit operator DepartmentView(_1141_WebApp.Models.Departments target)
        {
            if (target == null)
                return new DepartmentView();
            return new DepartmentView { Id = target.Id, Name = target.Name };
        }
    }
}
