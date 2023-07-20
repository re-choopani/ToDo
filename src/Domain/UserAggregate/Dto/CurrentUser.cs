﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.UserAggregate.Dto
{
    public class CurrentUser
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> Claims { get; set; }
    }
}
