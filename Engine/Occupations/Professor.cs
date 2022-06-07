using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Professor : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.LibraryUse,
            SkillName.LanguageOther,
            SkillName.LanguageOwn,
            SkillName.Psychology,
            SkillName.History,
            SkillName.Occult,
            SkillName.NaturalWorld,
            SkillName.Science
        };

        public Professor(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Professor;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 20, 70 };
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
