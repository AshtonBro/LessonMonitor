﻿using System;

namespace LessonMonitor.API
{
    public class Question
    {
        public string Description { get; set; }
        public DateTime CreateTime { get; set; }
        public User User { get; set; }
    }
}