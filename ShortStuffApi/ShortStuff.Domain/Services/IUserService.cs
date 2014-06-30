﻿using System.Collections.Generic;
using ShortStuff.Domain.Entities;

namespace ShortStuff.Domain.Services
{
    public interface IUserService
    {
        IEnumerable<User> GetAll();
    }
}