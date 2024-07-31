using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcYoutube.Models
{
    public class Video
    {
        public int Id { get; set; } 
        public string VideoId { get; set; }
        public float WatchedTime { get; set; }
        public DateTime Timestamp { get; set; }

    }
}