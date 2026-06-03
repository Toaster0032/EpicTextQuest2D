using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Felix
    {
        public double Health {  get; set; }
        public int MaxHealth { get; set; }
        public int Stamina { get; set; }
        
        public int MaxStamina { get; set; }
        public int Advantage { get; set; }
        public int AtkAmmount { get; set; }
        public int MaxAtkAmmount { get; set; }
        public int Progress { get; set; }
      
        public Felix(double health, int maxh, int stam, int maxstam, int adv, int atkammount, int maxatkammount, int progress)
        {
            Health = health;
            MaxHealth = maxh;
            Stamina = stam;
            MaxStamina = maxstam;
            Advantage = adv;
            AtkAmmount = atkammount;
            MaxAtkAmmount = maxatkammount;
            Progress = progress;
        }
    }
}
