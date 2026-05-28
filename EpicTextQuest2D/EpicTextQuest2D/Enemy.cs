using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Enemy
    {
        public int Stamina {  get; set; }
        public int MaxStam {  get; set; }
        public int AtkAmmount { get; set; }
        public int MaxAtkAmmount { get; set; }


        public Enemy (int stame, int maxstame, int atkammount, int maxatkammount) 
        {
            Stamina = stame;
            MaxStam = maxstame;
            AtkAmmount = atkammount;
            MaxAtkAmmount = maxatkammount;

        }
    }
}
