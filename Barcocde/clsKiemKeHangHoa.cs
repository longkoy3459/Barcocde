using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcocde
{
    public class clsKiemKeHangHoa
    {
        public long ID_user { get; set; }
        public string ID_Kho { get; set; }
        public string ID_HangHoa { get; set; }
        public string TenKeHang { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgaYkiemKe { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public int LoaiKiemKe { get; set; }
    }
}
