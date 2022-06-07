using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Archaeologist : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Appraise,
            SkillName.Archaeology,
            SkillName.History,
            SkillName.LanguageOther,
            SkillName.LibraryUse,
            SkillName.SpotHidden,
            SkillName.MechRepair,
            SkillName.Science
        };

        public Archaeologist(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Archaeologist;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 10, 40 };
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
