namespace WeatherApp
{
    partial class WeatherView
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeatherView));
            this.labelCity = new System.Windows.Forms.Label();
            this.labelTemp = new System.Windows.Forms.Label();
            this.labelMaxTemp = new System.Windows.Forms.Label();
            this.labelMinTemp = new System.Windows.Forms.Label();
            this.labelSunRise = new System.Windows.Forms.Label();
            this.labelSunSet = new System.Windows.Forms.Label();
            this.labelPressure = new System.Windows.Forms.Label();
            this.labelHumidity = new System.Windows.Forms.Label();
            this.labelWind = new System.Windows.Forms.Label();
            this.labelCloud = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelWeather = new System.Windows.Forms.Panel();
            this.labelError = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripNotify = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.panelWeather.SuspendLayout();
            this.contextMenuStripNotify.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(3, 19);
            this.labelCity.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(23, 13);
            this.labelCity.TabIndex = 0;
            this.labelCity.Text = "city";
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Location = new System.Drawing.Point(3, 98);
            this.labelTemp.Margin = new System.Windows.Forms.Padding(3, 10, 3, 5);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(35, 13);
            this.labelTemp.TabIndex = 1;
            this.labelTemp.Text = "label1";
            // 
            // labelMaxTemp
            // 
            this.labelMaxTemp.AutoSize = true;
            this.labelMaxTemp.Location = new System.Drawing.Point(3, 121);
            this.labelMaxTemp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelMaxTemp.Name = "labelMaxTemp";
            this.labelMaxTemp.Size = new System.Drawing.Size(35, 13);
            this.labelMaxTemp.TabIndex = 2;
            this.labelMaxTemp.Text = "label2";
            // 
            // labelMinTemp
            // 
            this.labelMinTemp.AutoSize = true;
            this.labelMinTemp.Location = new System.Drawing.Point(3, 144);
            this.labelMinTemp.Margin = new System.Windows.Forms.Padding(3, 5, 3, 10);
            this.labelMinTemp.Name = "labelMinTemp";
            this.labelMinTemp.Size = new System.Drawing.Size(35, 13);
            this.labelMinTemp.TabIndex = 3;
            this.labelMinTemp.Text = "label3";
            // 
            // labelSunRise
            // 
            this.labelSunRise.AutoSize = true;
            this.labelSunRise.Location = new System.Drawing.Point(3, 42);
            this.labelSunRise.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelSunRise.Name = "labelSunRise";
            this.labelSunRise.Size = new System.Drawing.Size(35, 13);
            this.labelSunRise.TabIndex = 4;
            this.labelSunRise.Text = "label1";
            // 
            // labelSunSet
            // 
            this.labelSunSet.AutoSize = true;
            this.labelSunSet.Location = new System.Drawing.Point(3, 65);
            this.labelSunSet.Margin = new System.Windows.Forms.Padding(3, 5, 3, 10);
            this.labelSunSet.Name = "labelSunSet";
            this.labelSunSet.Size = new System.Drawing.Size(35, 13);
            this.labelSunSet.TabIndex = 5;
            this.labelSunSet.Text = "label2";
            // 
            // labelPressure
            // 
            this.labelPressure.AutoSize = true;
            this.labelPressure.Location = new System.Drawing.Point(3, 177);
            this.labelPressure.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelPressure.Name = "labelPressure";
            this.labelPressure.Size = new System.Drawing.Size(35, 13);
            this.labelPressure.TabIndex = 6;
            this.labelPressure.Text = "label1";
            // 
            // labelHumidity
            // 
            this.labelHumidity.AutoSize = true;
            this.labelHumidity.Location = new System.Drawing.Point(3, 210);
            this.labelHumidity.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelHumidity.Name = "labelHumidity";
            this.labelHumidity.Size = new System.Drawing.Size(35, 13);
            this.labelHumidity.TabIndex = 7;
            this.labelHumidity.Text = "label1";
            // 
            // labelWind
            // 
            this.labelWind.AutoSize = true;
            this.labelWind.Location = new System.Drawing.Point(3, 243);
            this.labelWind.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.labelWind.Name = "labelWind";
            this.labelWind.Size = new System.Drawing.Size(35, 13);
            this.labelWind.TabIndex = 8;
            this.labelWind.Text = "label1";
            // 
            // labelCloud
            // 
            this.labelCloud.AutoSize = true;
            this.labelCloud.Location = new System.Drawing.Point(3, 276);
            this.labelCloud.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.labelCloud.Name = "labelCloud";
            this.labelCloud.Size = new System.Drawing.Size(35, 13);
            this.labelCloud.TabIndex = 9;
            this.labelCloud.Text = "label1";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(228, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 10;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // panelWeather
            // 
            this.panelWeather.Controls.Add(this.pictureBoxWeather);
            this.panelWeather.Controls.Add(this.labelError);
            this.panelWeather.Controls.Add(this.labelCity);
            this.panelWeather.Controls.Add(this.labelCloud);
            this.panelWeather.Controls.Add(this.labelWind);
            this.panelWeather.Controls.Add(this.labelTemp);
            this.panelWeather.Controls.Add(this.labelHumidity);
            this.panelWeather.Controls.Add(this.labelMaxTemp);
            this.panelWeather.Controls.Add(this.labelPressure);
            this.panelWeather.Controls.Add(this.labelMinTemp);
            this.panelWeather.Controls.Add(this.labelSunSet);
            this.panelWeather.Controls.Add(this.labelSunRise);
            this.panelWeather.Location = new System.Drawing.Point(12, 41);
            this.panelWeather.Name = "panelWeather";
            this.panelWeather.Size = new System.Drawing.Size(291, 302);
            this.panelWeather.TabIndex = 11;
            this.panelWeather.Visible = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(4, 4);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(41, 13);
            this.labelError.TabIndex = 10;
            this.labelError.Text = "label1";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(12, 12);
            this.comboBoxCity.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(165, 21);
            this.comboBoxCity.TabIndex = 12;
            this.comboBoxCity.DropDownClosed += new System.EventHandler(this.comboBoxCity_DropDownClosed);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(183, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(23, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripNotify;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Weather";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStripNotify
            // 
            this.contextMenuStripNotify.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStripNotify.Name = "contextMenuStripNotify";
            this.contextMenuStripNotify.Size = new System.Drawing.Size(108, 48);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemAbout.Text = "About";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxWeather.Location = new System.Drawing.Point(188, 3);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxWeather.TabIndex = 11;
            this.pictureBoxWeather.TabStop = false;
            this.pictureBoxWeather.Click += new System.EventHandler(this.pictureBoxWeather_Click);
            // 
            // WeatherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 350);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.panelWeather);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WeatherView";
            this.ShowInTaskbar = false;
            this.Text = "Weather";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WeatherView_FormClosing);
            this.Load += new System.EventHandler(this.WeatherView_Load);
            this.panelWeather.ResumeLayout(false);
            this.panelWeather.PerformLayout();
            this.contextMenuStripNotify.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.Label labelMaxTemp;
        private System.Windows.Forms.Label labelMinTemp;
        private System.Windows.Forms.Label labelSunRise;
        private System.Windows.Forms.Label labelSunSet;
        private System.Windows.Forms.Label labelPressure;
        private System.Windows.Forms.Label labelHumidity;
        private System.Windows.Forms.Label labelWind;
        private System.Windows.Forms.Label labelCloud;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panelWeather;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripNotify;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
    }
}

