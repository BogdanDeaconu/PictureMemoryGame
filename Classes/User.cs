using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace PhotoMemoryGame
{
    [XmlRoot(ElementName = "User", Namespace = "")]
    public class User
    {
        public String username { get; set; }

        public int photoIndex { get; set; }

        public int games { get; set; }

        public int wins { get; set; }

        public User()
        {}

        public User(String username, int photoIndex)
        {
            this.username = username;
            this.photoIndex = photoIndex;
            this.games = 0;
            this.wins = 0;
        }
    }
}
