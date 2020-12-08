using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_CarDealership.Models
{
    public class BodyType
    {
        [Display(Name = "Код типа кузова")]
        public long ID { get; set; }
        [Display(Name = "Название")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }


        public IList<Auto> Auto { get; set; }
    }
}
