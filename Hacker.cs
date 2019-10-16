using System;

namespace Heist_2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public string Specialty { get; set; }

        public Hacker(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
            Specialty = "Hacker";
        }

        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore = bank.AlarmScore - SkillLevel;

            Console.WriteLine($"{Name} is hacking the alarm system. Decreased alarm security by {SkillLevel} points.");

            if (bank.AlarmScore <= 0)
            {
                Console.WriteLine($"{Name} has deactivated the alarm system!");
            }
        }
    }
}