using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Будильник_Ржевского_Никиты
{
    public partial class AlarmForm : Form
    {
        bool Alarm = false;
        string music = "";

        public AlarmForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            if ( !Alarm )
            {
                CanselButton.Enabled = false;
            }
            Timer.Interval = 1000;
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Start();
            dayLabel.Text = string.Format("День недели - {0}",
            CultureInfo.CurrentCulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek));
        }
        
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.Hour.ToString("00") + ":"
                + DateTime.Now.Minute.ToString("00") + ":"
                + DateTime.Now.Second.ToString("00");
            if (DateTimePicker.Text.Length == 7)
            {
                if (Equals(TimeLabel.Text, "0" + DateTimePicker.Text))
                {
                    MediaPlayer.URL = music;
                }
            }
            if (Equals(TimeLabel.Text, DateTimePicker.Text))
            {
                MediaPlayer.URL = music;
            }
        }

        private void MediaPlayer_Enter(object sender, EventArgs e)
        {

        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            if ( music == "" )
            {
                MessageBox.Show("Чтобы задать будильник, назначте мелодию!");
            }
            else
            {
                if ( !Alarm )
                {
                    SetButton.Enabled = false;
                    CanselButton.Enabled = true;
                    Alarm = true;
                }
            }
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            SetButton.Enabled = true;
            CanselButton.Enabled = false;
            Alarm = false;
            MediaPlayer.close();
        }

        private void SetMusikButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                music = openFile.FileName;
            }
        }
    }
}
