﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player: Creature
    {
        public Player(int gold, int experiencePoints, int currentHitPoints, int maximumHitPoints, int level): 
            base(currentHitPoints, maximumHitPoints)
        {
            Gold = gold;
            ExperiencePoints = experiencePoints;
            Level = level;
        }

        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
    }
}
