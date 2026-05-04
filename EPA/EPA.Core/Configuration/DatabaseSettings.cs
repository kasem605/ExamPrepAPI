using System;
using System.Collections.Generic;
using System.Text;

namespace EPA.Core.Configuration
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = default!;
        public string Provider { get; set; } = default!;
        public int Timeout { get; set; }
    }
}
