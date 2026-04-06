using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Enemy
    {
        public double Health {  get; set; }
        public int MaxHealth { get; set; }
        private int stamina { get; set; }
        public int Stamina 
        {   get
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
        public int AtkAmmount { get; set; }
        public Enemy (double health, int maxh, int stame, int atkammount) 
        {
            Health = health;
            MaxHealth = maxh;
            Stamina = stame;
            AtkAmmount = atkammount;
        }
    }
}
