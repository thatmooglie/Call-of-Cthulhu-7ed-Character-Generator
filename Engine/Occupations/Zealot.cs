using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Zealot : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.History,
            SkillName.Charm,
            SkillName.Persuade,
            SkillName.Psychology,
            SkillName.Stealth,
            SkillName.LibraryUse,
            SkillName.Listen,
            SkillName.SpotHidden
        };

        public Zealot(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Zealot;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 0, 30 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 2 + (characteristics.App > characteristics.Pow ? characteristics.App * 2 : characteristics.Pow * 2);
        }
    }
}
