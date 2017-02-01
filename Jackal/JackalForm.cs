using System.Drawing;
using System.Windows.Forms;
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
                Control =
                {
                    Location = new Point(0, geckoNavigationPanel.Size.Height),
                    Size = new Size(geckoTabPage.Width, geckoTabPage.Height),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left |AnchorStyles.Bottom| AnchorStyles.Right,
                    AllowDrop = false
                }
            };
            geckoTabPage.Controls.Add(_gecko33.Control);


            _gecko33.Navigate("http://google.com");
        }

        private void urlMetroTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _gecko33.Navigate(geckoUrlTextBox.Text);
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void geckoSearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var url = "https://www.google.com/search?q=" + geckoSearchTextBox.Text;
                _gecko33.Navigate(url);
                e.Handled = e.SuppressKeyPress = true;
            }
        }
    }
}
