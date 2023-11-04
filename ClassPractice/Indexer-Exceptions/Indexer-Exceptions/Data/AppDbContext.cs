using Indexer_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions.Data
{
    internal class AppDbContext
    {
        public Person[] People()
        {
            return new Person[]
            {
                new Person
                {
                    Id = 1,
                    FullName = "Aqshin Veliyev",
                    Age = 26
                },

                new Person
                {
                    Id= 2,
                    FullName = "Semed Huseynov",
                    Age = 26
                },

                new Person
                {
                    Id = 3,
                    FullName = "Ilham Abasov",
                    Age = 20
                }
            };
        }
    }
}
