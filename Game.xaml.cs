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
using System.Windows.Shapes;

namespace PhotoMemoryGame
{
    /// <summary>
    /// Interaction logic for Game.xaml
    /// </summary>
    public partial class Game : Window
    {
        string photoPath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images";
        int rows, columns;
        Classes.Matrice matrix;

        public Game(int rows,int columns)
        {
            int level = 0;
            InitializeComponent();
            matrix = new Classes.Matrice(rows, columns,level);
            DataContext = matrix;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            Tile tile = button.DataContext as Tile;
            
            if (matrix.FirstFlippedTile == null)
            {
                matrix.FirstFlippedTile = tile;
                tile.Visibility = Visibility.Visible;
                Img.Items.Refresh();
            }
            else
            {
                matrix.SecondFlippedTile = tile;
                tile.Visibility = Visibility.Visible;
                Img.Items.Refresh();
                if (matrix.FirstFlippedTile.ImagePath == matrix.SecondFlippedTile.ImagePath)
                {
                    matrix.FirstFlippedTile = null;
                    matrix.SecondFlippedTile = null;
                    if (matrix.verifyWin())
                    {
                        MessageBox.Show("You won!");
                    }
                }
                else
                {
                    Task.Delay(TimeSpan.FromSeconds(2)).ContinueWith(t =>
                    {
                        System.Windows.Application.Current.Dispatcher.Invoke(() =>
                        {
                            matrix.FirstFlippedTile.Visibility = Visibility.Collapsed;
                            matrix.SecondFlippedTile.Visibility = Visibility.Collapsed;
                            matrix.FirstFlippedTile = null;
                            matrix.SecondFlippedTile = null;
                            Img.Items.Refresh();
                        });
                    });
            }   }
           
        }

        public void winGame()
        {
            if (matrix.verifyWin() == true)
            {
                if (matrix.Level + 1 == 3)
                {
                    MessageBox.Show("You won!");
                }
                else
                {
                    matrix.Level++;
                    int level = matrix.Level;
                    matrix = new Classes.Matrice(rows, columns, level);
                    DataContext = matrix;
                    Img.Items.Refresh();
                }
            }
        }
    }
}
