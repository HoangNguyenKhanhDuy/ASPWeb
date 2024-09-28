using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
            [Key]
            public int Id { get; set; }
            [Required(ErrorMessage = "không được để trông tên lớp học")]
            [Display(Name = "Tên lớp học")]

            public string TenLopHoc { get; set; }
            [Required(ErrorMessage = "Không được để trông năm nhập học")]
            [Display(Name = "Năm Nhập Học")]

            public string NamNhapHoc { get; set; }
            [Required(ErrorMessage = "Không được để trông năm ra trường")]
            [Display(Name = "Năm ra trường")]

            public string NamRaTruong { get; set; }
            [Required(ErrorMessage = "Không được để trông số lượng sinh viên")]
            [Display(Name = "Số lượng sinh viên")]

            public int SoLuongSinhVien { get; set; }
        }
    }
