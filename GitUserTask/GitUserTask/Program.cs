using GitUserTask.DbLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitUserTask
{
    class Program
    {
        public static IEnumerable<User> GetUsers(string role)
        {
            UserRoleContext context = new UserRoleContext();
            return context.Database.SqlQuery<User>("Select * From UserByRole(@role)", new SqlParameter("role", role));
        }

        static void Main(string[] args)
        {
            foreach (var u in GetUsers("manager"))
            {
                Console.WriteLine($"{u.UserId} {u.UserName} {u.Email} {u.DateBirthday} {u.JobTitleId}");
            }
        }

    }
}
