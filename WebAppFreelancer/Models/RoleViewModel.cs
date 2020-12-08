using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class RoleViewModel
    {
        public RoleViewModel() { }
        public RoleViewModel(ApplicationRole role) {
            id = role.Id;
            Name = role.Name;
        }
        public RoleViewModel(string id , string name)
        {
            this.id = id;
            this.Name = name;
        }

        public string id { get; set; }
        public string Name { get; set; }

    }
}