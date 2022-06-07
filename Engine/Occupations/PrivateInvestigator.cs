using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class PrivateInvestigator : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.ArtCraft,
            SkillName.Disguise,
            SkillName.Law,
            SkillName.LibraryUse,
            SkillName.Persuade,
            SkillName.Psychology,
            SkillName.SpotHidden,
            SkillName.FirearmsHandgun
        };

        public PrivateInvestigator(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.PI;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 30 };
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
