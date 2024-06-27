using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class QuocGia
    {
        [Key]
        public int MaNuoc { get; set; }
        public string TenNuoc { get; set; }

        public ICollection<DanhMucSP> DanhMucSPs { get; set; }
    }
}
