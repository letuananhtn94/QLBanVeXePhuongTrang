using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_ChiTietChuyenDi
    {
        public string validateInput(int maChuyen, int? thoiGianDung)
        {
            if (thoiGianDung > 20 && thoiGianDung < 10 )
                return "Thời gian dừng phải nằm trong (10, 20)";

            return null;
        }
    }
}
