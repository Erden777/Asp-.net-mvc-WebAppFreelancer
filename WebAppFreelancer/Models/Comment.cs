using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppFreelancer.Models
{
    public class Comment
    {
        public int comment_id { get; set; }
        //Fk project id
        public Project project { get; set; }
        //Comment text 
        public string text { get; set; }
        //Fk user id
        public User user { get; set; }
        //posted time
        public DateTime date_time { get; set; }
    }
}