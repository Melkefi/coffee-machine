using Core;
using Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Seeder
{
    public class BadgeSeeder
    {
        private readonly IApplicationBuilder app;
        public BadgeSeeder(IApplicationBuilder app)
        {
            this.app = app;
        }

        public void Seed()
        {
            using var serviceScope = app.ApplicationServices
                    .GetRequiredService<IServiceScopeFactory>()
                    .CreateScope();
            using var applicationDbContext = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
            var badges = new List<Badge>
            {
                new Badge
                {
                    Value = Guid.NewGuid().ToString(),
                },
                new Badge
                {
                    Value = Guid.NewGuid().ToString(),
                },
                new Badge
                {
                    Value = Guid.NewGuid().ToString(),
                },
                new Badge
                {
                    Value = Guid.NewGuid().ToString(),
                },
                new Badge
                {
                    Value = Guid.NewGuid().ToString(),
                }
            };
            applicationDbContext.Badges.AddRange(badges);
            applicationDbContext.SaveChanges();
        }
    }
}
