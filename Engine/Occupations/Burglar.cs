using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Burglar : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Appraise,
            SkillName.Climb,
            SkillName.ElecRepair,
            SkillName.Listen,
            SkillName.Locksmith,
            SkillName.SleighOfHand,
            SkillName.Stealth,
            SkillName.SpotHidden
        };

        public Burglar(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Burglar;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 5, 40 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 2 + characteristics.Dex * 2;
        }
    }
}
