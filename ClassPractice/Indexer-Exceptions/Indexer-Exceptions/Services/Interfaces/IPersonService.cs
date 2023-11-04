using Indexer_Exceptions.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Exceptions.Services.Interfaces
{
    internal interface IPersonService
    {
        Person GetById(int? id);
    }
}
