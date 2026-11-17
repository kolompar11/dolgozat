using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_potlas_gym
{
    internal class Gym
    {
        //PROPERTY-k
        /*
         * - Az edzőterem neve
         * - Az edzőterem tagjait tároló lista
         */

        public string Name { get; set; }
        public List<GymMember> Members { get; set; }

        //KONSTRUKTOR - megkapja a nevet és a kezdeti tagok listáját
        public Gym(string name, List<GymMember> members)
        {
            Name = name;
            Members = members ?? new List<GymMember>();
        }

        //METÓDUSOK

        public void AddMember(GymMember member)
        {
            if (member != null)
            {
                Members.Add(member);
            }
        }

        public void DisplayAllMembers()
        {
            foreach (GymMember member in Members)
            {
                member.DisplayMemberInfo();
                Console.WriteLine();
            }
        }

        public GymMember FindMember(int memberId)
        {
            return Members.FirstOrDefault(member => member != null && member.ID == memberId);
        }

        public double GetTotalMonthlyFees()
        {
            return Members
                .Where(member => member != null)
                .Sum(static member => member.MonthlyFee);
        }

        public bool HasMemberOverAge(int age)
        {
            return Members.Any(member => member != null && member.Age > age);
        }
    }
}