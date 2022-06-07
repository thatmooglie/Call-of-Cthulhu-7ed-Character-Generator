using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Bartender : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Accounting,
            SkillName.Charm,
            SkillName.FastTalk,
            SkillName.FightingBrawl,
            SkillName.Listen,
            SkillName.Psychology,
            SkillName.SpotHidden,
            SkillName.SleighOfHand
        };

        public Bartender(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Bartender;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 8, 25 };
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
