using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Enemy
    {
        public double Health {  get; set; }
        public int MaxHealth { get; set; }
        public int Stamina {  get; set; }
        public int MaxStam {  get; set; }
        public int AtkAmmount { get; set; }
        public int MaxAtkAmmount { get; set; }


        public Enemy (double health, int maxh, int stame, int maxstame, int atkammount, int maxatkammount) 
        {
            Health = health;
            MaxHealth = maxh;
            Stamina = stame;
            MaxStam = maxstame;
            AtkAmmount = atkammount;
            MaxAtkAmmount = maxatkammount;

        }
    }
}
