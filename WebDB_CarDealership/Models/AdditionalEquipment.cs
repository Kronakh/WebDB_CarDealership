using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebDB_CarDealership.Models
{
    public class AdditionalEquipment
    {
        [Display(Name = "Код оборудования")]
        public long ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Характеристики")]
        public string Characteristics { get; set; }
        [Display(Name = "Цена")]
        public int Cost { get; set; }


        public IList<Auto> Auto { get; set; }
    }
}
