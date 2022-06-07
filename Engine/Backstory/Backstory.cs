using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Backstory
{
    public class Backstory
    {
        public string Ideology;
        public string SignificantPeople;
        public string MeaningfulLocation;
        public string TreasuredPossession;
        public string Traits;

        public Backstory()
        {
            GenerateBackstory();
        }

        public void GenerateBackstory()
        {
            Ideology = GetIdeology();
            SignificantPeople = GetSignificantPeople();
            MeaningfulLocation = GetMeaningfulLocation();
            TreasuredPossession = GetTreasuredPossession();
            Traits = GetTraits();
        }

        private string GetIdeology()
        {
            return GetRandomItemFromDictionary(ideologyDictionary);
        }

        private string GetSignificantPeople()
        {
            return GetRandomItemFromDictionary(significantWhoDictionary) + " " + GetRandomItemFromDictionary(significantWhyDictionary);
        }

        private string GetMeaningfulLocation()
        {
            return GetRandomItemFromDictionary(meaningfulLocationDictionary);
        }

        private string GetTreasuredPossession()
        {
            return GetRandomItemFromDictionary(treasuredPossessionsDictionary);
        }

        private string GetTraits()
        {
            return GetRandomItemFromDictionary(traitsDictionary);
        }

        private string GetRandomItemFromDictionary(Dictionary<int, string> keyValuePairs)
        {
            var rng = new Random((int)DateTime.Now.Ticks % int.MaxValue);
            var key = rng.Next(1, 11);
            return keyValuePairs[key];
        }

        private Dictionary<int, string> ideologyDictionary = new Dictionary<int, string>
        {
            { 1, "There is a higher power that you worship and pray to (e.g. Vishnu, Jesus Christ, Haile Selassie)."},
            { 2, "Mankind can to fine without religions (e.g staunch, atheist, humanist, secularist)."},
            { 3, "Science has all the answers, Pick a particular aspect of interest (e.g. evolution, cryogenics, space exploration)." },
            { 4, "A belief in fate (e.g. karma, the class system, superstitious)." },
            { 5, "Member of society or secret society (e.g. Freemason, Women's institution, Anonymous)." },
            { 6, "There is evil in society that should be rooted out. What is this evil? (e.g. drugs, violence, racisim)." },
            { 7, "The occult (e.g. astrology, spititualism, tarot)." },
            { 8, "Politics (e.g. conservative, socialist, liberal)." },
            { 9, "Money is power, and I'm going to get all I can (e.g. greedy, enterprising, ruthless)." },
            { 10, "Campaigner/Activist (e.g. feminism, gay rights, union power)." }
        };

        private Dictionary<int, string> significantWhoDictionary = new Dictionary<int, string>
        {
            { 1, "Parent (e.g. mother, father, stepmother)."},
            { 2, "Grandparent (e.g. maternal grandmother, paternal grandfather)."},
            { 3, "Sibling (e.g. brother, half-brother, stepsister)." },
            { 4, "Child (e.g. son or daughter)." },
            { 5, "Partner (e.g. spouse, fiancé, lover)." },
            { 6, "Person who taught you your highest occupational skill. Identify the skill and consider who taught you (e.g. teacher, the person you apprenticed for, father)." },
            { 7, "Childhood friend (e.g. classmate, neighbor, imaginary friend)." },
            { 8, "A famous person. Your idol or hero. You may never have even met (e.g. film star, politician, musician)." },
            { 9, "A fellow investigator in your game. Pick one or chose randomly." },
            { 10, "A non-playing character (NPC) in the game. Ask the Keeper to pick one for you." }
        };

        private Dictionary<int, string> significantWhyDictionary = new Dictionary<int, string>
        {
            { 1, "Your indebted to them. How did they help you? (e.g. financially, they protected you through hard times, got you the first job)."},
            { 2, "They taught you something. What? (e.g. a skill, to love, to be a man)."},
            { 3, "They give your life meaning. How? (e.g. you aspire to be like them, you seek to be with them, you seek to make them happy)." },
            { 4, "You wronged them and seek reconcilation. What did you do? (e.g. stole money from them, informed the police about them, refused to help when they were desperate)." },
            { 5, "Shared experience. What? (e.g. you lived through hard times together, you grew up together, you served in the war together)." },
            { 6, "You seek to prove yourself to them. How? (e.g. by getting a good job, by finding a good spouse, by getting an education)." },
            { 7, "You idolize them (e.g. for their fame, their beauty, their work)." },
            { 8, "A feeling of regret (e.g. you should have died in their place, you fell out over something you said, you didn't step up and help them when you had the chance)." },
            { 9, "You wish to prove yourself better than them. What was their flaw? (e.g. lazy, drunk, unloving)." },
            { 10, "They have crossed you and you seek revenge. For what do you blame them? (e.g. death of a loved one, your financial ruin, martial breakup)." }
        };

        private Dictionary<int, string> meaningfulLocationDictionary = new Dictionary<int, string>
        {
            { 1, "Your seat of learning (e.g. school, university, apprenticeship)."},
            { 2, "Your hometown (e.g. rural village, market town, busy city)."},
            { 3, "The place you met your first love (e.g. a music concert, on holiday, a bomb shelter)." },
            { 4, "A place for quite contemplation (e.g. the library, country walks on your estate, fishing)." },
            { 5, "A place for socializing (e.g. gentlemen's club, local bar, uncle's house)." },
            { 6, "A place connected to your ideology/belief (e.g. parish church, Mecca, Stonehedge)." },
            { 7, "The grave of a significant person. Who? (e.g. a parent, a child, a lover)." },
            { 8, "Your family home (e.g. country estate, a rented flat, the orphanage in which you were raised)." },
            { 9, "The place you were the happiest in your life (e.g. the park bench you where you first kissed, your university, your grandmother's home)." },
            { 10, "Your workplace (e.g. the office, library, bank)." }
        };

        private Dictionary<int, string> treasuredPossessionsDictionary = new Dictionary<int, string>
        {
            { 1, "An item connected with your highest skill (e.g. expensive suit, false ID, brass knuckles)."},
            { 2, "An essential item for your occupation (e.g. doctor's bag, car, lock picks)."},
            { 3, "A memento from your childhood (e.g. comics, pocket knife, lucky coin)." },
            { 4, "A memento of a departed person (e.g. jewelry, a photograph in your wallet, a letter)." },
            { 5, "Something given to you by your Significant Person (e.g. a ring, a diary, a map)." },
            { 6, "Your collection. What is it? (e.g. bus tickets, stuffed animals, records)." },
            { 7, "Something you found but you don't know what it is - you seek answers (e.g. a letter you found in a cupboard written in an unknown language, a curious pipe of unknown origin found among your late father's effects, a strange silver ball you dug up in your garden)." },
            { 8, "A sporting item (e.g. cricket bat, a signed baseball, a fishing rod)." },
            { 9, "A weapon (e.g. service revolver, your old hunting rifle, the hidden knife in your boot)." },
            { 10, "A pet (e.g. a dog, a cat, a tortoise)." }
        };

        private Dictionary<int, string> traitsDictionary = new Dictionary<int, string>
        {
            { 1, "Generous (e.g. generous tipper, always helps out a person in need, philanthropist)."},
            { 2, "Good with animals (e.g. loves cats, grew up on a farm, good with horses)."},
            { 3, "Dreamer (e.g. given to flights of fancy, visionary, highly creative)." },
            { 4, "Hedonist (e.g. life and soul of the party, entertaining drunk, live fast and die young)." },
            { 5, "Gambler and risk-taker (e.g. poker-faced, try anything once, lives on the edge)." },
            { 6, "Good Cook (e.g. bakes wonderful cakes, can make a great meal from almost nothing, refinded palate)." },
            { 7, "Ladies' man/seductess (e.g. suave, charming voice, enchanting eyes)." },
            { 8, "Loyal (e.g. stands by his or her friends, never breaks a promise, would die for his or her beliefs)." },
            { 9, "A good reputation (e.g. the best after-dinner speaker in the country, the most pious of men, fearless in the face of danger)." },
            { 10, "Ambitious (e.g. to achieve a goal, to become the boss, to have it all)." }
        };
    }
}
