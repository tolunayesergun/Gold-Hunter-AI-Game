using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoldHunterAIGame.Models
{
    class Gold
    {
        public int goldID { get; set; }
        public bool isSecret { get; set; }
        public int value { get; set; }
        public Cordinant pozition { get; set; }
        public string button { get; set; }
        public int buttonNum { get; set; }
    }
}
