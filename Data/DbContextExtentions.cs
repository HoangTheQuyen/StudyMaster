using Microsoft.AspNetCore.Identity;
using StudyMaster.Data.Entities;

namespace StudyMaster.Data
{
    public static class DbContextExtentions
    {
        public static UserManager<AppUser> UserManager
        { get; set; }
        public static void EnsureSeeded(this EFDataContext context)
        {
            if (UserManager.FindByEmailAsync("HoangTheQuyen01@gmail.com").GetAwaiter().GetResult() == null)
            {
                var user = new AppUser
                {
                    FirstName = "Hoang",
                    LastName = "Quyen",
                    UserName = "HoangTheQuyen01@gmail.com",
                    Email = "HoangTheQuyen01@gmail.com",
                    EmailConfirmed = true,
                    LockoutEnabled = false
                };
                UserManager.CreateAsync(user,"Password1*").GetAwaiter().GetResult();
            }
        }
    }
}