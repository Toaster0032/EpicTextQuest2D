using System;
using System.Collections.Generic;
using System.Text;

namespace EpicTextQuest2D
{
    public class Skills
    {
        public double Damage {  get; set; }
        public string SkillName { get; set; }
        public string Description { get; set; }
        public int Cost { get; set; }
        public int Heal {  get; set; }
        public int Stun {  get; set; }
        public Skills (string name, string desc, double dmg, int cost, int heal, int stun)
        {
            SkillName = name;
            Description = desc;
            Damage = dmg;
            Cost = cost;
            Heal = heal;
            Stun = stun;
        }
        
        public void SkillUse()
        {
            Console.WriteLine($"{SkillName} - {Description}\nТратит {Cost} единиц выносливости.");
            if (Stun != 0)
            {
                Console.Write("Ошеломляет противника на 1 ход");
                if (Stun > 1)
                {
                    Console.WriteLine("а.");
                }
                else if (Stun == 1) 
                {
                    Console.WriteLine(".");
                }
                if (Heal > 0)
                {
                    Console.WriteLine($"Мне вернеться {Heal} единиц здоровья.");
                }
                else if (Heal < 0)
                {
                    Console.WriteLine($"Я получу {Heal} единиц урона.");
                }
            }
            Console.WriteLine($"Сделал ли я правильный выбор? Д/Н");
        }
    }
}
