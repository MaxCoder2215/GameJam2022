namespace GameJam2022Server
{
    public class Stats
    {

        // Main Stats each Enity will possess.
        public float Health { get; set; }
        public float AttackDamage { get; set; }
        public float AttackSpeed { get; set; }
        public float Defense { get; set; }
        public float CriticalRate { get; set; }
        public float Gold { get; set; }
        public float Morale { get; set; }

        // Constructor
        public Stats(float hP, float aD, float aS, float dF, float cR, float gD, float mR)
        {
            Health = hP;
            AttackDamage = aD;
            AttackSpeed = aS;
            Defense = dF;
            CriticalRate = cR;
            Gold = gD;
            Morale = mR;
        }

        public static Stats operator +(Stats a, Stats b)
        {
            Stats s = new Stats(a.Health, a.AttackDamage, a.AttackSpeed, a.Defense, a.CriticalRate, a.Gold, a.Morale);
            s.Modify(b);
            return s;
        }

        public static Stats operator -(Stats a, Stats b)
        {
            Stats s = new Stats(a.Health, a.AttackDamage, a.AttackSpeed, a.Defense, a.CriticalRate, a.Gold, a.Morale);
            s.Health -= b.Health;
            s.AttackDamage -= b.AttackDamage;
            s.Defense -= b.Defense;
            s.CriticalRate -= b.CriticalRate;
            s.Gold -= b.Gold;
            s.Morale -= b.Morale;

            return s;
        }

        // Modifies base stats permanently. 
        public void Modify(Stats statModifiers)
        {
            Health = statModifiers.Health + Health;
            AttackDamage = statModifiers.AttackDamage + AttackDamage;
            AttackSpeed = statModifiers.AttackSpeed + AttackSpeed;
            Defense = statModifiers.Defense + Defense;
            CriticalRate = statModifiers.CriticalRate + CriticalRate;
        }
    }
}