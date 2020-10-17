using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest.MockEntities
{
    public class Group
    {
        public Group()
        {
            Members = new List<Employee>();
        }

        public Group(int id, string name)
        {
            Id = id;
            Name = name;
            Members = new List<Employee>();
        }

        public Group(int id, string name, int? parentId)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
            Members = new List<Employee>();
        }

        public Group(int id, string name, int? parentId, List<Employee> members)
        {
            Id = id;
            Name = name;
            ParentId = parentId;
            Members = members;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public List<Employee> Members { get; set; }
    }
}
