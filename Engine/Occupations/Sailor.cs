using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Sailor : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.MechRepair,
            SkillName.FightingBrawl,
            SkillName.FirearmsHandgun,
            SkillName.FirstAid,
            SkillName.Navigate,
            SkillName.Pilot,
            SkillName.Survival,
            SkillName.Swim
        };

        public Sailor(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Sailor;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 30 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 2 + (characteristics.Dex > characteristics.Str ? characteristics.Dex * 2 : characteristics.Str * 2);
        }
    }
}
