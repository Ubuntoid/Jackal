namespace Jackal
{
    partial class JackalForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.geckoTabPage = new MetroFramework.Controls.MetroTabPage();
            this.geckoNavigationPanel = new MetroFramework.Controls.MetroPanel();
            this.geckoUrlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.scannerTabPage = new System.Windows.Forms.TabPage();
            this.geckoSearchTextBox = new MetroFramework.Controls.MetroTextBox();
            this.viewerTabPage = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.geckoTabPage.SuspendLayout();
            this.geckoNavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jackal.Properties.Resources.jackal_40;
            this.pictureBox1.Location = new System.Drawing.Point(95, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.geckoTabPage);
            this.metroTabControl1.Controls.Add(this.scannerTabPage);
            this.metroTabControl1.Controls.Add(this.viewerTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1024, 560);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // geckoTabPage
            // 
            this.geckoTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.geckoTabPage.Controls.Add(this.geckoNavigationPanel);
            this.geckoTabPage.ForeColor = System.Drawing.Color.White;
            this.geckoTabPage.HorizontalScrollbarBarColor = false;
            this.geckoTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.geckoTabPage.HorizontalScrollbarSize = 0;
            this.geckoTabPage.Location = new System.Drawing.Point(4, 38);
            this.geckoTabPage.Name = "geckoTabPage";
            this.geckoTabPage.Size = new System.Drawing.Size(1016, 518);
            this.geckoTabPage.TabIndex = 0;
            this.geckoTabPage.Text = "Gecko";
            this.geckoTabPage.UseCustomBackColor = true;
            this.geckoTabPage.VerticalScrollbarBarColor = false;
            this.geckoTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.geckoTabPage.VerticalScrollbarSize = 0;
            // 
            // geckoNavigationPanel
            // 
            this.geckoNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.geckoNavigationPanel.Controls.Add(this.geckoSearchTextBox);
            this.geckoNavigationPanel.Controls.Add(this.geckoUrlTextBox);
            this.geckoNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.geckoNavigationPanel.HorizontalScrollbarBarColor = true;
            this.geckoNavigationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.geckoNavigationPanel.HorizontalScrollbarSize = 0;
            this.geckoNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.geckoNavigationPanel.Name = "geckoNavigationPanel";
            this.geckoNavigationPanel.Size = new System.Drawing.Size(1016, 30);
            this.geckoNavigationPanel.TabIndex = 2;
            this.geckoNavigationPanel.UseCustomBackColor = true;
            this.geckoNavigationPanel.VerticalScrollbarBarColor = true;
            this.geckoNavigationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.geckoNavigationPanel.VerticalScrollbarSize = 0;
            // 
            // geckoUrlTextBox
            // 
            this.geckoUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.geckoUrlTextBox.CustomButton.Image = null;
            this.geckoUrlTextBox.CustomButton.Location = new System.Drawing.Point(700, 2);
            this.geckoUrlTextBox.CustomButton.Name = "";
            this.geckoUrlTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.geckoUrlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.geckoUrlTextBox.CustomButton.TabIndex = 1;
            this.geckoUrlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.geckoUrlTextBox.CustomButton.UseSelectable = true;
            this.geckoUrlTextBox.CustomButton.Visible = false;
            this.geckoUrlTextBox.Lines = new string[0];
            this.geckoUrlTextBox.Location = new System.Drawing.Point(46, 4);
            this.geckoUrlTextBox.MaxLength = 2000;
            this.geckoUrlTextBox.Name = "geckoUrlTextBox";
            this.geckoUrlTextBox.PasswordChar = '\0';
            this.geckoUrlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.geckoUrlTextBox.SelectedText = "";
            this.geckoUrlTextBox.SelectionLength = 0;
            this.geckoUrlTextBox.SelectionStart = 0;
            this.geckoUrlTextBox.ShortcutsEnabled = true;
            this.geckoUrlTextBox.Size = new System.Drawing.Size(720, 22);
            this.geckoUrlTextBox.TabIndex = 3;
            this.geckoUrlTextBox.UseSelectable = true;
            this.geckoUrlTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.geckoUrlTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.geckoUrlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlMetroTextBox_KeyDown);
            // 
            // scannerTabPage
            // 
            this.scannerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.scannerTabPage.Location = new System.Drawing.Point(4, 38);
            this.scannerTabPage.Name = "scannerTabPage";
            this.scannerTabPage.Size = new System.Drawing.Size(1016, 518);
            this.scannerTabPage.TabIndex = 1;
            this.scannerTabPage.Text = "Scanner";
            // 
            // geckoSearchTextBox
            // 
            this.geckoSearchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.geckoSearchTextBox.CustomButton.Image = null;
            this.geckoSearchTextBox.CustomButton.Location = new System.Drawing.Point(221, 2);
            this.geckoSearchTextBox.CustomButton.Name = "";
            this.geckoSearchTextBox.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.geckoSearchTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.geckoSearchTextBox.CustomButton.TabIndex = 1;
            this.geckoSearchTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.geckoSearchTextBox.CustomButton.UseSelectable = true;
            this.geckoSearchTextBox.CustomButton.Visible = false;
            this.geckoSearchTextBox.Lines = new string[0];
            this.geckoSearchTextBox.Location = new System.Drawing.Point(772, 4);
            this.geckoSearchTextBox.MaxLength = 2000;
            this.geckoSearchTextBox.Name = "geckoSearchTextBox";
            this.geckoSearchTextBox.PasswordChar = '\0';
            this.geckoSearchTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.geckoSearchTextBox.SelectedText = "";
            this.geckoSearchTextBox.SelectionLength = 0;
            this.geckoSearchTextBox.SelectionStart = 0;
            this.geckoSearchTextBox.ShortcutsEnabled = true;
            this.geckoSearchTextBox.Size = new System.Drawing.Size(241, 22);
            this.geckoSearchTextBox.TabIndex = 3;
            this.geckoSearchTextBox.UseSelectable = true;
            this.geckoSearchTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.geckoSearchTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.geckoSearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.geckoSearchTextBox_KeyDown);
            // 
            // viewerTabPage
            // 
            this.viewerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.viewerTabPage.HorizontalScrollbarBarColor = true;
            this.viewerTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.viewerTabPage.HorizontalScrollbarSize = 10;
            this.viewerTabPage.Location = new System.Drawing.Point(4, 38);
            this.viewerTabPage.Name = "viewerTabPage";
            this.viewerTabPage.Size = new System.Drawing.Size(1016, 518);
            this.viewerTabPage.TabIndex = 2;
            this.viewerTabPage.Text = "Viewer";
            this.viewerTabPage.UseCustomBackColor = true;
            this.viewerTabPage.VerticalScrollbarBarColor = true;
            this.viewerTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.viewerTabPage.VerticalScrollbarSize = 10;
            // 
            // JackalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 640);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(1024, 640);
            this.Name = "JackalForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 20);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Jackal";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.geckoTabPage.ResumeLayout(false);
            this.geckoNavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage geckoTabPage;
        private System.Windows.Forms.TabPage scannerTabPage;
        private MetroFramework.Controls.MetroPanel geckoNavigationPanel;
        private MetroFramework.Controls.MetroTextBox geckoUrlTextBox;
        private MetroFramework.Controls.MetroTextBox geckoSearchTextBox;
        private MetroFramework.Controls.MetroTabPage viewerTabPage;
    }
}

