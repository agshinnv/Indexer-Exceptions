using Indexer_Exceptions.Data;
using Indexer_Exceptions.Models;
using Indexer_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions.Services
{
    internal class PersonService : IPersonService
    {
        private readonly AppDbContext _context;

        public PersonService()
        {
            _context = new AppDbContext();
        }
        public Person GetById(int? id)
        {
            
            if(id is null) throw new ArgumentNullException();

            Person? existPerson = _context.People().FirstOrDefault(m=>m.Id == id);

            if(existPerson == null) throw new NullReferenceException("Data not found");

            return existPerson;
            
        }


    }
}
