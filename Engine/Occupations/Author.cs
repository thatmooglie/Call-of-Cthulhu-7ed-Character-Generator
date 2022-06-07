using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;

namespace Engine.Occupations
{
    public class Author : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.ArtCraft,
            SkillName.History,
            SkillName.LibraryUse,
            SkillName.Occult,
            SkillName.LanguageOther,
            SkillName.LanguageOwn,
            SkillName.Psychology,
            SkillName.NaturalWorld
        };

        public Author(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Author;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 30 };
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
