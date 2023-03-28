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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace PhotoMemoryGame
{
    /// <summary>
    /// Interaction logic for AddUser.xaml
    /// </summary>
    public partial class AddUser : Window
    {
        int index = 0;
        public AddUser()
        {
            InitializeComponent();
            string imagesPath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images";
            string[] images = Directory.GetFiles(imagesPath);
            BitmapImage imagesBitmap = new BitmapImage();
            imagesBitmap.BeginInit();
            imagesBitmap.UriSource = new Uri(images[index]);
            imagesBitmap.EndInit();
            UserImageControl.Source = imagesBitmap;
            UserImageControl.Margin = new Thickness(0, 0, 10, 10);
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
          
            string directoryPath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images";

           
            string[] files = Directory.GetFiles(directoryPath);

       
            if (files.Length > 0)
            {
                
                if (index < files.Length - 1)
                {
                    index++;
                }
                
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(files[index]);
                bitmap.EndInit();

               
                UserImageControl.Source = bitmap;
                UserImageControl.Margin = new Thickness(0, 0, 10, 10);
            }
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            // Seteaza calea directorului unde sunt stocate imaginile
            string directoryPath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images";

            // Extrage toate căile de fișiere din director
            string[] files = Directory.GetFiles(directoryPath);

            // Dacă există fișiere în director
            if (files.Length > 0)
            {
                // Genereaza un index aleatoriu pentru a selecta un fișier
                if (index > 0)
                {
                    index--;
                }
                // Creaza un obiect BitmapImage si incarca fisierul
                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(files[index]);
                bitmap.EndInit();

                // Seteaza sursa imaginii pentru controlul Image
                UserImageControl.Source = bitmap;
                UserImageControl.Margin = new Thickness(0, 0, 10, 10);
            }
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            User user = new User(NumeTextBox.Text, index);
            Reader reader = new Reader();
            Writer writer = new Writer();
            List<User> users = reader.ReadUsers(@"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\bin\Debug\users.xml");
            users.Add(user);
            writer.WriteUsers(users);
        }

        private void Profiles_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
