﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(BranchStrategy.Startup))]

namespace BranchStrategy
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // another change comes in here for develop2.
            ConfigureAuth(app);
        }
    }
}
