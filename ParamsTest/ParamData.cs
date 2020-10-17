using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsTest
{
    public class ParamData
    {
        public List<ParamGroup> Groups { get; set; }
    }

    public class ParamGroup
    {
        public ParamGroup()
        {
            People = new List<int>();
        }

        public int Id { get; set; }
        public string Mode { get; set; }
        public List<int> People { get; set; }
    }
}
