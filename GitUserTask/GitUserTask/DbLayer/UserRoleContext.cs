namespace GitUserTask.DbLayer
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;

    public class UserRoleContext : DbContext
    {
        public UserRoleContext()
            : base("name=UserRoleContext")
        {
            if(Users.FirstOrDefault() == null)
                Users.AddRange(DataManager.users);
            if (Role.FirstOrDefault() == null)
              Role.AddRange(DataManager.roles);
            if (UserInRoles.FirstOrDefault() == null)
              UserInRoles.AddRange(DataManager.userinroles);
            SaveChanges();
        }
        public DbSet<User> Users { set; get; }
        public DbSet<Role> Role { set; get; }
        public DbSet<UserInRole> UserInRoles { set; get; }
    }
}