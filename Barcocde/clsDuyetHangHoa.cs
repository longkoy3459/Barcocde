using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcocde
{
   public class clsDuyetHangHoa
    {
        //public long ID { get; set; }
        public int STT { get; set; }
        public string TenKeHang { get; set; }
        //public string IDHangHoa { get; set; }
        public string MaHH { get; set; }
        public string MaGoiNho { get; set; }
        public string TenHH { get; set; }
        public int SoLuong { get; set; }

        public DateTime NgayKiemKe { get; set; }
        public int LoaiKiemKe { get; set; }
    }
}
