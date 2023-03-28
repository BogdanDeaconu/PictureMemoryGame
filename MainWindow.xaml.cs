using System;
using System.Collections.Generic;
using System.IO;
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

namespace PhotoMemoryGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> users = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            string filePath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\bin\Debug\users.xml";
            Reader reader = new Reader();
            users = reader.ReadUsers(filePath);
            foreach (User user in users)
            {
                UsersList.Items.Add(user.username);
            }
            
        }

        private void listBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
            String username = (String)UsersList.SelectedItem;
            User user = users.Find(x => x.username == username);
            if (user == null)
            {
                return;
            }
            int index = user.photoIndex;
            
            
            string[] files = Directory.GetFiles(@"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images\");

            
            if (files.Length > 0)
            {

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(files[index]);
                bitmap.EndInit();

               
                image.Source = bitmap;
                image.Margin = new Thickness(0, 0, 10, 10);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           int nrLinii = int.Parse(NrlINII.Text);
           int nrColoane = int.Parse(NrColoane.Text);
           Game game = new Game(nrLinii, nrColoane);
           game.Show();
           this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            this.Close();
        }
        
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            String username = (String)UsersList.SelectedItem;
            User user = users.Find(x => x.username == username);
            users.Remove(user);
            UsersList.Items.Clear();
            string filePath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\bin\Debug\users.xml";
            Writer writer = new Writer();
            Reader reader = new Reader();
            writer.WriteUsers(users);
            users = reader.ReadUsers(filePath);
            foreach (User user1 in users)
            {
               UsersList.Items.Add(user1.username);
            }
        }
    }
}
