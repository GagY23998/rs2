using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Interfaces
{
    public interface ICRUDService<Entity,EntityDTO,InsertRequest,UpdateRequest,SearchRequest>
                     where Entity: class,new()
                     where EntityDTO: class,new()
                     where InsertRequest: class,new()
                     where UpdateRequest: class
                     where SearchRequest: class
    {
        EntityDTO Insert(InsertRequest InsertRequest);
        EntityDTO Update(int objectId,UpdateRequest updateRequest);
        EntityDTO Delete(int Id);
        EntityDTO Get(int id);
        IEnumerable<EntityDTO> Get(SearchRequest searchRequest);
        IEnumerable<EntityDTO> GetAll();
    }
}
