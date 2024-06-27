using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class LoaiDT
    {
        [Key]
        public int MaDT { get; set; }
        public string TenLoai { get; set; }

        public ICollection<DanhMucSP> DanhMucSPs { get; set; }
    }
}
