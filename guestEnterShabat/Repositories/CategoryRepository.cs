using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using guestEnterShabat.DAL;
using guestEnterShabat.Models;
using Microsoft.Extensions.Configuration;

namespace guestEnterShabat.Repositories
{
    internal class CategoryRepository : IRepositories<Categories>
    {
        DBContext dbContext;
        public CategoryRepository()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }
        public void Create(Categories category)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Categories> GetAll()
        {
            throw new NotImplementedException();
        }

        public Categories GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Categories category)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllString()
        {

            string queiry = "exec SelectAllCategories;";
            DataTable dt = dbContext.ExecuteQuery(queiry, null);
            List<string> ls = new List<string>();

            // fill the list from data-table
            foreach (DataRow row in dt.Rows)
            {
                ls.Add(row[0].ToString());
            }

            return ls;
        }
    }
}
