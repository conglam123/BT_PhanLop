using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_PhanLop.Entity
{
    public class TaxYear
    {
        [Key]
        public int Id { get; set; }
        public string YearOfTax { get; set; }
    }
}
