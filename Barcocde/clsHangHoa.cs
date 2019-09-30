using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barcocde
{
    public class clsHangHoa
    {
        public long SoTT { get; set; }
        public string IDHangHoa { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string MaGoiNho { get; set; }
        public DateTime ThoiGianQuet { get; set; }
        public DateTime ThoiGianCapNhat { get; set; }
        public int SoLuong { get; set; }
        public int LoaiKiemKe { get; set; }
        public string LoaiKiemKeText { get => LoaiKiemKe == 0 ? "Scan" : "Input"; }
        public long ID { get; set; }
    }
}
