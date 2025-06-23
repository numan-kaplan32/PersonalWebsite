using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Props;

namespace Web.Model.TablesClass
{
   public class Education : CoreEntity
    {
        public string? EducationName { get; set; }
        public string? EducationDesc { get; set; }
        public decimal GPA { get; set; }
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
    }
}
