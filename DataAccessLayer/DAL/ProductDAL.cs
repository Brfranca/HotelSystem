using Common;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DAL
{
    public class ProductDAL : BaseDAL<Product>, IEntityCRUD<Product>
    {
        public bool ExistName(string name, int id)
        {
            return Exist(name, id, "NAME");
        }

        public bool ExistDescription(string description, int id)
        {
            return Exist(description, id, "DESCRIPTION");
        }
    }
}
