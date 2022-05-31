using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Prison_Position_System.Klase
{
    class Pojava
    {
        public int IdPojave { get; set; }
        public int KoordinataX { get; set; }
        public int KoordinataY { get; set; }
        public int IdTlocrta { get; set; }
        public int IdMobitela { get; set; }
        public DateTime DatumPojave { get; set; }

        public static void DodavanjePojave(int KoordinataX, int KoordinataY, int IdTlocrta, int IdMobitela)
        {
            string sql = $"INSERT INTO PojavaMobitela (KoordinataX ,KoordinataY ,IdTlocrta ,IdMobitela, DatumPojave ) VALUES({KoordinataX}, {KoordinataY}, {IdTlocrta}, {IdMobitela}, GETDATE())";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static int DohvacanjeIdTlocrta()
        {
            string sql = $"Select IdTlocrta From Tlocrt Where Aktivan = 1";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            reader.Read();
            int IdTlocrta = int.Parse(reader["IdTlocrta"].ToString());
            reader.Close();
            return IdTlocrta;

        }

        public static int DohvacanjeIdMobitela(int IdMobitela)
        {
            string sql = $"Select IdMobitela From Mobitel Where IdMobitela = {IdMobitela}";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                return IdMobitela;
            }
            else
            {
                return 0;
            }
        }

        public static List<Pojava> DohvatiPojave()
        {
            List<Pojava> pojave = new List<Pojava>();
            string sql = "SELECT * FROM PojavaMobitela";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Pojava pojava = CreateObject(reader);
                pojave.Add(pojava);
            }
            reader.Close();
            DB.CloseConnection();
            return pojave;
        }

        private static Pojava CreateObject(SqlDataReader reader)
        {
            int IdPojave = int.Parse(reader["IdPojave"].ToString());
            int KoordinataX = int.Parse(reader["KoordinataX"].ToString());
            int KoordinataY = int.Parse(reader["KoordinataY"].ToString());
            int IdTlocrta = int.Parse(reader["IdTlocrta"].ToString());
            int IdMobitela = int.Parse(reader["IdMobitela"].ToString());
            DateTime DatumPojave = DateTime.Parse(reader["DatumPojave"].ToString());
            var pojava = new Pojava
            {
                IdPojave = IdPojave,
                KoordinataX = KoordinataX,
                KoordinataY = KoordinataY,
                IdTlocrta = IdTlocrta,
                IdMobitela = IdMobitela,
                DatumPojave = DatumPojave
            };
            return pojava;
        }

        public static void BrisanjePojave(int IdPojave)
        {
            string sql = $"Delete From PojavaMobitela Where IdPojave = {IdPojave}";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Pojava> DohvatiPojavePoIdMobitela(int IdMobitela)
        {
            List<Pojava> pojave = new List<Pojava>();
            string sql = $"SELECT * FROM PojavaMobitela Where IdMobitela = {IdMobitela}";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Pojava pojava = CreateObject(reader);
                pojave.Add(pojava);
            }
            reader.Close();
            DB.CloseConnection();
            return pojave;
        }
    }
}
