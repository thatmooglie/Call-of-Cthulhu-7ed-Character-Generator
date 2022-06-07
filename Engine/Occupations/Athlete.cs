using Engine.Character;
using Engine.Skills;
using System.Collections.Generic;

namespace Engine.Occupations
{
    public class Athlete : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Climb,
            SkillName.Jump,
            SkillName.FightingBrawl,
            SkillName.Ride,
            SkillName.Intimidate,
            SkillName.Swim,
            SkillName.Throw,
            SkillName.Dodge
        };

        public Athlete(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Athlete;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 70 };
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
