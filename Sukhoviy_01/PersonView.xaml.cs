using System.Windows.Controls;

namespace Sukhoviy_01
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class SignInControl : UserControl
    {
        public SignInControl()
        {
            InitializeComponent();
            DataContext = new SignInViewModel();
        }
    }
}
