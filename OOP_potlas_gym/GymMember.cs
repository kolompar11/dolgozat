using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_potlas_gym
{
    internal class GymMember
    {
        public int ID { get; }
        public string Name { get; set; }
        public double MonthlyFee { get; private set; }
        public int RemainingMonths { get; set; } = 0;
        public int Age { get; set; }

        /* PROPERTY-k
         *  - A tag egyedi azonosítója. A konstruktor állítja be, később nem módosítható
         *  - A tag neve. Nem lehet üres vagy csak szóközökből álló szöveg.
         *  - A tag havi tagsági díja. Kívülről nem módosítható
         *  - A tagságból hátralévő hónapok száma. Kezdeti értéke 0
         *  - A tag életkora. Csak 16 és 100 közötti értéket fogadjon el.
         */

        // KONSTRUKTOR - minden property-nek adjon értéket
        public GymMember(int id, string name, double monthlyFee, int age)
        {
            ID = id;
            Name = name;
            MonthlyFee = monthlyFee;
            RemainingMonths = 0;
            Age = age;
        }

        public void DisplayMemberInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Név: {Name}");
            Console.WriteLine($"Havi tagsági díj: {MonthlyFee}");
            Console.WriteLine($"Hátralévő hónapok: {RemainingMonths}");
            Console.WriteLine($"Életkor: {Age}");
        }

        public void RenewMembership(int months)
        {
            if (months > 0)
            {
                RemainingMonths += months;
            }
        }

        public bool IsMembershipActive()
        {
            return RemainingMonths > 0;
        }

        public double CalculateTotalFee(int months)
        {
            if (months <= 0)
            {
                return 0;
            }

            return MonthlyFee * months;
        }
        public bool CanJoinAdvancedTraining(bool medicalClearance)
        {
            return Age >= 18 && medicalClearance;
        }
    }
}