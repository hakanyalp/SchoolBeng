namespace SchoolBeng
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpClock = new System.Windows.Forms.GroupBox();
            this.lblTwoDots2 = new System.Windows.Forms.Label();
            this.lblTwoDots1 = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.btnDelBeng = new System.Windows.Forms.Button();
            this.btnAddMusic = new System.Windows.Forms.Button();
            this.btnAddBeng = new System.Windows.Forms.Button();
            this.lstBengTimes = new System.Windows.Forms.ListBox();
            this.pnlSelectedDays = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMonday = new System.Windows.Forms.CheckBox();
            this.cbSunday = new System.Windows.Forms.CheckBox();
            this.cbTuesday = new System.Windows.Forms.CheckBox();
            this.cbSaturday = new System.Windows.Forms.CheckBox();
            this.cbWednesday = new System.Windows.Forms.CheckBox();
            this.cbFriday = new System.Windows.Forms.CheckBox();
            this.cbThursday = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.grpSaveTime = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveTime = new System.Windows.Forms.Button();
            this.cbMinute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHour = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.wmp = new AxWMPLib.AxWindowsMediaPlayer();
            this.lstNotificationSound = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cLstBengTime = new System.Windows.Forms.CheckedListBox();
            this.btnDelDb = new System.Windows.Forms.Button();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblBengs = new System.Windows.Forms.Label();
            this.grpClock.SuspendLayout();
            this.pnlSelectedDays.SuspendLayout();
            this.grpSaveTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).BeginInit();
            this.SuspendLayout();
            // 
            // grpClock
            // 
            this.grpClock.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grpClock.Controls.Add(this.lblTwoDots2);
            this.grpClock.Controls.Add(this.lblTwoDots1);
            this.grpClock.Controls.Add(this.lblSecond);
            this.grpClock.Controls.Add(this.lblMinute);
            this.grpClock.Controls.Add(this.lblDate);
            this.grpClock.Controls.Add(this.lblHour);
            this.grpClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpClock.Location = new System.Drawing.Point(42, 243);
            this.grpClock.Name = "grpClock";
            this.grpClock.Size = new System.Drawing.Size(277, 152);
            this.grpClock.TabIndex = 25;
            this.grpClock.TabStop = false;
            this.grpClock.Text = "SAAT";
            // 
            // lblTwoDots2
            // 
            this.lblTwoDots2.AutoSize = true;
            this.lblTwoDots2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTwoDots2.Location = new System.Drawing.Point(171, 37);
            this.lblTwoDots2.Name = "lblTwoDots2";
            this.lblTwoDots2.Size = new System.Drawing.Size(22, 31);
            this.lblTwoDots2.TabIndex = 23;
            this.lblTwoDots2.Text = ":";
            // 
            // lblTwoDots1
            // 
            this.lblTwoDots1.AutoSize = true;
            this.lblTwoDots1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTwoDots1.Location = new System.Drawing.Point(81, 36);
            this.lblTwoDots1.Name = "lblTwoDots1";
            this.lblTwoDots1.Size = new System.Drawing.Size(22, 31);
            this.lblTwoDots1.TabIndex = 22;
            this.lblTwoDots1.Text = ":";
            // 
            // lblSecond
            // 
            this.lblSecond.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecond.Location = new System.Drawing.Point(203, 37);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(44, 31);
            this.lblSecond.TabIndex = 20;
            this.lblSecond.Text = "00";
            this.lblSecond.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMinute
            // 
            this.lblMinute.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMinute.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMinute.Location = new System.Drawing.Point(114, 37);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(44, 31);
            this.lblMinute.TabIndex = 19;
            this.lblMinute.Text = "00";
            this.lblMinute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(26, 79);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(221, 62);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "--";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHour
            // 
            this.lblHour.BackColor = System.Drawing.Color.RoyalBlue;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHour.Location = new System.Drawing.Point(28, 37);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(44, 31);
            this.lblHour.TabIndex = 18;
            this.lblHour.Text = "00";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelBeng
            // 
            this.btnDelBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelBeng.Location = new System.Drawing.Point(42, 174);
            this.btnDelBeng.Name = "btnDelBeng";
            this.btnDelBeng.Size = new System.Drawing.Size(123, 43);
            this.btnDelBeng.TabIndex = 28;
            this.btnDelBeng.Text = "Anons Sil";
            this.btnDelBeng.UseVisualStyleBackColor = true;
            this.btnDelBeng.Click += new System.EventHandler(this.btnDelBeng_Click);
            // 
            // btnAddMusic
            // 
            this.btnAddMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddMusic.Location = new System.Drawing.Point(42, 109);
            this.btnAddMusic.Name = "btnAddMusic";
            this.btnAddMusic.Size = new System.Drawing.Size(123, 59);
            this.btnAddMusic.TabIndex = 27;
            this.btnAddMusic.Text = "Anons Sesi Ekle";
            this.btnAddMusic.UseVisualStyleBackColor = true;
            this.btnAddMusic.Click += new System.EventHandler(this.btnAddMusic_Click);
            // 
            // btnAddBeng
            // 
            this.btnAddBeng.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddBeng.Location = new System.Drawing.Point(42, 44);
            this.btnAddBeng.Name = "btnAddBeng";
            this.btnAddBeng.Size = new System.Drawing.Size(123, 59);
            this.btnAddBeng.TabIndex = 26;
            this.btnAddBeng.Text = "Anons Saati Oluştur";
            this.btnAddBeng.UseVisualStyleBackColor = true;
            this.btnAddBeng.Click += new System.EventHandler(this.btnAddBeng_Click);
            // 
            // lstBengTimes
            // 
            this.lstBengTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBengTimes.FormattingEnabled = true;
            this.lstBengTimes.ItemHeight = 24;
            this.lstBengTimes.Location = new System.Drawing.Point(411, 40);
            this.lstBengTimes.Name = "lstBengTimes";
            this.lstBengTimes.Size = new System.Drawing.Size(125, 244);
            this.lstBengTimes.TabIndex = 29;
            this.lstBengTimes.SelectedIndexChanged += new System.EventHandler(this.lstBengTimes_SelectedIndexChanged);
            // 
            // pnlSelectedDays
            // 
            this.pnlSelectedDays.Controls.Add(this.label1);
            this.pnlSelectedDays.Controls.Add(this.cbMonday);
            this.pnlSelectedDays.Controls.Add(this.cbSunday);
            this.pnlSelectedDays.Controls.Add(this.cbTuesday);
            this.pnlSelectedDays.Controls.Add(this.cbSaturday);
            this.pnlSelectedDays.Controls.Add(this.cbWednesday);
            this.pnlSelectedDays.Controls.Add(this.cbFriday);
            this.pnlSelectedDays.Controls.Add(this.cbThursday);
            this.pnlSelectedDays.Location = new System.Drawing.Point(536, 40);
            this.pnlSelectedDays.Name = "pnlSelectedDays";
            this.pnlSelectedDays.Size = new System.Drawing.Size(130, 244);
            this.pnlSelectedDays.TabIndex = 30;
            this.pnlSelectedDays.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aktif günleri işaretle";
            // 
            // cbMonday
            // 
            this.cbMonday.AutoSize = true;
            this.cbMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMonday.Location = new System.Drawing.Point(9, 54);
            this.cbMonday.Name = "cbMonday";
            this.cbMonday.Size = new System.Drawing.Size(77, 19);
            this.cbMonday.TabIndex = 8;
            this.cbMonday.Text = "Pazartesi";
            this.cbMonday.UseVisualStyleBackColor = true;
            this.cbMonday.CheckedChanged += new System.EventHandler(this.cbMonday_CheckedChanged);
            // 
            // cbSunday
            // 
            this.cbSunday.AutoSize = true;
            this.cbSunday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSunday.Location = new System.Drawing.Point(8, 204);
            this.cbSunday.Name = "cbSunday";
            this.cbSunday.Size = new System.Drawing.Size(58, 19);
            this.cbSunday.TabIndex = 14;
            this.cbSunday.Text = "Pazar";
            this.cbSunday.UseVisualStyleBackColor = true;
            this.cbSunday.CheckedChanged += new System.EventHandler(this.cbSunday_CheckedChanged);
            // 
            // cbTuesday
            // 
            this.cbTuesday.AutoSize = true;
            this.cbTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbTuesday.Location = new System.Drawing.Point(9, 79);
            this.cbTuesday.Name = "cbTuesday";
            this.cbTuesday.Size = new System.Drawing.Size(47, 19);
            this.cbTuesday.TabIndex = 9;
            this.cbTuesday.Text = "Salı";
            this.cbTuesday.UseVisualStyleBackColor = true;
            this.cbTuesday.CheckedChanged += new System.EventHandler(this.cbTuesday_CheckedChanged);
            // 
            // cbSaturday
            // 
            this.cbSaturday.AutoSize = true;
            this.cbSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbSaturday.Location = new System.Drawing.Point(8, 179);
            this.cbSaturday.Name = "cbSaturday";
            this.cbSaturday.Size = new System.Drawing.Size(82, 19);
            this.cbSaturday.TabIndex = 13;
            this.cbSaturday.Text = "Cumartesi";
            this.cbSaturday.UseVisualStyleBackColor = true;
            this.cbSaturday.CheckedChanged += new System.EventHandler(this.cbSaturday_CheckedChanged);
            // 
            // cbWednesday
            // 
            this.cbWednesday.AutoSize = true;
            this.cbWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbWednesday.Location = new System.Drawing.Point(8, 104);
            this.cbWednesday.Name = "cbWednesday";
            this.cbWednesday.Size = new System.Drawing.Size(83, 19);
            this.cbWednesday.TabIndex = 10;
            this.cbWednesday.Text = "Çarşamba";
            this.cbWednesday.UseVisualStyleBackColor = true;
            this.cbWednesday.CheckedChanged += new System.EventHandler(this.cbWednesday_CheckedChanged);
            // 
            // cbFriday
            // 
            this.cbFriday.AutoSize = true;
            this.cbFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbFriday.Location = new System.Drawing.Point(8, 154);
            this.cbFriday.Name = "cbFriday";
            this.cbFriday.Size = new System.Drawing.Size(59, 19);
            this.cbFriday.TabIndex = 12;
            this.cbFriday.Text = "Cuma";
            this.cbFriday.UseVisualStyleBackColor = true;
            this.cbFriday.CheckedChanged += new System.EventHandler(this.cbFriday_CheckedChanged);
            // 
            // cbThursday
            // 
            this.cbThursday.AutoSize = true;
            this.cbThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbThursday.Location = new System.Drawing.Point(8, 129);
            this.cbThursday.Name = "cbThursday";
            this.cbThursday.Size = new System.Drawing.Size(83, 19);
            this.cbThursday.TabIndex = 11;
            this.cbThursday.Text = "Perşembe";
            this.cbThursday.UseVisualStyleBackColor = true;
            this.cbThursday.CheckedChanged += new System.EventHandler(this.cbThursday_CheckedChanged);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Tomato;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Location = new System.Drawing.Point(410, 306);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(129, 43);
            this.btnOK.TabIndex = 31;
            this.btnOK.Text = "TAMAMLA";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Visible = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // grpSaveTime
            // 
            this.grpSaveTime.Controls.Add(this.btnCancel);
            this.grpSaveTime.Controls.Add(this.btnSaveTime);
            this.grpSaveTime.Controls.Add(this.cbMinute);
            this.grpSaveTime.Controls.Add(this.label2);
            this.grpSaveTime.Controls.Add(this.cbHour);
            this.grpSaveTime.Controls.Add(this.label5);
            this.grpSaveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpSaveTime.Location = new System.Drawing.Point(190, 40);
            this.grpSaveTime.Name = "grpSaveTime";
            this.grpSaveTime.Size = new System.Drawing.Size(215, 170);
            this.grpSaveTime.TabIndex = 32;
            this.grpSaveTime.TabStop = false;
            this.grpSaveTime.Text = "Zaman Bilgisini Girin";
            this.grpSaveTime.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(31, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 25);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveTime
            // 
            this.btnSaveTime.Location = new System.Drawing.Point(89, 126);
            this.btnSaveTime.Name = "btnSaveTime";
            this.btnSaveTime.Size = new System.Drawing.Size(71, 24);
            this.btnSaveTime.TabIndex = 5;
            this.btnSaveTime.Text = "Kaydet";
            this.btnSaveTime.UseVisualStyleBackColor = true;
            this.btnSaveTime.Click += new System.EventHandler(this.btnSaveTime_Click);
            // 
            // cbMinute
            // 
            this.cbMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbMinute.FormattingEnabled = true;
            this.cbMinute.Location = new System.Drawing.Point(89, 85);
            this.cbMinute.Name = "cbMinute";
            this.cbMinute.Size = new System.Drawing.Size(71, 23);
            this.cbMinute.TabIndex = 4;
            this.cbMinute.TextChanged += new System.EventHandler(this.cbMinute_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(28, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dakika";
            // 
            // cbHour
            // 
            this.cbHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbHour.FormattingEnabled = true;
            this.cbHour.Location = new System.Drawing.Point(89, 40);
            this.cbHour.Name = "cbHour";
            this.cbHour.Size = new System.Drawing.Size(71, 23);
            this.cbHour.TabIndex = 3;
            this.cbHour.TextChanged += new System.EventHandler(this.cbHour_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(28, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // wmp
            // 
            this.wmp.Enabled = true;
            this.wmp.Location = new System.Drawing.Point(620, 304);
            this.wmp.Name = "wmp";
            this.wmp.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp.OcxState")));
            this.wmp.Size = new System.Drawing.Size(213, 45);
            this.wmp.TabIndex = 33;
            // 
            // lstNotificationSound
            // 
            this.lstNotificationSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstNotificationSound.FormattingEnabled = true;
            this.lstNotificationSound.ItemHeight = 16;
            this.lstNotificationSound.Location = new System.Drawing.Point(675, 40);
            this.lstNotificationSound.Name = "lstNotificationSound";
            this.lstNotificationSound.Size = new System.Drawing.Size(158, 244);
            this.lstNotificationSound.TabIndex = 34;
            this.lstNotificationSound.SelectedIndexChanged += new System.EventHandler(this.lstNotificationSound_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cLstBengTime
            // 
            this.cLstBengTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cLstBengTime.FormattingEnabled = true;
            this.cLstBengTime.Location = new System.Drawing.Point(410, 40);
            this.cLstBengTime.Name = "cLstBengTime";
            this.cLstBengTime.Size = new System.Drawing.Size(129, 244);
            this.cLstBengTime.TabIndex = 35;
            this.cLstBengTime.Visible = false;
            // 
            // btnDelDb
            // 
            this.btnDelDb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelDb.Location = new System.Drawing.Point(729, 415);
            this.btnDelDb.Name = "btnDelDb";
            this.btnDelDb.Size = new System.Drawing.Size(104, 23);
            this.btnDelDb.TabIndex = 36;
            this.btnDelDb.Text = "Bilgileri SİL";
            this.btnDelDb.UseVisualStyleBackColor = true;
            this.btnDelDb.Click += new System.EventHandler(this.btnDelDb_Click);
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(448, 24);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(40, 13);
            this.lblHours.TabIndex = 38;
            this.lblHours.Text = "Saatler";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(582, 24);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(38, 13);
            this.lblDays.TabIndex = 39;
            this.lblDays.Text = "Günler";
            this.lblDays.Visible = false;
            // 
            // lblBengs
            // 
            this.lblBengs.AutoSize = true;
            this.lblBengs.Location = new System.Drawing.Point(726, 24);
            this.lblBengs.Name = "lblBengs";
            this.lblBengs.Size = new System.Drawing.Size(48, 13);
            this.lblBengs.TabIndex = 40;
            this.lblBengs.Text = "Anonslar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 465);
            this.Controls.Add(this.lblBengs);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.btnDelDb);
            this.Controls.Add(this.cLstBengTime);
            this.Controls.Add(this.lstNotificationSound);
            this.Controls.Add(this.wmp);
            this.Controls.Add(this.grpSaveTime);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.pnlSelectedDays);
            this.Controls.Add(this.lstBengTimes);
            this.Controls.Add(this.btnDelBeng);
            this.Controls.Add(this.btnAddMusic);
            this.Controls.Add(this.btnAddBeng);
            this.Controls.Add(this.grpClock);
            this.Name = "Form1";
            this.Text = "Okul Anons Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpClock.ResumeLayout(false);
            this.grpClock.PerformLayout();
            this.pnlSelectedDays.ResumeLayout(false);
            this.pnlSelectedDays.PerformLayout();
            this.grpSaveTime.ResumeLayout(false);
            this.grpSaveTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpClock;
        private System.Windows.Forms.Label lblTwoDots2;
        private System.Windows.Forms.Label lblTwoDots1;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Button btnDelBeng;
        private System.Windows.Forms.Button btnAddMusic;
        private System.Windows.Forms.Button btnAddBeng;
        private System.Windows.Forms.ListBox lstBengTimes;
        private System.Windows.Forms.Panel pnlSelectedDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMonday;
        private System.Windows.Forms.CheckBox cbSunday;
        private System.Windows.Forms.CheckBox cbTuesday;
        private System.Windows.Forms.CheckBox cbSaturday;
        private System.Windows.Forms.CheckBox cbWednesday;
        private System.Windows.Forms.CheckBox cbFriday;
        private System.Windows.Forms.CheckBox cbThursday;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox grpSaveTime;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveTime;
        private System.Windows.Forms.ComboBox cbMinute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHour;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox lstNotificationSound;
        private AxWMPLib.AxWindowsMediaPlayer wmp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckedListBox cLstBengTime;
        private System.Windows.Forms.Button btnDelDb;
        private System.Windows.Forms.Label lblBengs;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblHours;
    }
}

