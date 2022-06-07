using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Skills
{
    public class Skill
    {
        public string Name { get; set; }
        public int SkillRating { get; set; }
        public int HalfRating { get; set; }
        public int FifthRating { get; set; }

        public Skill(SkillName name, int skillRating)
        {
            Name = SkillTools.GetSkillString(name);
            SkillRating = skillRating;
            HalfRating = SkillRating / 2;
            FifthRating = SkillRating / 5;
        }

        public void UpdateSkillRating(int skillPointsToAdd)
        {
            SkillRating += skillPointsToAdd;
            HalfRating = SkillRating / 2;
            FifthRating = SkillRating / 5;
        }
    }   
}
