using System.Collections.Generic;
using CRUD.Models;

namespace CRUD.Models
{
    public interface IGlassRepositore
    {
         void Create (Glass glass);

         void Update (Glass glass);

         void Delete (long id);

         List<Glass> GetAll();

         Glass GetById (long id);
    }
}