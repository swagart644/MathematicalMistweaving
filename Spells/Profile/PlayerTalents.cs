﻿using Mistweaver.Data.Talents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mistweaver.Data.Profile
{
    public class PlayerTalents
    {
        public PlayerTalents(List<TalentBase> selectedTalents) 
        {
            this.Talents = selectedTalents;
        }
        public List<TalentBase> Talents { get; set; }
    }
}
