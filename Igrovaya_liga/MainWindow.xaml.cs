using System.Windows;
using Igrovaya_liga.Pages;
using Igrovaya_liga.DataModel;

namespace Igrovaya_liga
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // подключение к бд
        public static ligaEntities db = new ligaEntities(); 
        public MainWindow()
        {
            InitializeComponent();
            Content.Navigate(new PageMenu());
        }
    }
}
