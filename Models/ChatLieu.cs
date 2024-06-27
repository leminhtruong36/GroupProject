using System.ComponentModel.DataAnnotations;

namespace GroupProject.Models
{
    public class ChatLieu
    {
        [Key]
        public int MaChatLieu { get; set; }
        public string ChatLieuSP { get; set; }

        public ICollection<DanhMucSP> DanhMucSPs { get; set; }
    }
}
