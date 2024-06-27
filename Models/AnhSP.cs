using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class AnhSP
    {
        [Key]
        public int MaAnhSP { get; set; }
        public int MaSP { get; set; }
        public string TenFileAnh { get; set; }
        public string ViTri { get; set; }

        [ForeignKey("MaSP")]
        public DanhMucSP DanhMucSP { get; set; }
    }
}
