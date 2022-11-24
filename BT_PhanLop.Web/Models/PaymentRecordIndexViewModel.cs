using BT_PhanLop.Entity;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BT_PhanLop.Models
{
    public class PaymentRecordIndexViewModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [Display(Name = "Full Name")]
        public Employee Employee { get; set; }
        [Display(Name = "Date Pay")]
        public DateTime DatePay { get; set; }
        [Display(Name = "Month Pay")]
        public string MonthPay { get; set; }
        public int TaxYearId { get; set; }
        public string TaxYear { get; set; }
        [Display(Name = "Total Earnings")]
        public decimal TotalEarnings { get; set; }
        [Display(Name = "Total Deductions")]
        public decimal TotalDeduction { get; set; }
        [Display(Name = "Net Payment")]
        public decimal NetPayment { get; set; }
    }
}
