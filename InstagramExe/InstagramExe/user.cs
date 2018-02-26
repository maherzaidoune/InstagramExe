using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace InstagramExe
{
    public class user
    {
        public int id { get; set; }
        public String Statut { get; set; }
        public String imageUrl { get; set; }
        public String name { get; set; }

        static List<user> listUser = new List<user>
        {
            new user{id = 0,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/1/" ,name = "maher" },
            new user{id = 1,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/2/",name = "moneem" },
            new user{id = 2,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/3/",name = "zaidoune" },
            new user{id = 3,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/4/" ,name = "haroun" },
            new user{id = 4,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/5/" ,name = "hamdouni" },
            new user{id = 5,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/6/" ,name = "rrdl" },
            new user{id = 6,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/7/" , name = "achref" },
            new user{id = 7,Statut="hey there",imageUrl = "http://lorempixel.com/200/200/people/8/" ,name = "EST"}
        };

        static public List<user> getUser()
        {
            return listUser;
        }
        static public user getUser(int id)
        {
            return listUser.Where(u => u.id == id).First();
        }
    }
}
