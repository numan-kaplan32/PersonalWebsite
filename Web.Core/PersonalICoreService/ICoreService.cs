using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.Props;

namespace Web.Core.PersonalICoreService
{
   public interface ICoreService <T> where T : CoreEntity
    {
        public bool Create(T entity);
        public bool Update(T entity);
        public bool Delete(T entity);
        public T GetById(int id);
        public IEnumerable<T> GetAll();
        public bool Save();
    }
}
