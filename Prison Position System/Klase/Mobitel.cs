using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Prison_Position_System.Klase
{
    class Mobitel
    {
        public int IdMobitela { get; set; }
        public int Dopuštenost { get; set; }

        public static void DodavanjeMobitela(int IdMobitela, int Dopustenost)
        {
            string sql = $"INSERT INTO Mobitel (IdMobitela, Dopuštenost ) VALUES({IdMobitela},  {Dopustenost})";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static List<Mobitel> DohvatiMobitele()
        {
            List<Mobitel> mobiteli = new List<Mobitel>();
            string sql = "SELECT * FROM Mobitel";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Mobitel mobitel = CreateObject(reader);
                mobiteli.Add(mobitel);
            }
            reader.Close();
            DB.CloseConnection();
            return mobiteli;
        }

        private static Mobitel CreateObject(SqlDataReader reader)
        {
            int IdMobitela = int.Parse(reader["IdMobitela"].ToString());
            int Dopuštenost = int.Parse(reader["Dopuštenost"].ToString());

            var mobitel = new Mobitel
            {
                IdMobitela = IdMobitela,
                Dopuštenost = Dopuštenost

            };
            return mobitel;
        }

        public static void PromjenaDopuštenostiFrom1To0(int IdMobitela)
        {
            string sql = $"Update Mobitel set Dopuštenost = 0 Where IdMobitela = {IdMobitela}";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void PromjenaDopuštenostiFrom0To1(int IdMobitela)
        {
            string sql = $"Update Mobitel set Dopuštenost = 1 Where IdMobitela = {IdMobitela}";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
