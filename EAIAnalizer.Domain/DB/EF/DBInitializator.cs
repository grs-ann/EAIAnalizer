using EAIAnalizer.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAIAnalizer.Domain.DB.EF
{
    public static class DBInitializator
    {
        public static ModelBuilder Initialize(ModelBuilder modelBuilder)
        {
            // Add base operation types.
            var operationTypes = new List<OperationType>()
            {
                new OperationType
                {
                    Id = 1,
                    Name = "Incoming"
                },
                new OperationType
                {
                    Id = 2,
                    Name = "Outcoming"
                }
            };

            // Add bas caterories.
            var categories = new List<Category>()
            {
                new Category
                {
                    Id = 1,
                    Name = "Salary",
                },
                new Category
                {
                    Id = 2,
                    Name = "Grocery store"
                },
                new Category
                {
                    Id = 3,
                    Name = "Entertainment"
                },
                new Category
                {
                    Id = 4,
                    Name = "Other"
                }
            };

            // Add base currencies.
            var currencies = new List<Currency>()
            {
                new Currency
                {
                    Id = 1,
                    Name = "RUB"
                },
                new Currency
                {
                    Id = 2,
                    Name = "USD"
                },
                new Currency
                {
                    Id = 3,
                    Name = "RUR"
                }
            };

            modelBuilder.Entity<OperationType>().HasData(operationTypes);
            modelBuilder.Entity<Category>().HasData(categories);
            modelBuilder.Entity<Currency>().HasData(currencies);
            return modelBuilder;
        }
    }
}
