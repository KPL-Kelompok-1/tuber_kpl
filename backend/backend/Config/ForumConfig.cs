using backend.Model;
using Newtonsoft.Json;

namespace backend.Config
{
    public class ForumConfig
    {
        public static List<Forum> configs { get; set; }
        public const string filepath = @"forum.json";

        static ForumConfig() // Use static constructor to load on class initialization
        {
            try
            {
                LoadConfig();
            }
            catch (Exception ex)
            {
                SaveConfig(new List<Forum>()); // Save an empty list on error
            }
        }

        public static List<Forum> LoadConfig(int id = -1)
        {
            if (configs == null)
            {
                configs = new List<Forum>(); // Initialize list if not already set
            }
            if (id != -1)
            {
                try
                {
                    List<Forum> output = new List<Forum>
                    {
                        Filter<Forum>.filter(configs, "id", id)
                    };
                    if (output[0] == null)
                    {
                        throw new Exception("No data found");
                    }
                    return output;
                }
                catch (Exception ex)
                {
                    List<Forum> output = new List<Forum>();
                    return output;
                }
            }
            else {
                try
                {
                    String path = Path.Combine(Directory.GetCurrentDirectory(), "..", "backend", filepath);
                    String jsonString = File.ReadAllText(path);
                    configs = JsonConvert.DeserializeObject<List<Forum>>(jsonString); // ubah list jadi String array
                    if (configs == null)
                    {
                        throw new Exception("No data found");
                    }
                }catch (Exception ex)
                {
                    configs = new List<Forum>();
                }
            }
            //for (int i = 0; i < 100000; i++) { }
            return configs;
        }

        public static void Add(Forum forum)
        {
            LoadConfig(); 
            configs.Add(forum);
            SaveConfig();
        }

        public static void Edit(Forum forum, int id)
        {
            LoadConfig();
            var f = Filter<Forum>.filter(configs, "id", id);
            f.title = forum.title;
            f.content = forum.content;
            SaveConfig();
        }

        public static void Delete(int id)
        {
            LoadConfig();
            List<Forum> c = LoadConfig();
            Forum f = Filter<Forum>.filter(c, "id", id);
            c.Remove(f);
            SaveConfig();
        }

        public static void SaveConfig(List<Forum> data = null) 
        {
            try
            {
                if (data == null)
                {
                    if (configs == null)
                    {
                        throw new Exception("No data to save");
                    }
                }
                String path = Path.Combine(Directory.GetCurrentDirectory(), "..", "backend", filepath);
                String jsonString = JsonConvert.SerializeObject(data ?? configs);
                File.WriteAllText(path, jsonString);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
    }
}
