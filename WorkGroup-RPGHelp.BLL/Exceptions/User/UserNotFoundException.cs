﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkGroup_RPGHelp.BLL.Exceptions.User
{
    public class UserNotFoundException : NotFoundException
    {
        public UserNotFoundException() : base("User not found")
        {
        }
        public UserNotFoundException(string message) : base(message)
        {
        }
    }
}
