using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTutorial.Entities.ProductEntity
{
    public class Product : FullAuditedEntity<long> //entidade coberta pela auditoria padrão do ABP, seu ID é do tipo long.
    {
        //Atributos
        public string Name { get; set; }
        public string Description { get; set; }
        public float Value { get; set; }

        //Construtores
        public Product()
        {
            this.CreationTime = DateTime.Now;
        }

        public Product(string name, string description, float value)//argumentos úteis para mapeamento
        {
            this.CreationTime = DateTime.Now;
            this.Name = name;
            this.Description = description;
            this.Value = value;
        }

    }
}
