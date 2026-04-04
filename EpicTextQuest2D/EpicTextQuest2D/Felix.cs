using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Felix
    {
        public int Health {  get; set; }
        public int MaxHealth { get; set; }
        public int Stamina { get; set; }
        public int AtkWeight { get; set; }

        public Felix(int health, int maxhealth, int stamina, int atkweight)
        {
            Health = health;
            MaxHealth = maxhealth;
            Stamina = stamina;
            AtkWeight = atkweight;
        }
    }
}
