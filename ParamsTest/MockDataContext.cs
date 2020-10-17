using Bogus;
using ParamsTest.MockEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    public class MockDataContext
    {
        private Faker faker = new Faker();

        public MockDataContext()
        {
            Groups = new List<Group>();
            People = new List<Employee>();
            CreateMockData();
        }

        private void CreateMockData()
        {
            for (int i = 1; i < 10; i++)
            {
                Group group = new Group(i, faker.Company.CompanyName());
                if (i >= 1 && i <= 6)
                {
                    group.ParentId = 3 + i;
                }

                Groups.Add(group);
            }

            Random rand = new Random();
            for (int i = 1; i < 20; i++)
            {
                Employee person = new Employee(i, faker.Name.FullName());

                if (i >= 12 && i <= 14)
                {
                    Groups.Where(e => e.Id == 3).SingleOrDefault().Members.Add(person);
                }
                else
                {
                    int groupIndex = rand.Next(1, 4);
                    Groups.Where(e => e.Id == groupIndex).SingleOrDefault().Members.Add(person); 
                }

                People.Add(person);
            }

            Group topGroup = new Group(10, faker.Company.CompanyName());
            Groups.Where(e => e.Id == 8).SingleOrDefault().ParentId = 10;
            Groups.Add(topGroup);
        }

        public List<Group> Groups { get; set; }
        public List<Employee> People { get; set; }
    }
}
