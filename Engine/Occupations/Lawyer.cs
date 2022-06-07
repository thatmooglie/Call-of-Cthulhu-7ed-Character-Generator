using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Lawyer : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Accounting,
            SkillName.Law,
            SkillName.LibraryUse,
            SkillName.Persuade,
            SkillName.Intimidate,
            SkillName.Psychology,
            SkillName.Listen,
            SkillName.FastTalk
        };

        public Lawyer(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Lawyer;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 30, 80 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 4;
        }
    }
}
