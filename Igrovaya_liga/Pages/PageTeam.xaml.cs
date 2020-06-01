using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Igrovaya_liga.DataModel;

namespace Igrovaya_liga.Pages
{
    public partial class PageTeam : Page
    {
        Team selteam;
        public PageTeam()
        {
            InitializeComponent();
            teamList.ItemsSource = MainWindow.db.Team.ToList();
            CapitanBox.ItemsSource = MainWindow.db.Player.Select(c => c.Surname + " " + c.Name + " " + c.Patronymic).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void StructureBtn_Click(object sender, RoutedEventArgs e)
        {
            var sel = ((Button)sender).DataContext as Team;
            NavigationService.Navigate(new PageStructure(sel));
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                    Team team = new Team();
                    team.TeamName = teamnamebox.Text;
                    team.CapitanId = MainWindow.db.Player.FirstOrDefault(c => c.Surname + " " + c.Name + " " + c.Patronymic == CapitanBox.Text).Id;
                    
                    MainWindow.db.Team.Add(team);  
                    MainWindow.db.SaveChanges();
                    teamList.ItemsSource = MainWindow.db.Team.ToList();
                    teamnamebox.Text = "";
                    CapitanBox.Text = "";
                    MessageBox.Show("готово");
            }
            catch { MessageBox.Show("что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
           
            
        }

        private void teamList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selteam = teamList.SelectedItem as Team;
            if(selteam != null)
            {
                teamnamebox.Text = selteam.TeamName;
                CapitanBox.Text = selteam.Player.Surname + " " +  selteam.Player.Name + " " + selteam.Player.Patronymic;
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (selteam != null)
                {
                    selteam.TeamName = teamnamebox.Text;
                    selteam.CapitanId = MainWindow.db.Player.FirstOrDefault(c => c.Surname + " " + c.Name + " " + c.Patronymic == CapitanBox.Text).Id;
                    teamnamebox.Text = "";
                    CapitanBox.Text = "";
                    MainWindow.db.SaveChanges();
                    teamList.ItemsSource = MainWindow.db.Team.ToList();
                    MessageBox.Show("готово");
                }
            }
            catch { MessageBox.Show("что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.db.Team.Remove(selteam);
                teamnamebox.Text = "";
                CapitanBox.Text = "";
                MainWindow.db.SaveChanges();
                teamList.ItemsSource = MainWindow.db.Team.ToList();
                MessageBox.Show("готово");
            }
            catch { MessageBox.Show("что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }
    }
}
