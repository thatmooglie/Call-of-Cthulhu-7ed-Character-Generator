using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Student : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.LanguageOther,
            SkillName.LibraryUse,
            SkillName.Listen,
            SkillName.History,
            SkillName.NaturalWorld,
            SkillName.Occult,
            SkillName.FastTalk,
            SkillName.Stealth
        };

        public Student(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Student;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 5, 10 };
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
