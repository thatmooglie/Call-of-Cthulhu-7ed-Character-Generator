using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Dillettante : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.ArtCraft,
            SkillName.FirearmsRifleShotgun,
            SkillName.LanguageOther,
            SkillName.Ride,
            SkillName.Charm,
            SkillName.Persuade,
            SkillName.History,
            SkillName.Appraise
        };

        public Dillettante(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Dillettante;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 50, 99 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 2 + characteristics.App * 2;
        }
    }
}
