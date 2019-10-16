using System;
using System.Linq;
using System.Collections.Generic;

namespace Heist_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hacker hacker1 = new Hacker("Jeff", 68, 39);
            Hacker hacker2 = new Hacker("Sally", 65, 35);
            Muscle muscle1 = new Muscle("Bob", 48, 27);
            Muscle muscle2 = new Muscle("Dan", 72, 41);
            LockSpecialist lockPicker1 = new LockSpecialist("Sue", 50, 30);
            LockSpecialist lockPicker2 = new LockSpecialist("Bo", 42, 22);

            List<IRobber> rolodex = new List<IRobber>(){
                hacker1, hacker2, muscle1, muscle2, lockPicker1, lockPicker2
            };

            // Get the first new contact's name
            Console.WriteLine("Enter the name of a new contact> ");
            string newContactName = Console.ReadLine();

            while(newContactName != "")
            {
                Console.WriteLine($"Number of Operatives Available: {rolodex.Count}");
                Console.WriteLine();

                Console.WriteLine("Select the new contact's specialy: ");
                Console.WriteLine("1) Hacker (disables alarms)");
                Console.WriteLine("2) Muscle (disarms guards)");
                Console.WriteLine("3) Lock Specialist (cracks vault)");
                Console.WriteLine();

                string specialtyInput = Console.ReadLine();

                Console.WriteLine("Enter the contact's skill level as an integer between 1 and 100");
                int skillLevel = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the contact's required percentage cut as an integer between 1 and 100");
                int percentageCut = int.Parse(Console.ReadLine());

                // Instantiate a new contact with the user's inputs and add it to the rolodex
                if (specialtyInput == "1")
                {
                    rolodex.Add(new Hacker(newContactName, skillLevel, percentageCut));
                }
                else if (specialtyInput == "2")
                {
                    rolodex.Add(new Muscle(newContactName, skillLevel, percentageCut));
                }
                else if (specialtyInput == "3")
                {
                    rolodex.Add(new LockSpecialist(newContactName, skillLevel, percentageCut));
                }

                // Get the next contact's name
                Console.WriteLine("Enter the name of a new contact> ");
                newContactName = Console.ReadLine();

            }

            // instantiate a new bank to rob
            Bank targetBank = new Bank();

            // Build and print out a recon report with the name of the most and least secure properties of the bank
            Dictionary<string, int> bankSystems = new Dictionary<string, int>();

            bankSystems.Add("Alarm System", targetBank.AlarmScore);
            bankSystems.Add("Vault", targetBank.VaultScore);
            bankSystems.Add("Security Guards", targetBank.SecurityGuardScore);

            List<KeyValuePair<string, int>> ordered = bankSystems.OrderByDescending(kvp => kvp.Value).ToList();
            List<KeyValuePair<string, int>> reverseOrdered = bankSystems.OrderBy(kvp => kvp.Value).ToList();

            Console.WriteLine("==== Bank Recon Report ====");
            Console.WriteLine($"Most Secure System: {ordered[0].Key}");
            Console.WriteLine($"Lease Secure System: {reverseOrdered[0].Key}");
            Console.WriteLine();

            Console.WriteLine("==== Available Operatives ====");
            for (int i = 0; i < rolodex.Count(); i++)
            {
                Console.WriteLine($"{i}) {rolodex[i].Name}");
                Console.WriteLine($"Specialty: {rolodex[i].Specialty}");
                Console.WriteLine($"Skill Level: {rolodex[i].SkillLevel}");
                Console.WriteLine($"Cut Required: {rolodex[i].PercentageCut}");
                Console.WriteLine();
            }










            
        }
    }
}
