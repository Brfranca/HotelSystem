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
        Response Insert<T>(T item);
        Response Update(T item);
        Response Delete(T item);
        QueryResponse<List<T>> GetAll();
        QueryResponse<T> GetById(int id);
    }
}
