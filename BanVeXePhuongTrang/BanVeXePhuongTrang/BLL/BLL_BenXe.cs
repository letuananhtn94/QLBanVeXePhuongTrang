using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanVeXePhuongTrang.DAL;

namespace BanVeXePhuongTrang.BLL
{
    class BLL_BenXe
    {
        public string maBenXe;
        public string tenBenXe;

        public BLL_BenXe(string maBen, string tenBen)
        {
            maBenXe = maBen;
            tenBenXe = tenBen;
        }

        public bool canInsert()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblBenXes.Where(t => t.MaBenXe == maBenXe || t.TenBenXe == tenBenXe).ToArray().Length != 0)
                return false;

            return true;
        }

        public bool canUpdate()
        {
            QUANLYXEKHACHEntities db = new QUANLYXEKHACHEntities();
            if (db.tblBenXes.Where(t => t.MaBenXe != maBenXe && t.TenBenXe == tenBenXe).ToArray().Length != 0)
                return false;

            return true;
        }
    }
}
