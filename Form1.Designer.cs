namespace ShutdownPC
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ShutdownCombobox = new MetroFramework.Controls.MetroComboBox();
            this.ShutdownButton = new MetroFramework.Controls.MetroButton();
            this.StopShutdownButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // ShutdownCombobox
            // 
            this.ShutdownCombobox.FormattingEnabled = true;
            this.ShutdownCombobox.ItemHeight = 23;
            this.ShutdownCombobox.Items.AddRange(new object[] {
            "1 min",
            "30 min",
            "1 hour",
            "2 hours",
            "3 hours",
            "4 hours",
            "5 hours",
            "6 hours",
            "7 hours",
            "8 hours",
            "9 hours",
            "10 hours"});
            this.ShutdownCombobox.Location = new System.Drawing.Point(23, 63);
            this.ShutdownCombobox.Name = "ShutdownCombobox";
            this.ShutdownCombobox.Size = new System.Drawing.Size(121, 29);
            this.ShutdownCombobox.TabIndex = 0;            
            // 
            // ShutdownButton
            // 
            this.ShutdownButton.Location = new System.Drawing.Point(150, 63);
            this.ShutdownButton.Name = "ShutdownButton";
            this.ShutdownButton.Size = new System.Drawing.Size(96, 29);
            this.ShutdownButton.TabIndex = 1;
            this.ShutdownButton.Text = "Shutdown";
            this.ShutdownButton.Click += new System.EventHandler(this.ShutdownButton_Click);
            // 
            // StopShutdownButton
            // 
            this.StopShutdownButton.Location = new System.Drawing.Point(150, 98);
            this.StopShutdownButton.Name = "StopShutdownButton";
            this.StopShutdownButton.Size = new System.Drawing.Size(96, 29);
            this.StopShutdownButton.TabIndex = 2;
            this.StopShutdownButton.Text = "Stop";
            this.StopShutdownButton.Click += new System.EventHandler(this.StopShutdownButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 151);
            this.Controls.Add(this.StopShutdownButton);
            this.Controls.Add(this.ShutdownButton);
            this.Controls.Add(this.ShutdownCombobox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Shutdown";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox ShutdownCombobox;
        private MetroFramework.Controls.MetroButton ShutdownButton;
        private MetroFramework.Controls.MetroButton StopShutdownButton;
    }
}

