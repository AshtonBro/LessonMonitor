﻿using System;

namespace LessonMonitor.Core
{
    public class User
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Nicknames { get; set; }

        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public string ChangeEmail(string newEmail)
        {
            if (string.IsNullOrEmpty(newEmail)) throw new Exception("Age must be between 7 and 100");

            return Email = newEmail;
        }
    }
}