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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddTab();
        }

        private void Aaaa_Notify(string message)
        {
            AddTab();
        }

        private void AddTab()
        {

            Grid grid = new Grid();
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());

            UserControl_start new_tab_start = new UserControl_start();
            new_tab_start.Notify += Aaaa_Notify;
            ListBox notesList = new ListBox();
            notesList.Items.Add("Macbook Pro");
            notesList.Items.Add("HP Pavilion 5478");
            notesList.Items.Add("Acer LK-08");

            Grid.SetRow(new_tab_start, 0);
            Grid.SetColumn(new_tab_start, 0);
            grid.Children.Add(new_tab_start);

            // добавление вкладки
            Main_Tab.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Начальная страница" }, // установка заголовка вкладки
                Content = grid
            });
        }
    }
}
