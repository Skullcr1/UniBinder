﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniBinderAPI.Models;

namespace UniBinderAPI.Database
{
    interface IUserDataInserter
    {
        void SendUserData(Person person);
    }
}