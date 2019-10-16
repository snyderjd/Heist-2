using System;

namespace Heist_2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public string Specialty { get; set; }

        public Muscle(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
            Specialty = "Muscle";
        }

        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore = bank.SecurityGuardScore - SkillLevel;
            Console.WriteLine($"{Name} is dealing with the security guards. Decreased security guard level by {SkillLevel} points");
            
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has successfully dealt with the security guards!");
            }
        }
    }
}