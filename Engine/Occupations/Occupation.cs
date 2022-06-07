using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Character;
using Engine.Skills;

namespace Engine.Occupations
{
    public abstract class Occupation
    {
        public OccupationName OccupationName { get; set; }
        public List<SkillName> OccupationSkills { get; set; }
        public int SkillPoints { get; set; }
        public BaseSkills Skills { get; set; }
        public int[] CreditRatingLimit { get; set; }

        public abstract int GetSkillPoints(Characteristics characteristics);

        public void UpdateSkills(Characteristics characteristics, int personalPoints, List<object> personalSkillNames)
        {
            var rng = new Random((int)DateTime.Now.Ticks % int.MaxValue);
            var creditRating = rng.Next(CreditRatingLimit[0], CreditRatingLimit[1]);
            this.Skills.BaseSkillValues[SkillName.CreditRating] = creditRating;
            var skillPoints = (this.GetSkillPoints(characteristics) - creditRating) / 8;

            foreach(SkillName skillName in this.OccupationSkills)
            {
                this.Skills.BaseSkillValues[skillName] += skillPoints;
            }

            var personalSkillPoints = personalPoints / personalSkillNames.Count;
            foreach (SkillName skillName in personalSkillNames)
            {
                this.Skills.BaseSkillValues[skillName] += personalSkillPoints;
            }
        }

        public List<Skill> GetOccupationSkills()
        {
            var skillList = new List<Skill>();
            foreach(SkillName skill in OccupationSkills)
            {
                skillList.Add(new Skill(skill, this.Skills.BaseSkillValues[skill]));
            }
            return skillList;
        }
    }

    public enum OccupationName
    {
        Actor,
        Archaeologist,
        Artist,
        Athlete,
        Author,
        Bartender,
        Burglar,
        Dillettante,
        Driver,
        Journalist,
        Lumberjack,
        Lawyer,
        Librarian,
        Occultist,
        PI,
        Professor,
        Researcher,
        Sailor,
        Student,
        Zealot
    }
}
