using Engine.Character;
using Engine.Skills;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoogsCharGen.ViewModel
{
    public class InfoViewModel : INotifyPropertyChanged
    {
        public ICommand GenerateCharacterCommand { get; set; }

        private Character character;
        private UICharacterInfo characterInfo;
        private UIStats stats;
        private UICharacteristics characteristics;
        private ObservableCollection<Skill> fullSkills;

        private ObservableCollection<(string, int)> skills;

        public event PropertyChangedEventHandler PropertyChanged;
        private Grid skillGrid;

        public Character Character
        {
            set
            {
                character = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Character"));
            }
            get => character;
        }

        public UICharacterInfo CharacterInfo
        {
            set
            {
                characterInfo = value;
                PropertyChanged(this, new PropertyChangedEventArgs("CharacterInfo"));
            }
            get => characterInfo;
        }

        public UIStats Stats
        {
            set
            {
                stats = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Stats"));
            }
            get => stats;
        }

        public UICharacteristics Characteristics
        {
            set
            {
                characteristics = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Characteristics"));
            }
            get => characteristics;
        }

        public ObservableCollection<(string, int)> Skills
        {
            set
            {
                skills = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Skills"));
            }
            get => skills;
        }

        public ObservableCollection<Skill> FullSkills
        {
            set
            {
                fullSkills = value;
                PropertyChanged(this, new PropertyChangedEventArgs("FullSkills"));
            }
            get => fullSkills;
        }

        public InfoViewModel()
        {

        }

        public InfoViewModel(Grid skillGrid)
        {
            this.skillGrid = skillGrid;
            GenerateCharacterCommand = new Command(() => GenerateCharacter());
          
            this.character = new Character();
            characterInfo = new UICharacterInfo(character);
            stats = new UIStats(character);
            characteristics = new UICharacteristics(character);
            skills = new ObservableCollection<(string, int)>();
            fullSkills = GetAllSkills(character);
            GetCustomSkills(character);        
            
        }

        private ObservableCollection<Skill> GetAllSkills(Character character)
        {
            var allSkills = new ObservableCollection<Skill>();
            foreach(var skill in character.skills)
                allSkills.Add(skill);
            return allSkills;
        }

        private void GetCustomSkills(Character character)
        {
            if(skills.Count != 0)
                skills.Clear();
            if(Skills.Count != 0)
                Skills.Clear();
            Skills.Add((SkillTools.GetSkillString(SkillName.CreditRating), character.occupation.Skills.BaseSkillValues[SkillName.CreditRating]));
            foreach(var skill in character.occupation.OccupationSkills)
            {
                Skills.Add((SkillTools.GetSkillString(skill), character.occupation.Skills.BaseSkillValues[skill]));
            }
    
            foreach(SkillName skill in character.personalSkills)
            {
                if(!Skills.Contains((SkillTools.GetSkillString(skill), character.occupation.Skills.BaseSkillValues[skill])))
                    Skills.Add((SkillTools.GetSkillString(skill), character.occupation.Skills.BaseSkillValues[skill]));
            }
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            skillGrid.Children.Clear();
            var row = 0;
            var col = 0;

            foreach(var skill in Skills)
            {                
                var grid = new Grid()
                {
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                };

                var skillNameLabel = new Label()
                {
                    Text = $"{skill.Item1}",
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 14,
                    TextColor = Color.FromHex("1C2B1B"),
                    FontAttributes = FontAttributes.Bold,
                };

                var skillValueLabel = new Label()
                {
                    Text = $"{skill.Item2} / {skill.Item2 / 2} / {skill.Item2 / 5}",
                    HorizontalTextAlignment = TextAlignment.Center,
                    FontSize = 14,
                    TextColor = Color.FromHex("1C2B1B")
                };

                grid.Children.Add(skillNameLabel, 0, 0);
                grid.Children.Add(skillValueLabel, 0, 1);               
                skillGrid.Children.Add(grid, col, row);
                if (col == 1)
                {
                    row++;
                    col = 0;
                }
                else
                    col++;               
            }
        }

        private void GenerateCharacter()
        {
            Character = new Character();
            CharacterInfo = new UICharacterInfo(Character);
            Stats = new UIStats(Character);
            Characteristics = new UICharacteristics(Character);
            FullSkills = GetAllSkills(Character);
            GetCustomSkills(Character);
        }
    }

    public class UICharacterInfo
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Occupation { get; set; }

        public UICharacterInfo(Character character)
        {
            Name = character.name;
            Age = character.age;
            Sex = character.sex.ToString();
            Occupation = character.occupation.OccupationName.ToString();
        }
    }

    public class UIStats
    {
        public int MagicPoints { get; set; }
        public int MovementRating { get; set; }
        public string DamageBonus { get; set; }
        public int Build { get; set; }

        public int Sanity { get; set; }
        public int HP { get; set; }
        public int Luck { get; set; }

        public UIStats(Character character)
        {
            MagicPoints = character.derivedStats.MagicPoints;
            MovementRating = character.derivedStats.MovementRating;
            DamageBonus = character.derivedStats.DamageBonus;
            Build = character.derivedStats.Build;
            Sanity = character.derivedStats.Sanity;
            HP = character.derivedStats.HP;
            Luck = character.characteristics.Luck;
        }
    }

    public class UICharacteristics
    {
        public int Str { get; set; }
        public int Con { get; set; }
        public int Siz { get; set; }
        public int Dex { get; set; }
        public int App { get; set; }
        public int Int { get; set; }
        public int Pow { get; set; }
        public int Edu { get; set; }

        public UICharacteristics(Character character)
        {
            Str = character.characteristics.Str;
            Con = character.characteristics.Con;
            Siz = character.characteristics.Siz;
            Dex = character.characteristics.Dex;
            App = character.characteristics.App;
            Int = character.characteristics.Int;
            Pow = character.characteristics.Pow;
            Edu = character.characteristics.Edu;
        }
    }
}
