﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MigrationEngine.Tasks
{
    public interface IMigrateTask
    {
        void Doit(IMigrationLog logger);
    }
}
