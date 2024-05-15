namespace backend.Model
{
    public class Forum { 
        public int? id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
        public Comment[] comments { get; set; }

    }

    public class Comment
    {
        public int id { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
    }
}
