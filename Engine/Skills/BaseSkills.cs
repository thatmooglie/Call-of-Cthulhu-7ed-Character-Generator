using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine.Skills
{
    public enum SkillName
    {
        Accounting,
        Anthropology,
        Appraise,
        Archaeology,
        ArtCraft,
        Charm,
        Climb,
        CreditRating,
        CthulhuMythos,
        Disguise,
        Dodge,
        DriveAuto,
        ElecRepair,
        FastTalk,
        FightingBrawl,
        FirearmsHandgun,
        FirearmsRifleShotgun,
        FirstAid,
        History,
        Intimidate,
        Jump,
        LanguageOther,
        LanguageOwn,
        Law,
        LibraryUse,
        Listen,
        Locksmith,
        MechRepair,
        Medicine,
        NaturalWorld,
        Navigate,
        Occult,
        OpHvMachine,
        Persuade,
        Pilot,
        Psychology,
        Psychoanalysis,
        Ride,
        Science,
        SleighOfHand,
        SpotHidden,
        Stealth,
        Survival,
        Swim,
        Throw,
        Track
    }


    public class BaseSkills
    {
        public Dictionary<SkillName, int> BaseSkillValues = new Dictionary<SkillName, int>();

        private readonly List<int> skillValues = new List<int>
        {
            5, 1, 5, 1, 5, 15, 20, 0, 0, 5, 0, 20, 10, 5, 25, 20, 25,
            30, 5, 15, 20, 1, 0, 5, 20, 20, 1, 10, 1, 10, 10, 5, 1,
            10, 1, 10, 1, 5, 1, 10, 25, 20, 10, 20, 20, 10
        };

        public BaseSkills()
        {
            foreach (SkillName skill in Enum.GetValues(typeof(SkillName)))
            {
                BaseSkillValues.Add(skill, skillValues[(int)skill]);
            }
        }
    }

    public static class SkillTools
    {
        public static string GetSkillString(SkillName skillName)
        {
            switch (skillName)
            {
                case SkillName.Accounting: return "Accounting";
                case SkillName.Anthropology: return "Anthropology";
                case SkillName.Appraise: return "Appraise";
                case SkillName.Archaeology: return "Archaeology";
                case SkillName.ArtCraft: return "Art/Craft";
                case SkillName.Charm: return "Charm";
                case SkillName.Climb: return "Climb";
                case SkillName.CreditRating: return "Credit Rating";
                case SkillName.CthulhuMythos: return "Cthulhu Mythos";
                case SkillName.Disguise: return "Disguise";
                case SkillName.Dodge: return "Dodge";
                case SkillName.DriveAuto: return "Drive Auto";
                case SkillName.ElecRepair: return "Elec Repair";
                case SkillName.FastTalk: return "Fast Talk";
                case SkillName.FightingBrawl: return "Fighting (Brawl)";
                case SkillName.FirearmsHandgun: return "Firearms (Handgun)";
                case SkillName.FirearmsRifleShotgun: return "Firearms (Rifle/Shotgun)";
                case SkillName.FirstAid: return "First Aid";
                case SkillName.History: return "History";
                case SkillName.Intimidate: return "Intimidate";
                case SkillName.Jump: return "Jump";
                case SkillName.LanguageOther: return "Language (Other)";
                case SkillName.LanguageOwn: return "Language (Own)";
                case SkillName.Law: return "Law";
                case SkillName.LibraryUse: return "Library Use";
                case SkillName.Listen: return "Listen";
                case SkillName.Locksmith: return "Locksmith";
                case SkillName.MechRepair: return "Mech. Repair";
                case SkillName.Medicine: return "Medicine";
                case SkillName.NaturalWorld: return "Natural World";
                case SkillName.Navigate: return "Navigate";
                case SkillName.Occult: return "Occult";
                case SkillName.OpHvMachine: return "Op. Hv. Machine";
                case SkillName.Persuade: return "Persuade";
                case SkillName.Pilot: return "Pilot";
                case SkillName.Psychology: return "Psychology";
                case SkillName.Psychoanalysis: return "Psychoanalysis";
                case SkillName.Ride: return "Ride";
                case SkillName.Science: return "Science";
                case SkillName.SleighOfHand: return "Sleight of Hand";
                case SkillName.SpotHidden: return "Spot Hidden";
                case SkillName.Stealth: return "Stealth";
                case SkillName.Survival: return "Survival";
                case SkillName.Swim: return "Swim";
                case SkillName.Throw: return "Throw";
                case SkillName.Track: return "Track";
                default: return "";
            }
        }
    }
}
