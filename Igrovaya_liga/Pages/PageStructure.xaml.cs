using Igrovaya_liga.DataModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Igrovaya_liga.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageStructure.xaml
    /// </summary>
    public partial class PageStructure : Page
    {
        Structure selstructure;
        Team team;
        public PageStructure(Team sel)
        {
            InitializeComponent();
            teamplayerList.ItemsSource = MainWindow.db.Structure.Where(c => c.TeamId == sel.Id).ToList();
            playerbox.ItemsSource = MainWindow.db.Player.Select(c => c.Surname + " " + c.Name + " " + c.Patronymic).ToList();
            team = sel;
        }

        private void addbtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                Structure structure = new Structure();

                structure.TeamId = team.Id;
                structure.PlayerId = MainWindow.db.Player.FirstOrDefault(c => c.Surname + " " + c.Name + " " + c.Patronymic == playerbox.Text).Id;
                MainWindow.db.Structure.Add(structure);
                MainWindow.db.SaveChanges();
                teamplayerList.ItemsSource = MainWindow.db.Structure.Where(c => c.TeamId == team.Id).ToList();
                MessageBox.Show("готово");
            }
            catch { MessageBox.Show("что-то пошло не так","ошибка",MessageBoxButton.OK,MessageBoxImage.Error); }
        }

        private void deletebtn_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            try
            {
                MainWindow.db.Structure.Remove(selstructure);
                MainWindow.db.SaveChanges();
                teamplayerList.ItemsSource = MainWindow.db.Structure.Where(c => c.TeamId == team.Id).ToList();
                playerbox.Text = "";
                MessageBox.Show("готово");
            }
            catch { MessageBox.Show("выберите игрока", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void teamplayerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selstructure = teamplayerList.SelectedItem as Structure;

            if(selstructure != null)
            {
                playerbox.Text = selstructure.Player.Surname + " " + selstructure.Player.Name + " " + selstructure.Player.Patronymic;
            }
        }
    }
}
