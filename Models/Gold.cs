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
        public int value { get; set; }   // Değeri (5-10-15-20)
        public int buttonNum { get; set; }  // 
        public string button { get; set; }
        public bool isSecret { get; set; }
        public bool isTaken { get; set; }
        public Cordinant goldLocation { get; set; }
    }
}
