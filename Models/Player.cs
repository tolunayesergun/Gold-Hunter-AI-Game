﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldHunterAIGame.Models
{
    public class Player
    {
        public int playerdID { get; set; }
        public int playerGold { get; set; }
        public int buttonNum { get; set; }
        public int target { get; set; }
        public string playerButtonName { get; set; }
        public string playerName { get; set; }
        public Cordinant playerLocation { get; set; }
        public int stat { get; set; }
        public int StepCount { get; set; }
        public int spentGold { get; set; }
        public int collectedGold { get; set; }
    }
}
