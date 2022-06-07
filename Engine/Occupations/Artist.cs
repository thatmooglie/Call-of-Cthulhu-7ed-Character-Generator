using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Artist : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.ArtCraft,
            SkillName.NaturalWorld,
            SkillName.Charm,
            SkillName.LanguageOther,
            SkillName.Psychology,
            SkillName.SpotHidden,
            SkillName.Listen,
            SkillName.Appraise
        };

        public Artist(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Artist;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 50 };
            this.Skills = new BaseSkills();

            Skills.BaseSkillValues[SkillName.Dodge] = characteristics.Dex / 2;
            Skills.BaseSkillValues[SkillName.LanguageOwn] = characteristics.Edu;
        }

        public override int GetSkillPoints(Characteristics characteristics)
        {
            return characteristics.Edu * 2 + (characteristics.Dex > characteristics.Pow ? characteristics.Dex*2 : characteristics.Pow * 2);
        }
    }
}
