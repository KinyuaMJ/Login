using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LoginTestAPI.Data
{
    public class LoginTestAuthDBContext :IdentityDbContext
    {
        public LoginTestAuthDBContext(DbContextOptions<LoginTestAuthDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "5b2fe239-df98-4d35-8f8c-1ca0aa72671d";
            var writerRoleID = "07d3eff4-28fb-4407-91af-2e2f27a7267a";
            var managerRoleId = "2bace4ea-8423-44cc-914a-6ef4c830aa17";
            var supervisorRoleId = "bc03dfe9-feb1-41e2-852d-21545e4d3aff";
            var officerRoleId = "2be07a0f-1f55-43e3-87e5-1daa83f845c7]";


            var roles = new List<IdentityRole> {
                new IdentityRole
                {
                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName ="Reader".ToUpper()
                },
                new IdentityRole
                {
                    Id = writerRoleID,
                    ConcurrencyStamp = writerRoleID,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                },
                 new IdentityRole
                {
                    Id = managerRoleId,
                    ConcurrencyStamp = managerRoleId,
                    Name = "Manager",
                    NormalizedName = "Manager".ToUpper()
                },
                 new IdentityRole
                {
                    Id = supervisorRoleId,
                    ConcurrencyStamp = supervisorRoleId,
                    Name = "Supervisor",
                    NormalizedName = "Supervisor".ToUpper()
                },
                  new IdentityRole
                {
                    Id = officerRoleId,
                    ConcurrencyStamp = officerRoleId,
                    Name = "Officer",
                    NormalizedName = "Officer".ToUpper()
                }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
