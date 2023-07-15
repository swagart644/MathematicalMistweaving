﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistweaver.SpellData.SpellModels
{
    public class YulonsWhisper : HealBase
    {
        public YulonsWhisper() 
        {
            SpellId = 388038;
            Name = SpellNames.YulonsWhisper;
            Coefficient = 147.49m;
            MaxTargets = 5;
            CastTime = 0m;
            Cooldown = 30;
            IsIndirect = true;
            StatScaling = new StatScaling()
            {
                CriticalStrike = true,
                Haste = false,
                Mastery = false,
                Versatility = true
            };
        }
    }
}
