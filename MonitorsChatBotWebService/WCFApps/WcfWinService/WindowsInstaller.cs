﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace WcfWinService
{
    [RunInstaller(true)]
    public partial class WindowsInstaller : System.Configuration.Install.Installer
    {
        public WindowsInstaller()
        {
            InitializeComponent();
        }
    }
}
