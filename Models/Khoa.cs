using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Khoa
    {
       
            [Key]
            [Display(Name = "Mã Khoa")]
            public int MaKhoa { get; set; }

            [Display(Name = "Tên Khoa")]
            public string TenKhoa { get; set; }


    }
    class KhoaList
    {
        DBConnection db;
        public KhoaList()
        {
            db = new DBConnection();
        }

        public object Khoalist { get; private set; }

        public List<Khoa> getKhoa(string MaKhoa)
        {
            string sql;
            if (string.IsNullOrEmpty(MaKhoa))
                sql = "SELECT * FROM Khoas";
            else
                sql = "SELECT * FROM Khoas WHERE MaKhoa=" + MaKhoa;
            List<Khoa> Khlist = new List<Khoa>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            Khoa tmpKhoa;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tmpKhoa = new Khoa();
                tmpKhoa.MaKhoa = Convert.ToInt32(dt.Rows[i]["MaKhoa"].ToString());
                tmpKhoa.TenKhoa = dt.Rows[i]["TenKhoa"].ToString();
  
                Khlist.Add(tmpKhoa);
            }
            return Khlist;
        }
    }
}