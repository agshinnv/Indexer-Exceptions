using Indexer_Exceptions.Services;
using Indexer_Exceptions.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions.Controllers
{
    internal class PersonController
    {
        private readonly IPersonService _personService;


        public PersonController()
        {
            _personService = new PersonService();
        }

        public void GetById()
        {
            try
            {
                Console.WriteLine("Add person id :");
                int id = int.Parse(Console.ReadLine());

                var response = _personService.GetById(id);

                var result = $"{response.Id} - {response.FullName} - {response.Age}";

                Console.WriteLine(result);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


        }
    }
}
