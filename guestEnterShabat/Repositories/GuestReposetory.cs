using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using guestEnterShabat.DAL;
using guestEnterShabat.Models;
using Microsoft.Extensions.Configuration;

namespace guestEnterShabat.Repositories
{
    internal class GuestReposetory : IRepositories<Guests>
    {
        DBContext dbContext;
        public GuestReposetory()
        {
            var config = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
            string? conn = config["ConnectionString"];
            dbContext = new DBContext(conn);
        }
        public void Create(Guests newGuest)
        {
            if (newGuest.Name.Trim() == "")
            {
                MessageBox.Show("Please enter new category");
                return;
            }
            MessageBox.Show("The entered category has been successfully added!");
            dbContext.ExecuteNonQuery("INSERT INTO Guests(name) VALUES(@name)", [new SqlParameter("name", newGuest.Name.Trim())]);
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public void DeleteByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Guests> GetAll()
        {
            string queiry = "exec SelectAllGuests;";
            DataTable dt = dbContext.ExecuteQuery(queiry, null);
            List<Guests> ls = new List<Guests>();

            // fill the list from data-table
            foreach (DataRow row in dt.Rows)
            {
                ls.Add(new Guests(row[0].ToString()));
            }

            return ls;
        }

        public Guests? GetById(int id)
        {
            string queiry = "select name from Guests where ID = @id;";
            DataTable db = dbContext.ExecuteQuery(queiry, [new SqlParameter("@id", id)]);
            if (db.Rows.Count == 0)
            {
                return null;
            }

            Guests newGuests = new Guests(db.Rows[0].ToString());
            return newGuests;
        }

        public Guests? GetByName(string name)
        {
            string queiry = "select name from Guests where name = @name;";
            DataTable db = dbContext.ExecuteQuery(queiry, [new SqlParameter("@name", name)]);
            if (db.Rows.Count == 0)
            {
                return null;
            }

            Guests newGuests = new Guests(db.Rows[0].ToString());
            return newGuests;


        }

        public bool isThereThisGuest(string name)
        {
            if (GetByName(name) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Update(Guests category)
        {
            throw new NotImplementedException();
        }
    }
}
