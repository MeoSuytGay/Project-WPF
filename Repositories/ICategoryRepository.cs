﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BussinessObjects;

namespace Repositories
{
    public interface ICategoryRepository
    {
        List<Category> GetCategories();
    }
}
