﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VRCExtended.Modules
{
    internal interface IExtendedModule
    {
        void Setup();
        IEnumerator AsyncSetup();
    }
}
