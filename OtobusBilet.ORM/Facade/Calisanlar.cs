using OtobusBilet.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtobusBilet.ORM.Facade
{
    public class Calisanlar
    {
        //Select metodu
        public static DataTable Select()
        {
            SqlDataAdapter adp = new SqlDataAdapter("Select * from Calisan", Tools.Baglanti);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;

        }

        //Insert metodu
        public static bool Insert(Calisan c)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "insert Calisan (Adi, Soyadi, Tcno, IseBaslamaTarihi, Cinsiyet) values(@adi, @soyadi, @tcno, @iseBaslamaTarihi, @cinsiyet)";
            komut.Parameters.AddWithValue("@adi", c.Adi);
            komut.Parameters.AddWithValue("@soyadi", c.Soyadi);
            komut.Parameters.AddWithValue("@tcno", c.Tcno);
            komut.Parameters.AddWithValue("@iseBaslamaTarihi", c.IseBaslamaTarihi);
            komut.Parameters.AddWithValue("@cinsiyet", c.Cinsiyet);

            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        //Update metodu
        public static bool Update(Calisan c)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "update Calisan set Adi=@adi, Soyadi= @soyadi, Tcno=@tcno, IseBaslamaTarihi=@iseBaslamaTarihi, Cinsiyet=@cinsiyet where Id=@id";
            komut.Parameters.AddWithValue("@adi", c.Adi);
            komut.Parameters.AddWithValue("@soyadi", c.Soyadi);
            komut.Parameters.AddWithValue("@tcno", c.Tcno);
            komut.Parameters.AddWithValue("@iseBaslamaTarihi", c.IseBaslamaTarihi);
            komut.Parameters.AddWithValue("@cinsiyet", c.Cinsiyet);

            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);
        }

        //Delete metodu
        public static bool Delete(Calisan c)
        {
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "delete from Calisan where Id=@id";
            komut.Parameters.AddWithValue("@id", c.Id);
            komut.Connection = Tools.Baglanti;
            return Tools.ExecuteNonQuery(komut);

        }

    }
}
