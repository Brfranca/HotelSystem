using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public interface IEntityCRUD<T>
    {
        //interface utilizada para que as classes que representam tabela no banco de dados realizem o CRUDe  outros métodos básicos 
        Response Insert<T>(T item);
        Response Update<T>(T item);
        Response Delete<T>(T item);
        QueryResponse<List<T>> GetAll();
        QueryResponse<T> GetById(int id);
    }
}
