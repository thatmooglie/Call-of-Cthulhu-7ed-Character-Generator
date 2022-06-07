using Engine.Skills;
using Engine.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Actor : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.ArtCraft,
            SkillName.Disguise,
            SkillName.FightingBrawl,
            SkillName.History,
            SkillName.Charm,
            SkillName.FastTalk,
            SkillName.Psychology,
            SkillName.Listen
        };

        public Actor(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Actor;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 40 };
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
