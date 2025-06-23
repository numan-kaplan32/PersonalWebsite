using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Props;

namespace Web.Model.TablesClass
{
   public class Experiance : CoreEntity
    {
        public  string? Text { get; set; }
        public DateOnly PublicationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    }
}
