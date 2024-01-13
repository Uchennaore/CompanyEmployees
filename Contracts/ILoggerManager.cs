﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ILoggerManager
    {
        void LogInfo(String message);
        void LogWarn(String message);
        void LogDebug(String message);
        void LogError(String message);
        

    }
}
