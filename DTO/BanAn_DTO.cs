using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanAn_DTO
    {
        private int iD;
        private int iDBan;
        private string tenBan;
        private string trangThai;
        private string ngay;

        public BanAn_DTO()
        {
        }     
        public BanAn_DTO(int id,string name, string tt)
        {                
            this.ID = id;          
            this.TenBan = name;
            this.TrangThai = tt;
            
        }
        public int ID { get => iD; set => iD = value; }
        public int IDBan { get => iDBan; set => iDBan = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Ngay { get => ngay; set => ngay = value; }
    }
}
