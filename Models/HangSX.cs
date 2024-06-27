using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProject.Models
{
    public class HangSX
    {
        [Key]
        public int MaHangSX { get; set; }
        public string HangSXSP { get; set; }
        public int MaNuocThuongHieu { get; set; }

        public ICollection<DanhMucSP> DanhMucSPs { get; set; }

    }
}
