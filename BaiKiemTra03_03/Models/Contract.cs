using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_03.Models
{
    public class Contract
    {
        [Key]
        public int ContractId { get; set; }

        [Required]
        [Display(Name = "Tên hợp đồng")]
        public string ContractName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ngày ký kết")]
        public DateTime SigningDate { get; set; }

        [Required]
        [Display(Name = "Giá trị hợp đồng")]
        public decimal ContractValue { get; set; }

        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
