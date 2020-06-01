using System.Windows;
using System.Windows.Controls;

namespace Igrovaya_liga.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMenu.xaml
    /// </summary>
    public partial class PageMenu : Page
    {
        public PageMenu()
        {
            InitializeComponent();
        }

        private void PlayerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PagePlayer());
        }

        private void EfficiencyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TeamBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageTeam());
        }

        private void AreaBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
