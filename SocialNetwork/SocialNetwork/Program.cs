﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile user1 = new Profile("Bob");
            user1.Name = "Sam";
            user1.SayHello();
        }
    }
}