﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SocialMediaCore.Entidades.QueryFilters
{
    public class PostQueryFilters
    {
        public int? UserId { get; set; }
        public DateTime? Date { get; set; }
        public string Description { get; set; }
        public int  PageSize { get; set; }
        public int  PageNumber { get; set; }
    }
}
