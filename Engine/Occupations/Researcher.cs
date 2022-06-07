using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Researcher : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.History,
            SkillName.LibraryUse,
            SkillName.FastTalk,
            SkillName.LanguageOther,
            SkillName.SpotHidden,
            SkillName.Science,
            SkillName.Psychology,
            SkillName.NaturalWorld
        };

        public Researcher(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Researcher;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 30 };
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
