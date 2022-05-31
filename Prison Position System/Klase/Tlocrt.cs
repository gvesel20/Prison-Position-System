using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;

namespace Prison_Position_System.Klase
{
    class Tlocrt
    {
        public int IdTlocrta { get; set; }
        public int Širina { get; set; }
        public int Dužina { get; set; }
        public DateTime DatumDodavanja { get; set; }
        public int Aktivan { get; set; }

        public static void DodavanjeTlocrta(int IdTlocrta, int Širina, int Dužina, int Aktivan)
        {
            string sql = $"INSERT INTO Tlocrt (IdTlocrta ,Širina ,Dužina ,DatumDodavanja ,Aktivan ) VALUES({IdTlocrta}, {Širina},{Dužina}, GETDATE(), {Aktivan})";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }

        public static void UpdateAktivnostiTlocrta()
        {
            string sql = $"Update Tlocrt Set Aktivan = 0 Where Aktivan = 1";
            DB.SetConfiguration("gvesel20_DB", "gvesel20", "0WrhkI%");
            DB.OpenConnection();
            DB.ExecuteCommand(sql);
            DB.CloseConnection();
        }
    }
}
