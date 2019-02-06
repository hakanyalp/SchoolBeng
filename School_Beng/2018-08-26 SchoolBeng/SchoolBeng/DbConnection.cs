using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SchoolBeng
{
    class DbConnection
    {
        SqlConnection connect = new SqlConnection("Data Source = .; Initial Catalog = School_Beng; Integrated Security = True");

        public void InsertBeng(Beng beng)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Insert Into Beng (ID, path_Number, hour, minute, monday, tuesday, wednesday, thursday, friday, saturday, sunday) Values('" + beng.ID + "', '" + beng.path_number + "', '" + beng.time.hour + "', '" + beng.time.minute + "', '" + beng.time.monday + "', '" + beng.time.tuesday + "', '" + beng.time.wednesday + "', '" + beng.time.thursday + "', '" + beng.time.friday + "', '" + beng.time.saturday + "', '" + beng.time.sunday + "')";
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void InsertMusic(Music music)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Insert Into Music (ID, path, name) Values('" + music.ID + "', '" + music.path + "', '" + music.music_name + "')";
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void UpdateBeng(int ID, int path_Number)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Update Beng Set path_Number=" + path_Number + " Where ID=" + ID;
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void UpdateBeng(int ID, Time time)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;

            int mon, tue, wed, thu, fri, sat, sun;
            if (time.monday == true)
                mon = 1;
            else
                mon = 0;
            if (time.tuesday == true)
                tue = 1;
            else
                tue = 0;
            if (time.wednesday == true)
                wed = 1;
            else
                wed = 0;
            if (time.thursday == true)
                thu = 1;
            else
                thu = 0;
            if (time.friday == true)
                fri = 1;
            else
                fri = 0;
            if (time.saturday == true)
                sat = 1;
            else
                sat = 0;
            if (time.sunday == true)
                sun = 1;
            else
                sun = 0;

            //command.CommandText = "Update Beng Set monday=" + time.monday + " Where ID=" + ID;
            command.CommandText = "Update Beng Set monday=" + mon + ", tuesday=" + tue + ", wednesday=" + wed + ", thursday=" + thu + ", friday=" + fri + ", saturday=" + sat + ", sunday=" + sun + " Where ID=" + ID;
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public List<Beng> GetBengs()
        {
            List<Beng> Bengs = new List<Beng>();

            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Select * From Beng";
            connect.Open();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                Beng beng = new Beng();
                beng.ID = Convert.ToInt32(read["ID"]);
                beng.path_number = Convert.ToInt32(read["path_Number"]);

                beng.time.hour = Convert.ToInt32(read["hour"].ToString().Trim());
                beng.time.minute = Convert.ToInt32(read["minute"].ToString().Trim());
                beng.time.monday = (bool)read["monday"];
                beng.time.tuesday = (bool)read["tuesday"];
                beng.time.wednesday = (bool)read["wednesday"];
                beng.time.thursday = (bool)read["thursday"];
                beng.time.friday = (bool)read["friday"];
                beng.time.saturday = (bool)read["saturday"];
                beng.time.sunday = (bool)read["sunday"];

                Bengs.Add(beng);
            }

            connect.Close();
            return Bengs;
        }

        public List<Music> GetMusic()
        {
            List<Music> Musics = new List<Music>();

            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Select * From Music";
            connect.Open();
            SqlDataReader read = command.ExecuteReader();

            while (read.Read())
            {
                Music music = new Music();
                music.ID = Convert.ToInt32(read["ID"]);
                music.path = read["path"].ToString().Trim();
                music.music_name = read["name"].ToString().Trim();

                Musics.Add(music);
            }

            connect.Close();
            return Musics;
        }

        public void DeleteBeng(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Delete From Beng Where ID=" + ID;
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void DeleteMusic(int ID)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Delete From Music Where ID=" + ID;
            connect.Open();
            command.ExecuteNonQuery();
            connect.Close();
        }

        public void DeleteAll()
        {
            SqlCommand command = new SqlCommand();
            command.Connection = connect;
            command.CommandText = "Delete From Beng";
            connect.Open();
            command.ExecuteNonQuery();
            command.CommandText = "Delete From Music";
            command.ExecuteNonQuery();
            connect.Close();
        }
    }
}
