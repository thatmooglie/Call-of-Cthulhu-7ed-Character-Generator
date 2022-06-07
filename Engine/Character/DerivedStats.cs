using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Character
{
    public class DerivedStats
    {
        public string DamageBonus { get; set; }
        public int Build { get; set; }
        public int HP { get; set; }
        public int MovementRating { get; set; }
        public int Sanity { get; set; }
        public int MagicPoints { get; set; }

        public DerivedStats(Characteristics characteristics, int age)
        {
            SetDamageBonusAndBuild(characteristics.Str, characteristics.Siz);
            this.HP = (characteristics.Con + characteristics.Siz) / 10;
            MovementRating = GetMovementRating(characteristics.Dex, characteristics.Str, characteristics.Siz, age);
            Sanity = characteristics.Pow;
            MagicPoints = characteristics.Pow / 5;
        }

        private int GetAgeModifier(int age)
        {
            if (age >= 40 && age < 50)
                return 1;
            else if (age >= 50 && age < 60)
                return 2;
            else if (age >= 60 && age < 70)
                return 3;
            else if (age >= 70 && age < 80)
                return 4;
            else if (age >= 80 && age < 90)
                return 5;

            return 0;
        }

        private int GetMovementRating(int dex, int str, int siz, int age)
        {
            var ageModifier = GetAgeModifier(age);
            if (dex < siz && str < siz)
                return 7 - ageModifier;
            else if (dex >= siz && str >= siz)
                return 9 - ageModifier;
            else
                return 8 - ageModifier;                         
        }

        private void SetDamageBonusAndBuild(int str, int siz)
        {
            var sum = str + siz;

            if (sum <= 64)
            {
                this.DamageBonus = "-2";
                this.Build = -2;
            }

            if (sum >= 65 && sum <= 84)
            {
                this.DamageBonus = "-1";
                this.Build = -1;
            }

            if (sum >= 85 && sum <= 124)
            {
                this.DamageBonus = "None";
                this.Build = 0;
            }

            if (sum >= 125 && sum <= 164)
            {
                this.DamageBonus = "+1D4";
                this.Build = 1;
            }

            if(sum >= 165)
            {
                this.DamageBonus = "+1D6";
                this.Build = 2;
            }
        }
    }
}
