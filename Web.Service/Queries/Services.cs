using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web.Core.PersonalICoreService;
using Web.Core.Props;
using Web.Model.WebContext;

namespace Web.Service.Queries
{

    public class Services<T> : ICoreService<T> where T : CoreEntity
    {
        private readonly WebPersonalContext _coreService;
        public Services(WebPersonalContext coreService)
        {
            _coreService = coreService;
        }
        public bool Create(T entity)
        {
            try
            {
                _coreService.Set<T>().Add(entity);
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        
        }

        public bool Delete(T entity)
        {
            try
            {
                _coreService.Set<T>().Remove(entity);
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<T> GetAll() => _coreService.Set<T>().ToList();


        public T GetById(int id) => _coreService.Set<T>().FirstOrDefault(x => x.Id == id);

        public bool Update(T entity)
        {
            try
            {
                _coreService.Update(entity);
                return Save();
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Save() => _coreService.SaveChanges() > 0;
     


    }
}
