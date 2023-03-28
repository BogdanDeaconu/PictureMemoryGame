using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhotoMemoryGame.Classes
{
    internal class Matrice
    {
        public List<List<Tile>> matrix { get; set; }

        public int Rows { get; set; }

        public int Columns { get; set; }

        public int Level { get; set; }

        public Tile FirstFlippedTile { get; set; }

        public Tile SecondFlippedTile { get; set; }

        public Matrice()
        {
            
        }
        
        public Matrice(int rows,int columns,int level)
        {
            this.FirstFlippedTile = null;
            this.SecondFlippedTile = null;

            this.Rows = rows;
            this.Columns = columns;
            this.Level = level;

            this.matrix = new List<List<Tile>>();

            for(int index_rows = 0; index_rows < rows; index_rows++)
            {
                this.matrix.Add(new List<Tile>());
                for(int index_columns = 0; index_columns < columns; index_columns++)
                {
                    matrix[index_rows].Add(new Tile());
                }
            }
            AddTiles();
            this.Level=level;
        }
        

        public void AddTiles()
        {
            Random random = new Random();
            string imagesPath = @"C:\Facultate\Anu2 Sem2\MVP\PhotoMemoryGame\PhotoMemoryGame\Images\";
            string[] files = Directory.GetFiles(imagesPath);
            int n = Rows * Columns;
            String[] value = new string[n];

            for (int index = 0; index < n / 2; index++)
            {
                value[2 * index] = files[index];
                value[2 * index + 1] = files[index];
            }

            for (int index = 0; index < n; index++)
            {
                int shuffle = random.Next(n);
                string aux = value[index];
                value[index] = value[shuffle];
                value[shuffle] = aux;
            }

            for(int index_rows = 0; index_rows < Rows; index_rows++)
            {
                for(int index_column = 0; index_column < Columns; index_column++)
                {
                    Tile tile = new Tile();
                    tile.ImagePath = value[index_rows * Columns + index_column];
                    tile.row = index_rows;
                    tile.column = index_column;
                    matrix[index_rows][index_column] = tile;
                }
            }
        }

        public bool verifyWin()
        {
            int counter = 0;
            int counterfornull = 0;
            for (int index_rows = 0; index_rows < Rows; index_rows++)
            {
                for (int index_columns = 0; index_columns < Columns; index_columns++)
                {
                    if (matrix[index_rows][index_columns].ImagePath == null)
                    {
                        counterfornull++;
                    }
                    if (matrix[index_rows][index_columns].Visibility == Visibility.Collapsed)
                    {
                        counter++;
                    }
                    
                }
            }
            if (counterfornull == 1)
            {
                if (counter == 1)
                {
                    return true;
                }
                else{ 
                    return false;
                }
            }
            else
            {
                if (counter == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
