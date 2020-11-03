using ConsoleTableExt;
using Newtonsoft.Json;
using ParamsTest.MockEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    class Program
    {
        private static MockDataContext dataContext = new MockDataContext();

        static void Main(string[] args)
        {
            ParamData param = JsonConvert.DeserializeObject<ParamData>(File.ReadAllText("./Data/params.json"));

            LoadData(param, File.ReadAllText("./Data/params.json"));

            Console.ReadLine();
        }

        private static void LoadData(ParamData param, string param_str)
        {
            #region Load Code
            //int maxDepth = 0;
            //List<EmployeeDTO> groupStructure = new List<EmployeeDTO>();
            //foreach (var item in param.Groups)
            //{
            //    Group group = dataContext.Groups.Where(e => e.Id == item.Id).SingleOrDefault();
            //    int currentDepth = 0;

            //    if (item.Mode == "full")
            //    {
            //        foreach (var employee in group.Members)
            //        {
            //            EmployeeDTO employeeDTO = new EmployeeDTO();
            //            employeeDTO.Id = employee.Id;
            //            employeeDTO.Name = employee.Name;

            //            employeeDTO.Parent = BuildStructure(group, 0, out currentDepth);
            //            groupStructure.Add(employeeDTO);
            //        } 
            //    }
            //    else
            //    {
            //        foreach (var employee in dataContext.People.Where(e => item.People.Contains(e.Id)))
            //        {
            //            EmployeeDTO employeeDTO = new EmployeeDTO();
            //            employeeDTO.Id = employee.Id;
            //            employeeDTO.Name = employee.Name;

            //            employeeDTO.Parent = BuildStructure(group, 0, out currentDepth);
            //            groupStructure.Add(employeeDTO);
            //        }
            //    }

            //    if (currentDepth > maxDepth)
            //    {
            //        maxDepth = currentDepth;
            //    }
            //}

            //DataTable dataTable = new DataTable();
            //dataTable.Columns.Add("Name");
            //for (int i = 0; i < maxDepth; i++)
            //{
            //    dataTable.Columns.Add("Group" + i.ToString());
            //}

            //foreach (var item in groupStructure)
            //{
            //    DataRow row = dataTable.NewRow();
            //    row["Name"] = $"[{item.Id}]{item.Name}";
            //    List<GroupDTO> groups = GetGroupList(item.Parent);
            //    for (int i = 0; i < groups.Count; i++)
            //    {
            //        row["Group" + i.ToString()] = $"[{groups[i].Id}]{groups[i].Name}";
            //    }

            //    dataTable.Rows.Add(row);
            //} 
            #endregion

            var source = new Report1DataSource();
            ConsoleTableBuilder.From(source.Report1Dara(param_str).Tables[0]).ExportAndWriteLine();
        }

        private static List<GroupDTO> GetGroupList(GroupDTO parent)
        {
            List<GroupDTO> groups = new List<GroupDTO>();
            groups.Add(parent);
            GroupDTO current = parent;
            while (current.Parent != null)
            {
                groups.Add(current.Parent);
                current = current.Parent;
            }

            groups.Reverse();
            return groups;
        }

        private static GroupDTO BuildStructure(Group group, int level, out int maxLevel)
        {
            GroupDTO dto = new GroupDTO()
            {
                Id = group.Id,
                Name = group.Name
            };

            level++;
            maxLevel = level;
            if (group.ParentId != null)
            {
                dto.Parent = BuildStructure(dataContext.Groups.Where(e => e.Id == group.ParentId).SingleOrDefault(), level, out maxLevel);
            }

            return dto;
        }
    }
}
