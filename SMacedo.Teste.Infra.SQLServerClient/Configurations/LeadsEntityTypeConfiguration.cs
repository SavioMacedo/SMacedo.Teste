using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMacedo.Teste.Infra.SQLServerClient.Configurations
{
    public class LeadsEntityTypeConfiguration : IEntityTypeConfiguration<Lead>
    {
        public void Configure(EntityTypeBuilder<Lead> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id)
            .ValueGeneratedOnAdd();

            builder.ToTable("SMacedoTeste", "Leads");
            builder.HasData(CreateData());
        }

        public static Lead[] CreateData()
        {
            return new Lead[]
            {
                new Lead
                {
                    CreateDate = DateTime.Now,
                    Description = "Need to paint 2 aluminum windows and a sliding glass door.",
                    FirstName = "Bill",
                    Id = 1,
                    LastName = "Clapton",
                    LeadStatus = LeadStatus.Invited,
                    Price = 62.00,
                    Suburb = "Yanderra 2574",
                    Phone = "8226375275",
                    Email = "jerod_schaefer50@yahoo.com",
                    Category = "Painters"
                },
                new Lead
                {
                    CreateDate = DateTime.Now,
                    Description = "internal walls 3 colors",
                    FirstName = "Craig",
                    LastName = "List",
                    Id = 2,
                    LeadStatus = LeadStatus.Invited,
                    Price = 49.00,
                    Suburb = "Woolooware 2230",
                    Phone = "8226375275",
                    Email = "zoila3@hotmail.com",
                    Category = "Painters"
                },
                new Lead
                {
                    CreateDate = DateTime.Now,
                    Description = "another teste to make colors",
                    FirstName = "Savio",
                    LastName = "Teste",
                    Id = 3,
                    LeadStatus = LeadStatus.Invited,
                    Price = 600.50,
                    Suburb = "Nova Era 7890",
                    Phone = "8226375275",
                    Email = "annabel_moen@yahoo.com",
                    Category = "Painters"
                },
                new Lead
                {
                    CreateDate = DateTime.Now,
                    Description = "Plaster exposed brick walls (see photos), square off 2 archways (see photos), and expand pantry (see photos)",
                    FirstName = "Pete",
                    LastName = "Parque",
                    Id=4,
                    LeadStatus = LeadStatus.Accepted,
                    Price = 26.00,
                    Suburb = "Carramar 6031",
                    Phone = "8226375275",
                    Email = "stephany92@gmail.com",
                    Category = "Painters"
                }
            };
        }
    }
}
