using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace FrontEnd
{
    internal class ForumPage
    {
        enum state { START, END }
        public bool display()
        {
            state state = state.START;
            while (state != state.END)
            {
                Console.WriteLine("Forum Page");
                Console.WriteLine("Selamat datang di bulan "+ Kalender.Month.Januari + " dan mempunyai hari " + Kalender.GetDays(Kalender.Month.Januari));
                Console.WriteLine("1. Create Forum");
                Console.WriteLine("2. List Forum");
                Console.WriteLine("3. Detail Forum");
                Console.WriteLine("4. Update Forum");
                Console.WriteLine("5. Delete Forum");
                Console.WriteLine("6. Logout");
                Console.Write("Choose: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        createForum();
                        break;
                    case 2:
                        listForum();
                        break;
                    case 3:
                        detailForum();
                        break;
                    case 4:
                        updateForum();
                        break;
                    case 5:
                        deleteForum();
                        break;
                    case 6:
                        state = state.END;
                        return true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            return true;
        }
        private void createForum()
        {
            Console.WriteLine("id post :");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Model.Forum forum = new Model.Forum()
            {
                id = id,
                title = title,
                content = content,
                created_at = DateTime.Now.ToString(),
                comments  = [ new Comment()
                    {
                        id = 1,
                        content = "comment 1",
                        created_at = DateTime.Now.ToString()
                    }]
            };
            client<Model.Forum> client = new client<Model.Forum>();
            string result = client.Post("https://localhost:7284/api/Forum", forum);
            Console.WriteLine(result);
        }

        private void listForum()
        {
            client<Model.Forum> client = new client<Model.Forum>();
            List<Model.Forum> forums = client.Get("https://localhost:7238/api/Forum");
            foreach (var forum in forums)
            {
                Console.WriteLine("ID: " + forum.id);
                Console.WriteLine("Title: " + forum.title);
                Console.WriteLine("Content: " + forum.content);
                Console.WriteLine();
            }
        }

        private void detailForum()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            client<Model.Forum> client = new client<Model.Forum>();
            List<Model.Forum> forums = client.Get("https://localhost:7238/api/Forum/" + id);
            try
            {
                if (forums == null)
                {
                    throw new Exception("No data found");
                    return;
                }
                else {
                    Model.Forum forum = forums[0];
                    Console.WriteLine("ID: " + forum.id);
                    Console.WriteLine("Title: " + forum.title);
                    Console.WriteLine("Content: " + forum.content);
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }

        private void updateForum()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Title: ");
            string title = Console.ReadLine();
            Console.Write("Content: ");
            string content = Console.ReadLine();
            Model.Forum forum = new Model.Forum()
            {
                title = title,
                content = content,
                created_at = DateTime.Now.ToString(),
            };
            client<Model.Forum> client = new client<Model.Forum>();
            string result = client.Put("https://localhost:7238/api/Forum/" + id, forum);
            Console.WriteLine(result);
        }

        private void deleteForum()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            client<Model.Forum> client = new client<Model.Forum>();
            string result = client.Delete("https://localhost:7238/api/Forum/" + id);
            Console.WriteLine(result);
        }
    }
}
