using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Occultist : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Anthropology,
            SkillName.History,
            SkillName.LibraryUse,
            SkillName.Persuade,
            SkillName.Occult,
            SkillName.LanguageOther,
            SkillName.Science,
            SkillName.NaturalWorld
        };

        public Occultist(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Occultist;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 65 };
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
