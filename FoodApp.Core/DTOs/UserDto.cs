﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Core.DTOs
{
    public class UserDto : BaseDto
    {
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool isDeleted { get; set; }
    }
}
