using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTutorial.Entities.ClienteEntity
{
    public class Cliente : FullAuditedEntity<long> //entidade coberta pela auditoria padrão do ABP, seu ID é do tipo long. 
    {
        //Atributos
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }

        //Construtores
        public Cliente()
        {
            this.CreationTime = DateTime.Now;
        }

        public Cliente(string name, string lastname, string cpf)//argumentos úteis para mapeamento
        {
            this.CreationTime = DateTime.Now;
            this.Name = name;
            this.LastName = lastname;
            this.Cpf = cpf;
        }
    }    
}
