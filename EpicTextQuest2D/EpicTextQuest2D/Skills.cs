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
        public Skills (string name, string desc, double dmg, int cost, int heal)
        {
            SkillName = name;
            Description = desc;
            Damage = dmg;
            Cost = cost;
            Heal = heal;
        }
        public void SkillUse()
        {
            Console.WriteLine($"{SkillName} - {Description}\nНаносит {Damage} единиц урона.\nТратит {Cost} единиц выносливости.\nСделал ли я правильный выбор? Д/Н");
        }
    }
}
