using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldHunterAIGame.Models
{
    class Players
    {
        public int playerdID { get; set; }
        public int playerGold { get; set; }
        public int buttonNum { get; set; }
        public string playerButtonName { get; set; }
        public string playerName { get; set; }
        public Cordinant playerLocation { get; set; }
    }
}
