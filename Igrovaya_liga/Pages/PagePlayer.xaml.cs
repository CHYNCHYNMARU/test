using Igrovaya_liga.DataModel;
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

namespace Igrovaya_liga.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePlayer.xaml
    /// </summary>
    public partial class PagePlayer : Page
    {
        Player selplayer;
        public PagePlayer()
        {
            InitializeComponent();
            playerList.ItemsSource = MainWindow.db.Player.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void playerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             selplayer = playerList.SelectedItem as Player;

            if(selplayer != null)
            {
                surnamebox.Text = selplayer.Surname;
                namebox.Text = selplayer.Name;
                patronymicbox.Text = selplayer.Patronymic;
                phonebox.Text = selplayer.Phone;
                adressbox.Text = selplayer.Adress;
                resultpointbox.Text = selplayer.resultpoint.ToString();
            }
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Player player = new Player();
                player.Name = namebox.Text;
                player.Surname = surnamebox.Text;
                player.Patronymic = patronymicbox.Text;
                player.Phone = phonebox.Text;
                player.Adress = adressbox.Text;
                player.resultpoint = Convert.ToInt32(resultpointbox.Text);
                MainWindow.db.Player.Add(player);
                MainWindow.db.SaveChanges();
                playerList.ItemsSource = MainWindow.db.Player.ToList();
                namebox.Text = "";
                surnamebox.Text = "";
                patronymicbox.Text = "";
                phonebox.Text = "";
                adressbox.Text = "";
                resultpointbox.Text = "";
                MessageBox.Show("Готово");
            }
            catch { MessageBox.Show("Что-то пошло не так","Ошибка",MessageBoxButton.OK, MessageBoxImage.Error); }
            
        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if(selplayer != null)
                {
                    selplayer.Name = namebox.Text;
                    selplayer.Surname = surnamebox.Text;
                    selplayer.Patronymic = patronymicbox.Text;
                    selplayer.Phone = phonebox.Text;
                    selplayer.Adress = adressbox.Text;
                    selplayer.resultpoint = Convert.ToInt32(resultpointbox.Text);
                    MainWindow.db.SaveChanges();
                    playerList.ItemsSource = MainWindow.db.Player.ToList();
                    namebox.Text = "";
                    surnamebox.Text = "";
                    patronymicbox.Text = "";
                    phonebox.Text = "";
                    adressbox.Text = "";
                    resultpointbox.Text = "";
                    MessageBox.Show("Готово");
                }
            }
            catch { MessageBox.Show("Выберите игрока", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
            
        }

        private void deletebtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MainWindow.db.Player.Remove(selplayer);
                MainWindow.db.SaveChanges();
                playerList.ItemsSource = MainWindow.db.Player.ToList();
                namebox.Text = "";
                surnamebox.Text = "";
                patronymicbox.Text = "";
                phonebox.Text = "";
                adressbox.Text = "";
                resultpointbox.Text = "";
                MessageBox.Show("Готово");

            }
            catch { MessageBox.Show("Выберите игрока", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error); }
        }

        private void resultpointbox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }

        private void phonebox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0))
            {
                e.Handled = true;
            }
        }
    }
}
