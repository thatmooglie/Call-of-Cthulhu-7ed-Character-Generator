using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Occupations;
using Engine.Skills;

namespace Engine.Character
{
    public class Character
    {
        private Random rng;

        public string name;
        public Sex sex;
        public int age;

        public Occupation occupation;
        public Characteristics characteristics;
        public DerivedStats derivedStats;
        public List<Skill> skills;
        public List<object> personalSkills;

        public Character()
        {
            rng = new Random((int)DateTime.Now.Ticks % int.MaxValue);

            this.sex = GetRandomSex();
            this.name = GetRandomName(this.sex);
            this.age = rng.Next(15, 89);

            this.characteristics = GetRandomCharacteristics();
            this.derivedStats = GetDerivedStats();
            this.occupation = GetRandomOccupation();
            this.personalSkills = GetRandomPersonalSkills();

            this.occupation.UpdateSkills(this.characteristics, occupation.GetSkillPoints(this.characteristics), this.personalSkills);
            this.skills = GetSkills();
            
        }

        private List<Skill> GetSkills()
        {
            var skillsList = new List<Skill>();
            var baseSkills = new BaseSkills();
            foreach(var key in baseSkills.BaseSkillValues.Keys)
            {
                skillsList.Add(new Skill(key, baseSkills.BaseSkillValues[key]));
            }
            return skillsList;
        }

        private List<object> GetRandomPersonalSkills()
        {
            var tempPersonalSkills = new List<object>();
            var skillNameType = typeof(SkillName);
            var values = skillNameType.GetEnumValues();
            for (int i = 0; i < 5; i++)
            {
                var index = rng.Next(values.Length);
                while (tempPersonalSkills.Contains(values.GetValue(index)) || index == 7 || index == 8 || occupation.OccupationSkills.Contains((SkillName)values.GetValue(index)))
                    index = rng.Next(values.Length);                    
                tempPersonalSkills.Add(values.GetValue(index));
            }

            return tempPersonalSkills;
        }

        private Occupation GetRandomOccupation()
        {
            var occupationType = typeof(OccupationName);
            var values = occupationType.GetEnumValues();
            var randomOccupation = (OccupationName)values.GetValue(rng.Next(values.Length));

            switch (randomOccupation)
            {
                case OccupationName.Actor:
                    return new Actor(characteristics);
                case OccupationName.Archaeologist:
                    return new Archaeologist(characteristics);
                case OccupationName.Artist:
                    return new Artist(characteristics);
                case OccupationName.Athlete:
                    return new Athlete(characteristics);
                case OccupationName.Author:
                    return new Author(characteristics);
                case OccupationName.Bartender:
                    return new Bartender(characteristics);
                case OccupationName.Burglar:
                    return new Burglar(characteristics);
                case OccupationName.Dillettante:
                    return new Dillettante(characteristics);
                case OccupationName.Driver:
                    return new Driver(characteristics);
                case OccupationName.Lawyer:
                    return new Lawyer(characteristics);
                case OccupationName.Librarian:
                    return new Librarian(characteristics);
                case OccupationName.Lumberjack:
                    return new Lumberjack(characteristics);
                case OccupationName.Occultist:
                    return new Occultist(characteristics);
                case OccupationName.PI:
                    return new PrivateInvestigator(characteristics);
                case OccupationName.Professor:
                    return new Professor(characteristics);
                case OccupationName.Researcher:
                    return new Researcher(characteristics);
                case OccupationName.Sailor:
                    return new Sailor(characteristics);
                case OccupationName.Student:
                    return new Student(characteristics);
                case OccupationName.Zealot:
                    return new Zealot(characteristics);
                default:
                    return new PrivateInvestigator(characteristics);
            }
        }

        private DerivedStats GetDerivedStats()
        {
            return new DerivedStats(characteristics, age);
        }

        private Characteristics GetRandomCharacteristics()
        {
            var chars = new Characteristics();
            chars.AgeModification(age);
            return chars;
        }

        private string GetRandomName(Sex sex)
        {
            var surnameType = typeof(Surname);
            var surnameValues = surnameType.GetEnumValues();
            var surName = (Surname)surnameValues.GetValue(rng.Next(surnameValues.Length));

            switch (sex)
            {
                case Sex.Male:
                    var maleType = typeof(Male);
                    var maleValues = maleType.GetEnumValues();
                    var maleName = (Male)maleValues.GetValue(rng.Next(maleValues.Length));
                    return maleName.ToString() + " " + surName.ToString();               
                case Sex.Female:
                    var femaleType = typeof(Female);
                    var femaleValues = femaleType.GetEnumValues();
                    var femaleName = (Female)femaleValues.GetValue(rng.Next(femaleValues.Length));
                    return femaleName.ToString() + " " + surName.ToString();
            }

            return surName.ToString();
        }

        private Sex GetRandomSex()
        {
            var type = typeof(Sex);
            var values = type.GetEnumValues();
            return (Sex)values.GetValue(rng.Next(values.Length)); 
        }
    }

    public enum Sex
    {
        Male,
        Female
    }
}
