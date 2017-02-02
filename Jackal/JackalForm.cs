using System;
using System.Drawing;
using System.Windows.Forms;
using Gecko;
using MetroFramework.Forms;

namespace Jackal
{
    public partial class JackalForm : MetroForm
    {
        private Gecko33 _gecko33;

        public JackalForm()
        {
            InitializeComponent();
            InitializeGecko33();
        }

        private void InitializeGecko33()
        {
            Gecko33.Initialize();

            _gecko33 = new Gecko33
            {
                WebBrowser =
                {
                    Location = new Point(0, geckoNavigationPanel.Size.Height+1),
                    Size = new Size(geckoTabPage.Width, geckoTabPage.Height),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left |AnchorStyles.Bottom| AnchorStyles.Right,
                    AllowDrop = false
                }
            };
            
            _gecko33.WebBrowser.ProgressChanged += WebBrowserOnProgressChanged;
            _gecko33.WebBrowser.CanGoBackChanged += WebBrowserOnCanGoBackChanged;
            _gecko33.WebBrowser.CanGoForwardChanged += WebBrowser_CanGoForwardChanged;
         
            geckoTabPage.Controls.Add(_gecko33.WebBrowser);


            _gecko33.Navigate("http://google.com");
        }

        private void WebBrowser_CanGoForwardChanged(object sender, EventArgs e)
        {
            //Переход вперед
            var canGo = _gecko33.WebBrowser.CanGoForward;
            geckoGoForwardButton.Enabled = canGo;
            geckoGoForwardButton.BackgroundImage = canGo ? Properties.Resources.right_14 : Properties.Resources.right_disabled_14;
        }

        private void WebBrowserOnCanGoBackChanged(object sender, EventArgs eventArgs)
        {
            //Переход назад
            var canGo = _gecko33.WebBrowser.CanGoBack;
            geckoGoBackButton.Enabled = canGo;
            geckoGoBackButton.BackgroundImage = canGo ? Properties.Resources.left_14 : Properties.Resources.left_disabled_14;
        }

        private void WebBrowserOnProgressChanged(object sender, GeckoProgressEventArgs geckoProgressEventArgs)
        {
            //Отображение адреса в строке
            geckoUrlTextBox.Text = _gecko33.WebBrowser.Url.AbsoluteUri;
        }

        private void NavigationOnMouseLeave(object sender, System.EventArgs e)
        {
            //Потеря фокуса элементами навигации
            _gecko33.WebBrowser.Focus();
        }

        private void urlMetroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Переход по ссылке
            if (e.KeyCode == Keys.Enter)
            {
                _gecko33.Navigate(geckoUrlTextBox.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }


        //private void geckoUrlTextBox_DoubleClick(object sender, EventArgs e)
        //{
        //    //Выделение текста по двойному клику
        //    var tb = sender as TextBox;
        //    tb.SelectAll();
        //    geckoUrlTextBox.SelectAll();
        //}

        private void geckoReloadButton_Click(object sender, EventArgs e)
        {
            //Обновление страницы
            _gecko33.WebBrowser.Reload();
        }

        private void geckoGoBackButton_Click(object sender, EventArgs e)
        {
            if (_gecko33.WebBrowser.CanGoBack)
            {
                _gecko33.WebBrowser.GoBack();
            }
        }

        private void geckoRightButton_Click(object sender, EventArgs e)
        {
            if (_gecko33.WebBrowser.CanGoForward)
            {
                _gecko33.WebBrowser.GoForward();
            }
        }
    }
}
