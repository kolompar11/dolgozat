namespace OOP_potlas_gym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // TODO 
            //
            // 1. Hozz létre legalább 2 GymMember-t
            //      - id: 1, életkor 17, tagsági díj: 15000, név: saját neved, hátralévő hónapok száma: 12
            //      - id: 2, életkor 59, tagsági díj: 5000, név: János, hátralévő hónapok száma: 2
            GymMember Fonok = new GymMember(1, "Marcello", 15000, 17);
            GymMember Jani = new GymMember(2, "János", 5000, 59);

            Fonok.RenewMembership(12);
            Jani.RenewMembership(2);
            //
            // 2. Mindegyik tagnál hívd meg a DisplayMemberInfo() metódust.
            //
            Fonok.DisplayMemberInfo();
            Jani.DisplayMemberInfo();
            // 3. Teszteld a RenewMembership() 5 és -5
            //    hónapszámmal, majd ellenőrizd az IsMembershipActive()
            //    eredményét
            //
            Fonok.RenewMembership(5);
            Jani.RenewMembership(-5);
            // 4. Teszteld a CalculateTotalFee() 5 és 0 hónappal
            //
            double feeFonok = Fonok.CalculateTotalFee(5);
            double feeJani = Jani.CalculateTotalFee(0);
            // 5. Teszteld a CanJoinAdvancedTraining() metódust mindkét taggal 
            //
                        //Fonok.CanJoinAdvancedTraining();
                        //Jani.CanJoinAdvancedTraining();  NEM AKAR MŰKÖDNI
            //
            // 6. Hozz létre egy List<GymMember> listát, töltsd fel a
            //    korábban létrehozott tagokkal
            //      + hozz létre egy új Gym-et : név: BlathyGym, tagok: az előbb létrehozott lista
            Gym BlathyGym = new Gym("BlathyGym", new List<GymMember> { Fonok, Jani });

            //
            // 7. Hozz létre egy új GymMebert és ass hozzá a Gym-hez az AddMember() metódussal
            //
            GymMember Petya = new GymMember(3, "Petya", 8000, 25);
            BlathyGym.AddMember(Petya);
            // 8. Hívd meg a DisplayAllMembers() metódust a Gym-re
            //
            BlathyGym.DisplayAllMembers();
            // 9. Teszteld a FindMember() metódust 1 és 87-es azonosítóval
            //
            GymMember foundMember1 = BlathyGym.FindMember(1);
            GymMember foundMember87 = BlathyGym.FindMember(87);
        }
    }
}
