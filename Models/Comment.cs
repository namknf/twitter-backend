﻿namespace Twitter_backend.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class Comment
    {
        public int CommentId { get; set; }

        public string Text { get; set; }

        public DateTime DateComment { get; set; }

        public Tweet TweetId { get; set; }

        public Profile ProfileId { get; set; }
    }
}
