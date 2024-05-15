using backend.Model;
using Newtonsoft.Json;

namespace backend.Config
{
   
    public class UserConfig
    {
        public const string filepath = @"user.json";
        public List<user> configs;
        public UserConfig()
        {
            try
            {
                this.LoadConfig();
            }
            catch (Exception ex)
            {
                this.SaveConfig();
            }
        }
        public List<user> LoadConfig()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;

            String jsonString = File.ReadAllText(path + "/backend/" + filepath);
            this.configs = JsonConvert.DeserializeObject<List<user>>(jsonString);
            return configs;
        }

        public void add(user user)
        {
            List<user> c = this.LoadConfig();
            this.configs.Add(user);
        }

        public void edit(user forum)
        {
            List<user> c = this.LoadConfig();
            user f = c.Find(x => x.id == forum.id);
            f.username = forum.username;
            f.password = forum.password;
        }

        public void delete(int id)
        {
            List<user> c = this.LoadConfig();
            user f = c.Find(x => x.id == id);
            c.Remove(f);
        }

        public void SaveConfig()
        {
            String path = Directory.GetParent(Directory.GetCurrentDirectory()).FullName;
            String jsonString = JsonConvert.SerializeObject(configs);
            File.WriteAllText(path + "/backend/" + filepath, jsonString);
        }
    }
}
