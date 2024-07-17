using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using guestEnterShabat.DAL;
using guestEnterShabat.Models;
using Microsoft.Extensions.Configuration;

namespace guestEnterShabat.Repositories
{

    internal class FoodRepository : IRepositories<Food>
    {
        DBContext dbContext;
        public FoodRepository()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }
        public void Create(Food category)
        {
            if (category.Name.Trim() == "")
            {
                MessageBox.Show("Please enter new category");
                return;
            }
            MessageBox.Show("The entered category has been successfully added!");
            }

        public void Createa(string guestName, string category,string name)
        {
            
            MessageBox.Show("The entered category has been successfully added!");
            dbContext.ExecuteNonQuery("exec AddFood @guestName = @GuestName, @category = @Category, @name = @Name", [new SqlParameter("@GuestName", guestName), new SqlParameter("@Category", category), new SqlParameter("@Name", name)]);
        }
        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Food> GetAll()
        {
            throw new NotImplementedException();
        }

        public Food GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Food category)
        {
            throw new NotImplementedException();
        }
        public bool SelectFoodByNameCategoryGuestName(string name, string category, string guestName)
        {
            string queiry = @"SELECT g.name, c.name, f.name from Food f
                                join Categories c on c.ID = f.Category_ID
                                join Guests g on g.ID = f.Guest_ID
                                where g.name = @guestName and c.name=@categoryName and f.name=@dishName";
            DataTable db = dbContext.ExecuteQuery(queiry, [new SqlParameter("@guestName", guestName), new SqlParameter("@categoryName", category), new SqlParameter("@dishName",name)]);
            if (db.Rows.Count == 0)
            {
                return false;
            }
            return true;
        }
        public DataTable SelectAllGuestFoodByCategoryAndName( string category, string name)
        {
            string queiry = "exec SelectAllGuestFoodByCategoryAndName @category = @Category, @name=@Name";
            DataTable dt = dbContext.ExecuteQuery(queiry, [new SqlParameter("@Category", category), new SqlParameter("@Name", name)]);
            return dt;
        }

        public DataTable SelectAllGuestsFoodByCategoryAndName(string category, string name)
        {
            string queiry = "exec SelectAllGuestsFoodByCategoryAndName @category = @Category, @name=@Name";
            DataTable dt = dbContext.ExecuteQuery(queiry, [new SqlParameter("@Category", category), new SqlParameter("@Name", name)]);
            return dt;
        }

        
    }
}
