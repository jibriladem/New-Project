﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MROCoatching.DataObjects.Models.Operational
{
    public class User
    {
        public static object Identity { get; internal set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
    }
}
