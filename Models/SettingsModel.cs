using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldHunterAIGame.Models
{
    public class SettingsModel
    {
        public int areaXSize { get; set; } 
        public int areaYSize { get; set; }
        public int goldRate { get; set; }
        public int secretGoldRate { get; set; }
        public int turnMoveMAX { get; set; }
        public int playerTotalGold { get; set; }
        public int[] turnCost = new int[4];
        public int[] findTargetCost = new int[4];
    }
}
