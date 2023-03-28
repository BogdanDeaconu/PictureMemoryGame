using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PhotoMemoryGame
{
    internal class Tile
    {
        public string ImagePath { get; set; }

        public bool IsFlipped { get; set; }

        public Visibility Visibility { get; set; }

        public int row { get; set; }

        public int column { get; set; }

        public Tile()
        {
            this.IsFlipped = false;
            this.Visibility = Visibility.Collapsed;
        }

    }
}
