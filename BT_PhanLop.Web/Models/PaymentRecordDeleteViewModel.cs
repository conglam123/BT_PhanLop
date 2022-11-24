using System.ComponentModel.DataAnnotations;

namespace BT_PhanLop.Models
{
    public class PaymentRecordDeleteViewModel
    {
        [Display(Name ="Payslip Number")]
        public int Id { get; set; }
    }
}
