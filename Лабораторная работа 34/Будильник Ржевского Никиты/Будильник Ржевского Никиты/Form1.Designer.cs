namespace Будильник_Ржевского_Никиты
{
    partial class AlarmForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlarmForm));
            this.TimeBox = new System.Windows.Forms.GroupBox();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.DateBox = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dayLabel = new System.Windows.Forms.Label();
            this.AlarmBox = new System.Windows.Forms.GroupBox();
            this.AlarmPanel = new System.Windows.Forms.Panel();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SetButton = new System.Windows.Forms.Button();
            this.CanselButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.SetMusikButton = new System.Windows.Forms.Button();
            this.TimeBox.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.DateBox.SuspendLayout();
            this.AlarmBox.SuspendLayout();
            this.AlarmPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeBox
            // 
            this.TimeBox.Controls.Add(this.TimePanel);
            this.TimeBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TimeBox.Location = new System.Drawing.Point(30, 12);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(200, 100);
            this.TimeBox.TabIndex = 0;
            this.TimeBox.TabStop = false;
            this.TimeBox.Text = "Текущее время:";
            // 
            // TimePanel
            // 
            this.TimePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TimePanel.Controls.Add(this.TimeLabel);
            this.TimePanel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimePanel.Location = new System.Drawing.Point(6, 34);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(190, 60);
            this.TimePanel.TabIndex = 0;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(19, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(156, 42);
            this.TimeLabel.TabIndex = 0;
            this.TimeLabel.Text = "00:00:00";
            this.TimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // DateBox
            // 
            this.DateBox.Controls.Add(this.monthCalendar1);
            this.DateBox.Location = new System.Drawing.Point(30, 129);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(200, 194);
            this.DateBox.TabIndex = 1;
            this.DateBox.TabStop = false;
            this.DateBox.Text = "Текущая дата:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 27);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(44, 336);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(45, 19);
            this.dayLabel.TabIndex = 2;
            this.dayLabel.Text = "label1";
            // 
            // AlarmBox
            // 
            this.AlarmBox.Controls.Add(this.AlarmPanel);
            this.AlarmBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AlarmBox.Location = new System.Drawing.Point(249, 12);
            this.AlarmBox.Name = "AlarmBox";
            this.AlarmBox.Size = new System.Drawing.Size(200, 100);
            this.AlarmBox.TabIndex = 3;
            this.AlarmBox.TabStop = false;
            this.AlarmBox.Text = "Время оповещения:";
            // 
            // AlarmPanel
            // 
            this.AlarmPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlarmPanel.Controls.Add(this.DateTimePicker);
            this.AlarmPanel.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AlarmPanel.Location = new System.Drawing.Point(6, 34);
            this.AlarmPanel.Name = "AlarmPanel";
            this.AlarmPanel.Size = new System.Drawing.Size(190, 60);
            this.AlarmPanel.TabIndex = 0;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateTimePicker.Location = new System.Drawing.Point(3, 5);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.Size = new System.Drawing.Size(182, 50);
            this.DateTimePicker.TabIndex = 0;
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // SetButton
            // 
            this.SetButton.Location = new System.Drawing.Point(259, 118);
            this.SetButton.Name = "SetButton";
            this.SetButton.Size = new System.Drawing.Size(75, 27);
            this.SetButton.TabIndex = 4;
            this.SetButton.Text = "Задать";
            this.SetButton.UseVisualStyleBackColor = true;
            this.SetButton.Click += new System.EventHandler(this.SetButton_Click);
            // 
            // CanselButton
            // 
            this.CanselButton.Location = new System.Drawing.Point(347, 118);
            this.CanselButton.Name = "CanselButton";
            this.CanselButton.Size = new System.Drawing.Size(98, 27);
            this.CanselButton.TabIndex = 5;
            this.CanselButton.Text = "Отменить";
            this.CanselButton.UseVisualStyleBackColor = true;
            this.CanselButton.Click += new System.EventHandler(this.CanselButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MediaPlayer);
            this.panel1.Location = new System.Drawing.Point(249, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 78);
            this.panel1.TabIndex = 6;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(3, 3);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(194, 73);
            this.MediaPlayer.TabIndex = 0;
            this.MediaPlayer.Enter += new System.EventHandler(this.MediaPlayer_Enter);
            // 
            // SetMusikButton
            // 
            this.SetMusikButton.BackgroundImage = global::Будильник_Ржевского_Никиты.Properties.Resources.folder_Open;
            this.SetMusikButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SetMusikButton.Location = new System.Drawing.Point(249, 252);
            this.SetMusikButton.Name = "SetMusikButton";
            this.SetMusikButton.Size = new System.Drawing.Size(50, 50);
            this.SetMusikButton.TabIndex = 7;
            this.SetMusikButton.UseVisualStyleBackColor = true;
            this.SetMusikButton.Click += new System.EventHandler(this.SetMusikButton_Click);
            // 
            // AlarmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.SetMusikButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CanselButton);
            this.Controls.Add(this.SetButton);
            this.Controls.Add(this.AlarmBox);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.TimeBox);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "AlarmForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Будильник Ржевского Никиты";
            this.Load += new System.EventHandler(this.AlarmForm_Load);
            this.TimeBox.ResumeLayout(false);
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.DateBox.ResumeLayout(false);
            this.AlarmBox.ResumeLayout(false);
            this.AlarmPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox TimeBox;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.GroupBox DateBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.GroupBox AlarmBox;
        private System.Windows.Forms.Panel AlarmPanel;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button SetButton;
        private System.Windows.Forms.Button CanselButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SetMusikButton;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
    }
}

