using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PhotoMemoryGame
{
    public class Writer
    {
        public void WriteUsers(List<User> users)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;

            using (XmlWriter writer = XmlWriter.Create("users.xml", settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("users");
                foreach (User user in users)
                {
                    writer.WriteStartElement("user");
                    writer.WriteElementString("username", user.username);
                    writer.WriteElementString("photoIndex", user.photoIndex.ToString());
                    writer.WriteElementString("games", user.games.ToString());
                    writer.WriteElementString("wins", user.wins.ToString());
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
        }
    }
}
