using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Felix
    {
        public int Health {  get; set; }
        public int MaxHealth { get; set; }
        private int stamina { get; set; }
        public int Stamina
        {
            get 
            {
                return stamina;
            }
            set
            {
                if (value > 20)
                {
                    stamina = 20;
                }
                else if (value < 0)
                {
                    stamina = 0;
                }
                else
                {
                    stamina = value;
                }
            }

        }

        public int Advantage { get; set; }
        public int AtkAmmount { get; set; }
        public int MaxAtkAmmount { get; set; }
      
        public Felix(int health, int maxh, int stam, int adv, int atkammount, int maxatkammount)
        {
            Health = health;
            MaxHealth = maxh;
            stamina = stam;
            Advantage = adv;
            AtkAmmount = atkammount;
            MaxAtkAmmount = maxatkammount;
        }
    }
}
