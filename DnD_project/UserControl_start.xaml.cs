using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DnD_project
{
    /// <summary>
    /// Логика взаимодействия для UserControl_start.xaml
    /// </summary>
    public partial class UserControl_start : UserControl
    {
        public delegate void EventHandler(string message);
        public event EventHandler Notify;
        
        public delegate void AccountHandler(string message);
        public event AccountHandler Notify2;
        public UserControl_start()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty Choose_option = DependencyProperty.Register(
    "Text", typeof(UserControl), typeof(UserControl_start), new PropertyMetadata(default(string)));

        public UserControl Next_Option
        {
            get => (UserControl)GetValue(Choose_option);
            set => SetValue(Choose_option, value);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //bubble the event up to the parent
            Notify?.Invoke("dsadsa");
            Notify2?.Invoke("dsadsa");
        }
    }
}
