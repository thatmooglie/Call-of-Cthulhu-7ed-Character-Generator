using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Librarian : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Accounting,
            SkillName.LibraryUse,
            SkillName.LanguageOther,
            SkillName.LanguageOwn,
            SkillName.SpotHidden,
            SkillName.Occult,
            SkillName.NaturalWorld,
            SkillName.History
        };

        public Librarian(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Librarian;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 35 };
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
