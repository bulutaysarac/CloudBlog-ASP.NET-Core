﻿using CloudBlog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CloudBlog.Lib.Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}