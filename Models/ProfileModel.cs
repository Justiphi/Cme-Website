using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace The_Brand_You.Models
{
    public class ProfileModel
    {
        public static User GetUser(string Id)
        {
            List<User> AllUsers = SetupUsers();
            List<User> SelectedUsers = AllUsers.Where(x => x.Username.ToUpper() == Id.ToUpper()).ToList();
            if(SelectedUsers.Count == 0)
            {
                return new User()
                {
                    FirstName = "Woops",
                    Description = new List<string>() { "This User does not exist on our platform!" }
                };
            }
            else
            {
                return SelectedUsers.First();
            }
        }

        public static List<User> AllUsers()
        {
            return SetupUsers();
        }

        public static List<User> SetupUsers()
        {
            List<User> AllUsers = new List<User>();

            User user1 = new User()
            {
                Username = "Justiphi",
                FirstName = "Travis",
                LastName = "Wylie",
                Sector = "IT",
                Description = new List<string>() { "I am a software developer that loves to code." },
                Categories = new List<string>() { "Software", "Development", "Entrepeneur" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/36919737_806293209575111_5009087213338624000_n.jpg?_nc_cat=0&oh=504db0a139706ce0c59c0aa0adb760a4&oe=5BF8F9D7",
                videos = new List<string>() { "eOnWWwNB8ZI" },
                facebook = "https://www.facebook.com/travis.wylie3",
                twitter = "Justiphi",
                Contact = "Hidden"
            };
            User user2 = new User()
            {
                Username = "Beckintosh",
                FirstName = "James",
                LastName = "Beck",
                Sector = "IT",
                Description = new List<string>() { "I am a software developer and am interested in competitive eating." },
                Categories = new List<string>() { "Software", "Development"},
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/21105708_1558875904135006_4567482220395971874_n.jpg?_nc_cat=0&oh=45f8321ed4508ff4aedbe2e6bdbd18e9&oe=5C2EA5CB",
                Contact = "Hidden"
            };
            User user3 = new User()
            {
                Username = "Josh",
                FirstName = "Josh",
                LastName = "Trebilco",
                Sector = "Business",
                Description = new List<string>() { "I solve ideas." },
                Categories = new List<string>() { "Software", "Development", "Entrepeneur", "Business" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/1484391_10153289538688210_2895077861458501085_n.jpg?_nc_cat=0&oh=13c474c5910108df2ae72aca0378b9b7&oe=5C30D67B",
                Contact = "Hidden"
            };
            User user4 = new User()
            {
                Username = "Renay",
                FirstName = "Renay",
                LastName = "Charteris",
                Sector = "Community",
                Description = new List<string>() { "Interested in working on projects around community development with focus on youth and innovation." },
                Categories = new List<string>() { "Entrepeneur", "Volunteer" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/33508374_1916632175035059_8017839038297800704_n.jpg?_nc_cat=0&oh=edcad641860d144042d044d694cfd2ba&oe=5C2E0735",
                Contact = "Hidden"
            };
            User user5 = new User()
            {
                Username = "Renee",
                FirstName = "Renee",
                LastName = "Raroa",
                Sector = "Education",
                Description = new List<string>() { "Action Activist", "korero2kiko" },
                Categories = new List<string>() { "Entrepeneur", "Impact" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/15785_122892544716519_6104846934323004351_n.jpg?_nc_cat=0&oh=9ee0f30b87271fc88879ba54ed89c04a&oe=5BECC4D9",
                Contact = "Hidden"
            };
            User user6 = new User()
            {
                Username = "Emelie_nz",
                FirstName = "Emelie",
                LastName = "Verseput",
                Sector = "Marketing",
                Description = new List<string>() { "I am a marketing student and love the outdoors.","I am interested in design and creative practices." },
                Categories = new List<string>() { "Supply", "Enviroment", "International" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/39098050_2674849126072965_2012768055980982272_n.jpg?_nc_cat=0&oh=27234674679bde43b054035061a0596a&oe=5BF29403",
                Contact = "Hidden"
            };
            User user7 = new User()
            {
                Username = "Texas",
                FirstName = "Keegan",
                LastName = "Frost-Jones",
                Sector = "Marketing",
                Description = new List<string>() { "I am a recent process engineer graduate interested in business and marketing." },
                Categories = new List<string>() { "Process Design", "Manufacturing", "Quality Control" },
                ImageLink = "https://scontent-syd2-1.xx.fbcdn.net/v/t1.0-9/17191411_1562732640421118_2126039364760726768_n.jpg?_nc_cat=0&oh=115fcd783f3da38ff2f38d54809aacc3&oe=5C2FEA1F",
                Contact = "Hidden"
            };
            User user8 = new User()
            {
                Username = "Lingy",
                FirstName = "Lingy",
                LastName = "Au",
                Sector = "Education",
                Description = new List<string>() { "Im passionate about connecting people.", "I live an active lifestyle and love getting outdoors." },
                Categories = new List<string>() { "Sports", "Entrepeneur", "UXUI", "Youth" },
                ImageLink = "https://media.licdn.com/dms/image/C4E03AQERLmBnRtjSYA/profile-displayphoto-shrink_800_800/0?e=1541635200&v=beta&t=uK66ljfJ46ptgOL3eDiQU74klNxJDUM0GN7_EHW5gjM",
                linkedin = "https://www.linkedin.com/in/lingyau/",
                facebook = "https://www.facebook.com/lingy.au88",
                twitter = "lingyau88",
                videos = new List<string>() { "O8yusO1L2Kc" },
                Contact = "Hidden"
            };

            AllUsers.Add(user1);
            AllUsers.Add(user2);
            AllUsers.Add(user8);
            AllUsers.Add(user4);
            AllUsers.Add(user5);
            AllUsers.Add(user6);
            AllUsers.Add(user7);
            AllUsers.Add(user3);
            return AllUsers;
        }
    }

    public class User
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Sector { get; set; }
        public List<string> Description { get; set; }
        public List<string> Categories { get; set; }
        public string ImageLink { get; set; }
        public string Contact { get; set; }
        public string linkedin { get; set; }
        public string facebook { get; set; }
        public string twitter { get; set; }
        public List<string> videos { get; set; }
    }
}
