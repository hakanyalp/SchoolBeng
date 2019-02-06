using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolBeng
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Beng> Bengs = new List<Beng>();
        List<Music> Musics = new List<Music>();

        private void Form1_Load(object sender, EventArgs e)
        {
            String tarih = DateTime.Now.Day.ToString() + " / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString() + "\n" + String.Format("{0:dddd}", DateTime.Today);
            lblDate.Text = tarih;
            timer1.Enabled = true;

            int last_Count;
            if (Musics.Count != 0)
                last_Count = Musics[Musics.Count - 1].ID + 1;
            else
                last_Count = 1;

            Music music = new Music(last_Count, "", "");
            Musics.Add(music);
            lstNotificationSound.Items.Add("Ses Kapalı");

            try
            {
                DbConnection db = new DbConnection();
                List<Beng> temp_Beng = new List<Beng>();
                List<Music> temp_Musics = new List<Music>();
                temp_Beng = db.GetBengs();
                temp_Musics = db.GetMusic();
                for (int i = 0; i < temp_Beng.Count; i++)       // Buralarda ID karışabilir!!
                {
                    Bengs.Add(temp_Beng[i]);
                    lstBengTimes.Items.Add(Bengs[i].time.hour + " : " + Bengs[i].time.minute);
                }
                for (int i = 0; i < temp_Musics.Count; i++)
                {
                    Musics.Add(temp_Musics[i]);
                    lstNotificationSound.Items.Add(temp_Musics[i].music_name);
                }
            }
            catch
            {
                MessageBox.Show("Veritabanındaki tüm veriler çekilirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }

            wmp.settings.volume = 100;
        }

        private void btnAddBeng_Click(object sender, EventArgs e)
        {
            grpSaveTime.Visible = true;
            btnAddBeng.Enabled = false;
            btnAddMusic.Enabled = false;
            btnDelBeng.Enabled = false;

            cbHour.Text = "";
            cbMinute.Text = "";
            cbHour.Items.Clear();
            cbMinute.Items.Clear();

            cbHour.Focus();
            for (int i = 0; i < 24; i++)
            {
                cbHour.Items.Add(i);
            }
            for (int i = 0; i < 56; i = i + 5)
            {
                cbMinute.Items.Add(i);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpSaveTime.Visible = false;
            btnAddBeng.Enabled = true;
            btnAddMusic.Enabled = true;
            btnDelBeng.Enabled = true;
        }

        private void btnSaveTime_Click(object sender, EventArgs e)
        {
            int hour, minute;
            try
            {
                hour = Convert.ToInt32(cbHour.Text);
                minute = Convert.ToInt32(cbMinute.Text);
                if (hour >= 0 && hour < 24 && minute >= 0 && minute < 60)
                {
                    Time time = new Time();
                    time.hour = hour;
                    time.minute = minute;

                    int last_Count;
                    if (Bengs.Count != 0)
                        last_Count = Bengs[Bengs.Count - 1].ID + 1;
                    else
                        last_Count = 1;

                    try
                    {
                        Beng beng = new Beng(last_Count, time, 0);
                        Bengs.Add(beng);
                        DbConnection db = new DbConnection();
                        db.InsertBeng(beng);
                    }
                    catch
                    {
                        MessageBox.Show("Veritabanına zil sesi zamanı eklemede sorun var! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
                    }

                    lstBengTimes.Items.Add(cbHour.Text + " : " + cbMinute.Text);
                    errorProvider1.Clear();

                    grpSaveTime.Visible = false;
                    btnAddBeng.Enabled = true;
                    btnAddMusic.Enabled = true;
                    btnDelBeng.Enabled = true;
                }
                else
                {
                    errorProvider1.SetError(cbHour, "Saat formatına uygun değerler girin! (Saat -> 0 - 23 | Dakika -> 0 - 59)");
                }
            }
            catch
            {
                errorProvider1.SetError(cbHour, "Girilen değerlerde hata var!");
            }
        }

        private void btnAddMusic_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | WMAs | *.wma";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
                {
                    int last_Count;
                    if (Musics.Count != 0)
                        last_Count = Musics[Musics.Count - 1].ID + 1;
                    else
                        last_Count = 1;

                    try
                    {
                        Music music = new Music(last_Count, openFileDialog1.FileNames[i].ToString(), openFileDialog1.SafeFileNames[i].ToString());
                        Musics.Add(music);
                        DbConnection db = new DbConnection();
                        db.InsertMusic(music);
                    }
                    catch
                    {
                        MessageBox.Show("Veritabanına müzik eklemede sorun var! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
                    }

                    lstNotificationSound.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                }
            }
        }

        private void btnDelBeng_Click(object sender, EventArgs e)
        {
            btnAddBeng.Enabled = false;
            btnAddMusic.Enabled = false;
            btnDelBeng.Enabled = false;
            pnlSelectedDays.Visible = false;
            lblDays.Visible = false;
            lstBengTimes.Visible = false;
            cLstBengTime.Visible = true;
            btnOK.Visible = true;
            cLstBengTime.Items.Clear();
            for (int i = 0; i < lstBengTimes.Items.Count; i++)
            {
                cLstBengTime.Items.Add(lstBengTimes.Items[i]);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            btnOK.Visible = false;
            cLstBengTime.Visible = false;
            lstBengTimes.Visible = true;
            btnAddBeng.Enabled = true;
            btnAddMusic.Enabled = true;
            btnDelBeng.Enabled = true;
            lstBengTimes.Items.Clear();

            try
            {
                List<int> temp_Deleting_ID = new List<int>();
                foreach (int indexChecked in cLstBengTime.CheckedIndices)   // Bengs içinden direk silindiğinde index kayması oluyor, sorunun çözümü için geçici listede silinecek idler tutuluyor.
                {
                    temp_Deleting_ID.Add(Bengs[indexChecked].ID);
                }
                for (int i = 0; i < temp_Deleting_ID.Count; i++)
                {
                    DbConnection db = new DbConnection();
                    db.DeleteBeng(temp_Deleting_ID[i]);
                }
                foreach (int indexChecked in cLstBengTime.CheckedIndices)
                {
                    Bengs.RemoveAt(indexChecked);
                }
            }
            catch
            {
                MessageBox.Show("Veritabanından zil sesi silmede sorun var! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }

            for (int i = 0; i < cLstBengTime.Items.Count; i++)
            {
                if (!cLstBengTime.GetItemChecked(i))
                {
                    lstBengTimes.Items.Add(cLstBengTime.Items[i]);
                }
            }
        }

        private void btnDelDb_Click(object sender, EventArgs e)
        {
            try
            {
                DbConnection db = new DbConnection();
                db.DeleteAll();
                lstBengTimes.Items.Clear();
                lstNotificationSound.Items.Clear();
                Bengs.Clear();
                Musics.Clear();
                pnlSelectedDays.Visible = false;
                lblDays.Visible = false;

                int last_Count;
                if (Musics.Count != 0)
                    last_Count = Musics[Musics.Count - 1].ID + 1;
                else
                    last_Count = 1;

                Music music = new Music(last_Count, "", "");
                Musics.Add(music);
                lstNotificationSound.Items.Add("Ses Kapalı");
            }
            catch
            {
                MessageBox.Show("Veritabanındaki tüm veriler silinirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHour.Text = DateTime.Now.Hour.ToString();
            lblMinute.Text = DateTime.Now.Minute.ToString();
            lblSecond.Text = DateTime.Now.Second.ToString();
            lblDate.Text = DateTime.Now.Day.ToString() + " / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString() + "\n" + String.Format("{0:dddd}", DateTime.Today);
            string day = returnDay(String.Format("{0:dddd}", DateTime.Today));

            if (lblHour.Text == "0" && lblMinute.Text == "0" && lblSecond.Text == "0")
            {
                lblDate.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + "\n" + String.Format("{0:dddd}", DateTime.Today);
            }
            for (int i = 0; i < Bengs.Count; i++)
            {
                if (Bengs[i].time.hour == DateTime.Now.Hour && Bengs[i].time.minute == DateTime.Now.Minute && Bengs[i].time.returnDay(day) && DateTime.Now.Second == 0)
                {
                    try
                    {
                        wmp.URL = Musics[Bengs[i].path_number].path.ToString();
                    }
                    catch
                    {
                        wmp.Ctlcontrols.stop();
                        MessageBox.Show("Anons sesi çalınamıyor! Ses bilgisayardan silinmiş olabilir.");
                    }
                }
            }
        }

        private string returnDay(string day)  // burayı sayıya bağlı şekilde dönüştür
        {
            if (day == "Pazartesi" || day == "Monday")
                return "monday";
            else if (day == "Salı" || day == "Tuesday")
                return "tuesday";
            else if (day == "Çarşamba" || day == "Wednesday")
                return "wednesday";
            else if (day == "Perşembe" || day == "Thursday")
                return "thursday";
            else if (day == "Cuma" || day == "Friday")
                return "friday";
            else if (day == "Cumartesi" || day == "Saturday")
                return "saturday";
            else if (day == "Pazar" || day == "Sunday")
                return "sunday";
            else
                return "";
        }

        private void cbHour_TextChanged(object sender, EventArgs e)
        {
            if (cbHour.Text.Length == 2)
                cbMinute.Focus();
        }

        private void cbMinute_TextChanged(object sender, EventArgs e)
        {
            if (cbMinute.Text.Length == 2)
                btnSaveTime.Focus();
        }

        private void lstBengTimes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonday.Checked = Bengs[lstBengTimes.SelectedIndex].time.monday;
            cbTuesday.Checked = Bengs[lstBengTimes.SelectedIndex].time.tuesday;
            cbWednesday.Checked = Bengs[lstBengTimes.SelectedIndex].time.wednesday;
            cbThursday.Checked = Bengs[lstBengTimes.SelectedIndex].time.thursday;
            cbFriday.Checked = Bengs[lstBengTimes.SelectedIndex].time.friday;
            cbSaturday.Checked = Bengs[lstBengTimes.SelectedIndex].time.saturday;
            cbSunday.Checked = Bengs[lstBengTimes.SelectedIndex].time.sunday;

            pnlSelectedDays.Visible = true;
            lblDays.Visible = true;

            lstNotificationSound.SelectedIndex = Bengs[lstBengTimes.SelectedIndex].path_number;

        }

        private void lstNotificationSound_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBengTimes.SelectedIndex != -1)
            {
                try
                {
                    DbConnection db = new DbConnection();
                    Bengs[lstBengTimes.SelectedIndex].path_number = lstNotificationSound.SelectedIndex;
                    db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].path_number);
                }
                catch
                {
                    MessageBox.Show("Veritabanında zil sesi değiştirilirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
                }
            }
        }

        private void cbMonday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.monday = cbMonday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbTuesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.tuesday = cbTuesday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbWednesday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.wednesday = cbWednesday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbThursday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.thursday = cbThursday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbFriday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.friday = cbFriday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbSaturday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.saturday = cbSaturday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }

        private void cbSunday_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Bengs[lstBengTimes.SelectedIndex].time.sunday = cbSunday.Checked;
                DbConnection db = new DbConnection();
                db.UpdateBeng(Bengs[lstBengTimes.SelectedIndex].ID, Bengs[lstBengTimes.SelectedIndex].time);
            }
            catch
            {
                MessageBox.Show("Veritabanında zil sesinin günleri güncellenirken hata oluştu! \"hakanyavuzalp@gmail.com\" mail adresine sorunu bildirin.");
            }
        }
    }
}
