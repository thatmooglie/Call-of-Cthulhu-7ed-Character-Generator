using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Occupations
{
    public class Driver : Occupation
    {
        private readonly List<SkillName> skillList = new List<SkillName>
        {
            SkillName.Accounting,
            SkillName.DriveAuto,
            SkillName.Listen,
            SkillName.FastTalk,
            SkillName.MechRepair,
            SkillName.Navigate,
            SkillName.Psychology,
            SkillName.FirearmsHandgun
        };

        public Driver(Characteristics characteristics)
        {
            this.OccupationName = OccupationName.Driver;
            this.OccupationSkills = skillList;
            this.CreditRatingLimit = new int[] { 9, 20 };
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
