using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewDataBinding1
{
    public class Team
    {
        public Team(string teamName)
        {
            TeamName = teamName;
        }

        public string TeamName { get; set; }
    }
    public class TeamClass
    {
        public TeamClass(string className)
        {
            ClassName = className;
        }

        public string ClassName { get; set; }
        public IList<Team> Teams { get; set; }
    }
}
