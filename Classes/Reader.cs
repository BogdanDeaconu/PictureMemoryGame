using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;
using System.Xml.Linq;

namespace PhotoMemoryGame
{
    public class Reader
    {
        public List<User> ReadUsers(string filepath)
        {
            List<User> users = new List<User>();
            XDocument xDocument = XDocument.Load(filepath);
            foreach(XElement element in xDocument.Element("users").Elements("user"))
            {
                User user = new User();
                user.username = element.Element("username").Value;
                user.photoIndex = int.Parse(element.Element("photoIndex").Value);
                user.games = int.Parse(element.Element("games").Value);
                user.wins = int.Parse(element.Element("wins").Value);
                users.Add(user);
            }
            return users;
        }
    }
}
