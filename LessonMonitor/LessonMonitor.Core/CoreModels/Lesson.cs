﻿using System;

namespace LessonMonitor.Core.CoreModels
{
    public class Lesson
    {
        public string YouTubeBroadcastId { get; set; }

        public DateTime StartDate { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
