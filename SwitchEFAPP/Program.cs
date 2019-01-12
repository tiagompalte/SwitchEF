using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using SwitchEF.Domain.Entities;
using SwitchEF.Infra.CrossCutting.Logging;
using SwitchEF.Infra.Data.Context;
using System;
using System.Linq;

namespace SwitchEFAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1;
            User user2;
            User user3;

            User CreateUser(string name)
            {
                return new User()
                {
                    Name = name,
                    Lastname = "Sobrenome"
                };
            }

            user1 = CreateUser("usuário 1");
            user2 = CreateUser("usuário 2");
            user3 = CreateUser("usuário 3");

            var optionsBuilder = new DbContextOptionsBuilder<SwitchEFContext>();
            optionsBuilder.UseLazyLoadingProxies();
            optionsBuilder.UseMySql("Server=localhost;userid=root;password=root;database=switch_ef;", 
                m => m.MigrationsAssembly("SwitchEF.Infra.Data"));

            try
            {
                using (var dbcontext = new SwitchEFContext(optionsBuilder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());

                    //dbcontext.Users.AddRange(user1, user2, user3);
                    //dbcontext.SaveChanges();

                    var result = dbcontext.Users.Where(u => u.Name == "usuário 1").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

            Console.WriteLine("OK!");
            Console.ReadKey();

        }
    }
}
