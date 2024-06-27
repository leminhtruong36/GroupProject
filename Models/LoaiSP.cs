using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class LoaiSP
    {
        [Key]
        public int MaLoai { get; set; }
        public string Loai { get; set; }

        public ICollection<DanhMucSP> DanhMucSPs { get; set; }
    }
}
