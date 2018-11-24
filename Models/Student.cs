using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManagement.Models
{
    public class Student
    {
        public int ID { set; get; }
        [Required(ErrorMessage="Moi Nhap Ho va ten")]
        [Display(Name="Ho va Ten:")]
        public string FullName { set; get; }
        [Required(ErrorMessage = "Moi Nhap Dia Chi")]
        [Display(Name = "Dia Chi:")]
        public string Address { set; get; }

    }
    class StudentList
    {
        DBConnection db;
        public StudentList()
        {
            db = new DBConnection();
        }
        public List<Student> getStudent(string ID)
        {
            string sql;
            if (string.IsNullOrEmpty(ID))
                sql = "SELECT * FROM Students";
            else
                sql = "SELECT * FROM Students WHERE ID=" + ID;
            List<Student> stulist = new List<Student>();
            DataTable dt = new DataTable();
            SqlConnection con = db.GetConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            con.Open();
            da.Fill(dt);
            da.Dispose();
            con.Close();
            Student tmpStu;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                tmpStu = new Student();
                tmpStu.ID = Convert.ToInt32(dt.Rows[i]["ID"].ToString());
                tmpStu.FullName = dt.Rows[i]["FullName"].ToString();
                tmpStu.Address = dt.Rows[i]["Address"].ToString();
                stulist.Add(tmpStu);
            }
            return stulist;
        }
    }
}