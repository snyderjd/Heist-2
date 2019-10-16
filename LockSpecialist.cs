using System;

namespace Heist_2
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public string Specialty { get; set; }

        public LockSpecialist(string name, int skillLevel, int percentageCut)
        {
            Name = name;
            SkillLevel = skillLevel;
            PercentageCut = percentageCut;
            Specialty = "Lock Specialist";
        }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore = bank.VaultScore - SkillLevel;
            Console.WriteLine($"{Name} is working on the bank vault. Decreased vault security {SkillLevel}");
            
            if (bank.VaultScore <= 0)
            {
                Console.WriteLine($"{Name} has successfully opened the vault!");
            }
        }
    }
}