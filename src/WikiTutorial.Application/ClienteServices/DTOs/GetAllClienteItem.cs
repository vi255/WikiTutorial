using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTutorial.ClienteServices.DTOs
{
   public class GetAllClienteItem : EntityDto<long>
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public string Idade { get; set; }
        public string Email { get; set; }
    }
}
