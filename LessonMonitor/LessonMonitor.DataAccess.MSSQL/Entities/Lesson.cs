using System;
using System.Collections.Generic;

namespace LessonMonitor.DataAccess.MSSQL.Entities
{
    public class Lesson : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public string YouTubeBroadcastId { get; set; }

        public ICollection<Homework> Homeworks { get; set; }

        public ICollection<VisitedLesson> VisitedLessons { get; set; }
    }
}
