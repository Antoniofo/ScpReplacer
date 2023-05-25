﻿using Exiled.API.Features;
using Exiled.API.Features.Roles;
using MEC;
using System.Collections.Generic;

namespace SCPReplacer
{
    public class ScpToReplace
    {
        public Role Role { get; set; }
        public string Name { get; set; }
        public HashSet<Player> Volunteers { get; set; }
        public CoroutineHandle? LotteryTimeout { get; set; } = null;
    }
}