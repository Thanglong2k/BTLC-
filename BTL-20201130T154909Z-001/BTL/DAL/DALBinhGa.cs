using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALBinhGa
    {
        static DALGeneric dalGeneric = new DALGeneric();
        #region
        /*public DataTable showAll(string nameTB)
        {

            return dalGeneric.selectAll(nameTB);
        }
        //Thêm sinh viên

        public bool Add(DTOBinhGa bg)
        {

            string insert = "insert into BinhGa values('" + bg.MaBinh + "','" + bg.TenBinh + "','" + bg.MaLoai + "','" + bg.MaMau + "'," + bg.MaKL + ",'" + bg.MaNSX + "'," +
                            bg.SoLuong + "," + bg.DonGiaNhap + "," + bg.DonGiaBan + "," + bg.ThoiGianBH + ",@Anh,'" + bg.GhiChu + "')";

            *//*string insert = "insert into BinhGa values(@MaBinh,@TenBinh,@MaLoai,@MaMau," +
                    "@MaKL,@MaNSX,@SoLuong,@DonGiaNhap,@DonGiaBan,@ThoiGianBaoHanh,@Anh,@GhiChu)";

            SqlConnection con = dBConnect.Connection();
            SqlCommand cmd = new SqlCommand(insert, con);
            con.Open();
            cmd.Parameters.AddWithValue("@MaBinh", bg.MaBinh);
            cmd.Parameters.AddWithValue("@TenBinh", bg.TenBinh);
            cmd.Parameters.AddWithValue("@MaLoai", bg.MaLoai);
            cmd.Parameters.AddWithValue("@MaMau", bg.MaMau);
            cmd.Parameters.AddWithValue("@MaKL", bg.MaKL);
            cmd.Parameters.AddWithValue("@MaNSX", bg.MaNSX);
            cmd.Parameters.AddWithValue("@SoLuong", bg.SoLuong);
            cmd.Parameters.AddWithValue("@DonGiaNhap", bg.DonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", bg.DonGiaBan);
            cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", bg.ThoiGianBH);
            cmd.Parameters.AddWithValue("@Anh", bg.Anh);
            cmd.Parameters.AddWithValue("@GhiChu", bg.GhiChu);*//*
            return dalGeneric.ExecuteNonQueryIMG(insert, bg.Anh);
        }

        public bool Edit(DTOBinhGa bg)
        {
            string update = "update BinhGa set TenBinh='" + bg.TenBinh + "',MaLoai='" + bg.MaLoai + "',MaMau ='" + bg.MaMau +
                    "',MaKL=" + bg.MaKL + ",MaNSX='" + bg.MaNSX + "',SoLuong=" + bg.SoLuong + ",DonGiaNhap=" + bg.DonGiaNhap + ",DonGiaBan=" + bg.DonGiaBan +
                    ",ThoiGianBaoHanh=" + bg.ThoiGianBH + ",Anh=@Anh,GhiChu='" + bg.GhiChu + "' where  MaBinh='" + bg.MaBinh + "'";

            *//*SqlConnection con = dBConnect.Connection();
            SqlCommand cmd = new SqlCommand(update, con);
            con.Open();
            cmd.Parameters.AddWithValue("@MaBinh", bg.MaBinh);
            cmd.Parameters.AddWithValue("@TenBinh", bg.TenBinh);
            cmd.Parameters.AddWithValue("@MaLoai", bg.MaLoai);
            cmd.Parameters.AddWithValue("@MaMau", bg.MaMau);
            cmd.Parameters.AddWithValue("@MaKL", bg.MaKL);
            cmd.Parameters.AddWithValue("@MaNSX", bg.MaNSX);
            cmd.Parameters.AddWithValue("@SoLuong", bg.SoLuong);
            cmd.Parameters.AddWithValue("@DonGiaNhap", bg.DonGiaNhap);
            cmd.Parameters.AddWithValue("@DonGiaBan", bg.DonGiaBan);
            cmd.Parameters.AddWithValue("@ThoiGianBaoHanh", bg.ThoiGianBH);
            cmd.Parameters.AddWithValue("@Anh", bg.Anh);
            cmd.Parameters.AddWithValue("@GhiChu", bg.GhiChu);
            string a="";*//*
            return dalGeneric.ExecuteNonQueryIMG(update, bg.Anh);
        }

        public bool Delete(string maBinh)
        {
            string delete = string.Format("delete from  BinhGa where maBinh = '{0}'", maBinh);
            return dalGeneric.ExecuteNonQuery(delete);
        }*/
        #endregion
        public DataTable showAll(string nameTB)
        {

            return dalGeneric.selectAll(nameTB);
        }
        public DataTable showAllByCV(string nameTB,string codeCV)
        {

            return dalGeneric.selectAllByCV(nameTB,codeCV);
        }
        //Thêm sinh viên

        public bool Add(DTOBinhGa bg)
        {

            SqlParameter[] sqlP = new SqlParameter[12];
            sqlP[0] = new SqlParameter("@MaBinh", bg.MaBinh);
            sqlP[1] = new SqlParameter("@TenBinh", bg.TenBinh);
            sqlP[2] = new SqlParameter("@MaKL", bg.MaKL);
            sqlP[3] = new SqlParameter("@MaLoai", bg.MaLoai);
            sqlP[4] = new SqlParameter("@MaMau", bg.MaMau);
            sqlP[5] = new SqlParameter("@MaNSX", bg.MaNSX);
            sqlP[6] = new SqlParameter("@SoLuong", bg.SoLuong);
            if (bg.DonGiaNhap == 0)
            {
                sqlP[7] = new SqlParameter("@DonGiaNhap", SqlDbType.BigInt);
                sqlP[7].Value = DBNull.Value;
            }
            else sqlP[7] = new SqlParameter("@DonGiaNhap", bg.DonGiaNhap);
            if (bg.DonGiaNhap == 0)
            {
                sqlP[8] = new SqlParameter("@DonGiaBan", SqlDbType.BigInt);
                sqlP[8].Value = DBNull.Value;
            }
            else sqlP[8] = new SqlParameter("@DonGiaBan", bg.DonGiaBan);
            sqlP[9] = new SqlParameter("@ThoiGianBaoHanh", bg.ThoiGianBH);
            if (bg.Anh == null)
            {
                sqlP[10] = new SqlParameter("@Anh", SqlDbType.Image);
                sqlP[10].Value = DBNull.Value;
            }
            else sqlP[10] = new SqlParameter("@Anh", bg.Anh);
            if (bg.GhiChu == null)
            {
                sqlP[11] = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
                sqlP[11].Value = DBNull.Value;
            }
            else sqlP[11] = new SqlParameter("@GhiChu", bg.GhiChu);
            return dalGeneric.execNonQuery("insertBinhGa",sqlP);
        }

        public bool Edit(DTOBinhGa bg)
        {
            SqlParameter[] sqlP = new SqlParameter[12];
            sqlP[0] = new SqlParameter("@MaBinh", bg.MaBinh);
            sqlP[1] = new SqlParameter("@TenBinh", bg.TenBinh);
            sqlP[2] = new SqlParameter("@MaLoai", bg.MaLoai);
            sqlP[3] = new SqlParameter("@MaMau", bg.MaMau);
            sqlP[4] = new SqlParameter("@MaKL", bg.MaKL);
            sqlP[5] = new SqlParameter("@MaNSX", bg.MaNSX);
            sqlP[6] = new SqlParameter("@SoLuong", bg.SoLuong);
            if (bg.DonGiaNhap == 0)
            {
                sqlP[7] = new SqlParameter("@DonGiaNhap", SqlDbType.Int);
                sqlP[7].Value = DBNull.Value;
            }
            else sqlP[7] = new SqlParameter("@DonGiaNhap", bg.DonGiaNhap);
            if (bg.DonGiaNhap == 0)
            {
                sqlP[8] = new SqlParameter("@DonGiaBan", SqlDbType.Int);
                sqlP[8].Value = DBNull.Value;
            }
            else sqlP[8] = new SqlParameter("@DonGiaBan", bg.DonGiaBan);
            sqlP[9] = new SqlParameter("@ThoiGianBaoHanh", bg.ThoiGianBH);
            if(bg.Anh == null)
            {
                sqlP[10] = new SqlParameter("@Anh", SqlDbType.Image);
                sqlP[10].Value = DBNull.Value;
            }
            else sqlP[10] = new SqlParameter("@Anh", bg.Anh);
            if (bg.GhiChu == null)
            {
                sqlP[11] = new SqlParameter("@GhiChu", SqlDbType.NVarChar);
                sqlP[11].Value = DBNull.Value;
            }
            else sqlP[11] = new SqlParameter("@GhiChu", bg.GhiChu);
            return dalGeneric.execNonQuery("updateBinhGa", sqlP);
        }

        public bool Delete(string maBinh)
        {
            SqlParameter[] sqlP = new SqlParameter[1];
            sqlP[0] = new SqlParameter("@MaBinh", maBinh);
            
            return dalGeneric.execNonQuery("deleteBinhGa", sqlP);
        }
    }
}
