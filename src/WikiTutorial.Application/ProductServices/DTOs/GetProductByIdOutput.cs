using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WikiTutorial.ProductServices.DTOs
{
    public class GetProductByIdOutput : EntityDto<long>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public float Value { get; set; }
    }
}
