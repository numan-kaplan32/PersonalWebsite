using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Props;

namespace Web.Model.TablesClass
{
   public class Project : CoreEntity
    {
        public string Description { get; set; } = string.Empty;
        public string TechName { get; set; } = string.Empty;
        public string ProjectLink { get; set; } = string.Empty;
    }
}
