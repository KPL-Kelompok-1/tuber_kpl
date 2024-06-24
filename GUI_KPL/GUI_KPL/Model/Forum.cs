using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Model
{
    public class Forum
    {
        public int id { get; set; }
        public string title { get; set; }
        public string content { get; set; }
        public string created_at { get; set; }
    }
}