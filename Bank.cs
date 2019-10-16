using System;

namespace Heist_2
{
    public class Bank
    {
        public int CashOnHand { get; set; }
        public int AlarmScore { get; set; }
        public int VaultScore { get; set; }
        public int SecurityGuardScore { get; set; }
        public bool IsSecure 
        {
            get
            {
                if (AlarmScore > 0 || VaultScore > 0 || SecurityGuardScore > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public Bank()
        {
            Random random = new Random();

            CashOnHand = random.Next(50_000, 1_000_001);
            AlarmScore = random.Next(1, 101);
            VaultScore = random.Next(1, 101);
            SecurityGuardScore = random.Next(1, 101);
        }
    }
}