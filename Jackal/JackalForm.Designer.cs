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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JackalForm));
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.geckoTabPage = new MetroFramework.Controls.MetroTabPage();
            this.geckoNavigationPanel = new MetroFramework.Controls.MetroPanel();
            this.geckoReloadButton = new MetroFramework.Controls.MetroButton();
            this.geckoGoForwardButton = new MetroFramework.Controls.MetroButton();
            this.geckoGoBackButton = new MetroFramework.Controls.MetroButton();
            this.geckoUrlTextBox = new MetroFramework.Controls.MetroTextBox();
            this.scannerTabPage = new System.Windows.Forms.TabPage();
            this.viewerTabPage = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroTabControl1.SuspendLayout();
            this.geckoTabPage.SuspendLayout();
            this.geckoNavigationPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.geckoTabPage);
            this.metroTabControl1.Controls.Add(this.scannerTabPage);
            this.metroTabControl1.Controls.Add(this.viewerTabPage);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(640, 405);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // geckoTabPage
            // 
            this.geckoTabPage.BackColor = System.Drawing.Color.White;
            this.geckoTabPage.Controls.Add(this.geckoNavigationPanel);
            this.geckoTabPage.ForeColor = System.Drawing.Color.White;
            this.geckoTabPage.HorizontalScrollbarBarColor = false;
            this.geckoTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.geckoTabPage.HorizontalScrollbarSize = 0;
            this.geckoTabPage.Location = new System.Drawing.Point(4, 38);
            this.geckoTabPage.Name = "geckoTabPage";
            this.geckoTabPage.Size = new System.Drawing.Size(632, 363);
            this.geckoTabPage.TabIndex = 0;
            this.geckoTabPage.Text = "Gecko";
            this.geckoTabPage.UseCustomBackColor = true;
            this.geckoTabPage.VerticalScrollbarBarColor = false;
            this.geckoTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.geckoTabPage.VerticalScrollbarSize = 0;
            // 
            // geckoNavigationPanel
            // 
            this.geckoNavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.geckoNavigationPanel.Controls.Add(this.geckoReloadButton);
            this.geckoNavigationPanel.Controls.Add(this.geckoGoForwardButton);
            this.geckoNavigationPanel.Controls.Add(this.geckoGoBackButton);
            this.geckoNavigationPanel.Controls.Add(this.geckoUrlTextBox);
            this.geckoNavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.geckoNavigationPanel.HorizontalScrollbarBarColor = true;
            this.geckoNavigationPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.geckoNavigationPanel.HorizontalScrollbarSize = 0;
            this.geckoNavigationPanel.Location = new System.Drawing.Point(0, 0);
            this.geckoNavigationPanel.Name = "geckoNavigationPanel";
            this.geckoNavigationPanel.Size = new System.Drawing.Size(632, 32);
            this.geckoNavigationPanel.TabIndex = 0;
            this.geckoNavigationPanel.UseCustomBackColor = true;
            this.geckoNavigationPanel.VerticalScrollbarBarColor = true;
            this.geckoNavigationPanel.VerticalScrollbarHighlightOnWheel = false;
            this.geckoNavigationPanel.VerticalScrollbarSize = 0;
            // 
            // geckoReloadButton
            // 
            this.geckoReloadButton.BackgroundImage = global::Jackal.Properties.Resources.update_14;
            this.geckoReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geckoReloadButton.Location = new System.Drawing.Point(63, 4);
            this.geckoReloadButton.Name = "geckoReloadButton";
            this.geckoReloadButton.Size = new System.Drawing.Size(24, 24);
            this.geckoReloadButton.TabIndex = 0;
            this.geckoReloadButton.UseSelectable = true;
            this.geckoReloadButton.Click += new System.EventHandler(this.geckoReloadButton_Click);
            this.geckoReloadButton.MouseLeave += new System.EventHandler(this.NavigationOnMouseLeave);
            // 
            // geckoGoForwardButton
            // 
            this.geckoGoForwardButton.BackgroundImage = global::Jackal.Properties.Resources.right_disabled_14;
            this.geckoGoForwardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geckoGoForwardButton.Enabled = false;
            this.geckoGoForwardButton.Location = new System.Drawing.Point(33, 4);
            this.geckoGoForwardButton.Name = "geckoGoForwardButton";
            this.geckoGoForwardButton.Size = new System.Drawing.Size(24, 24);
            this.geckoGoForwardButton.TabIndex = 0;
            this.geckoGoForwardButton.UseSelectable = true;
            this.geckoGoForwardButton.Click += new System.EventHandler(this.geckoRightButton_Click);
            this.geckoGoForwardButton.MouseLeave += new System.EventHandler(this.NavigationOnMouseLeave);
            // 
            // geckoGoBackButton
            // 
            this.geckoGoBackButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("geckoGoBackButton.BackgroundImage")));
            this.geckoGoBackButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.geckoGoBackButton.Enabled = false;
            this.geckoGoBackButton.Location = new System.Drawing.Point(3, 4);
            this.geckoGoBackButton.Name = "geckoGoBackButton";
            this.geckoGoBackButton.Size = new System.Drawing.Size(24, 24);
            this.geckoGoBackButton.TabIndex = 0;
            this.geckoGoBackButton.UseSelectable = true;
            this.geckoGoBackButton.Click += new System.EventHandler(this.geckoGoBackButton_Click);
            this.geckoGoBackButton.MouseLeave += new System.EventHandler(this.NavigationOnMouseLeave);
            // 
            // geckoUrlTextBox
            // 
            this.geckoUrlTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.geckoUrlTextBox.CustomButton.Image = null;
            this.geckoUrlTextBox.CustomButton.Location = new System.Drawing.Point(514, 2);
            this.geckoUrlTextBox.CustomButton.Name = "";
            this.geckoUrlTextBox.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.geckoUrlTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.geckoUrlTextBox.CustomButton.TabIndex = 1;
            this.geckoUrlTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.geckoUrlTextBox.CustomButton.UseSelectable = true;
            this.geckoUrlTextBox.CustomButton.Visible = false;
            this.geckoUrlTextBox.Lines = new string[0];
            this.geckoUrlTextBox.Location = new System.Drawing.Point(93, 4);
            this.geckoUrlTextBox.MaxLength = 2000;
            this.geckoUrlTextBox.Name = "geckoUrlTextBox";
            this.geckoUrlTextBox.PasswordChar = '\0';
            this.geckoUrlTextBox.PromptText = "http://";
            this.geckoUrlTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.geckoUrlTextBox.SelectedText = "";
            this.geckoUrlTextBox.SelectionLength = 0;
            this.geckoUrlTextBox.SelectionStart = 0;
            this.geckoUrlTextBox.ShortcutsEnabled = true;
            this.geckoUrlTextBox.Size = new System.Drawing.Size(536, 24);
            this.geckoUrlTextBox.TabIndex = 1;
            this.geckoUrlTextBox.UseSelectable = true;
            this.geckoUrlTextBox.WaterMark = "http://";
            this.geckoUrlTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.geckoUrlTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.geckoUrlTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.urlMetroTextBox_KeyDown);
            // 
            // scannerTabPage
            // 
            this.scannerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.scannerTabPage.Location = new System.Drawing.Point(4, 38);
            this.scannerTabPage.Name = "scannerTabPage";
            this.scannerTabPage.Size = new System.Drawing.Size(632, 363);
            this.scannerTabPage.TabIndex = 1;
            this.scannerTabPage.Text = "Scanner";
            // 
            // viewerTabPage
            // 
            this.viewerTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.viewerTabPage.HorizontalScrollbarBarColor = true;
            this.viewerTabPage.HorizontalScrollbarHighlightOnWheel = false;
            this.viewerTabPage.HorizontalScrollbarSize = 10;
            this.viewerTabPage.Location = new System.Drawing.Point(4, 38);
            this.viewerTabPage.Name = "viewerTabPage";
            this.viewerTabPage.Size = new System.Drawing.Size(632, 363);
            this.viewerTabPage.TabIndex = 2;
            this.viewerTabPage.Text = "Viewer";
            this.viewerTabPage.UseCustomBackColor = true;
            this.viewerTabPage.VerticalScrollbarBarColor = true;
            this.viewerTabPage.VerticalScrollbarHighlightOnWheel = false;
            this.viewerTabPage.VerticalScrollbarSize = 10;
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
            // JackalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::Jackal.Properties.Resources.background_5;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.pictureBox1);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "JackalForm";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 15);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "Jackal";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.geckoTabPage.ResumeLayout(false);
            this.geckoNavigationPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage geckoTabPage;
        private System.Windows.Forms.TabPage scannerTabPage;
        private MetroFramework.Controls.MetroPanel geckoNavigationPanel;
        private MetroFramework.Controls.MetroTextBox geckoUrlTextBox;
        private MetroFramework.Controls.MetroTabPage viewerTabPage;
        private MetroFramework.Controls.MetroButton geckoGoBackButton;
        private MetroFramework.Controls.MetroButton geckoGoForwardButton;
        private MetroFramework.Controls.MetroButton geckoReloadButton;
    }
}

