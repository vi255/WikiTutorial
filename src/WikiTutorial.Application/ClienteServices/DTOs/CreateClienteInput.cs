using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTutorial.ClienteServices.DTOs
{
    public class CreateClienteInput
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
    }
}
