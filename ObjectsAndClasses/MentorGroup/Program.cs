using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MentorGroup
{
    class Program
    {
        class User
        {
            public string Name { get; set; }

            public List<DateTime> Dates { get; set; }

            public List<string> Comments { get; set; }
        }

        static void Main()
        {
            var input = Console.ReadLine();

            var users = new List<User>();

            while (input != "end of dates")
            {
                var tokens = input
                    .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                var username = tokens[0];
                var dates = tokens.Skip(1).Select(x => DateTime.ParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();

                var user = new User()
                {
                    Name = username,
                    Dates = dates
                };

                users.Add(user);

                input = Console.ReadLine();
            }

            var input2 = Console.ReadLine();

            while (input2 != "end of comments")
            {
                var tokens = input2
                    .Split('-').ToArray();
                var username = tokens[0];
                var comment = tokens[1];

                for (int i = 0; i < users.Count; i++)
                {
                    if (username == users[i].Name)
                    {
                        if (users[i].Comments == null)
                        {
                            users[i].Comments = new List<string>();
                        }

                        users[i].Comments.Add(comment);
                    }
                }

                input2 = Console.ReadLine();
            }

            foreach (var user in users.OrderBy(x => x.Name))
            {
                Console.WriteLine("{0}", user.Name);
                Console.WriteLine("Comments:");
                if (user.Comments != null)
                {
                    foreach (var comment in user.Comments)
                    {
                        Console.WriteLine("- {0}", comment);
                    }
                }

                Console.WriteLine("Dates attended:");
                foreach (var date in user.Dates.OrderBy(x => x.Date))
                {
                    Console.WriteLine("-- {0}", date.ToString("dd/MM/yyyy"));
                }
            }
        }
    }
}
