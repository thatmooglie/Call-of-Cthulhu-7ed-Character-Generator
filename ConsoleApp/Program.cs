using Engine.Character;
using Engine;
using Engine.Skills;
using Engine.Occupations;

while (true) { 
    var character = new Character();

    Console.WriteLine($"Name: {character.name}");
    Console.WriteLine($"Age: {character.age}");
    Console.WriteLine($"Sex: {character.sex}");
    Console.WriteLine($"Occupation: {character.occupation.OccupationName}");

    Console.WriteLine("----- Characteristics -----");
    Console.WriteLine($"DEX: {character.characteristics.Dex}");
    Console.WriteLine($"CON: {character.characteristics.Con}");
    Console.WriteLine($"STR: {character.characteristics.Str}");
    Console.WriteLine($"APP: {character.characteristics.App}");
    Console.WriteLine($"INT: {character.characteristics.Siz}");
    Console.WriteLine($"EDU: {character.characteristics.Edu}");
    Console.WriteLine($"POW: {character.characteristics.Pow}");
    Console.WriteLine($"Siz: {character.characteristics.Siz}");

    Console.WriteLine($"Luck: {character.characteristics.Luck}");


    Console.WriteLine($"----- Derived Stats -----");
    Console.WriteLine($"HP: {character.derivedStats.HP}");
    Console.WriteLine($"Movement Rating: {character.derivedStats.MovementRating}");
    Console.WriteLine($"Damage Bonus: {character.derivedStats.DamageBonus}");
    Console.WriteLine($"Build: {character.derivedStats.Build}");

    Console.WriteLine($"----- Skills -----");
    Console.WriteLine($"----- Occupation Skills -----");
    foreach (var skill in character.skills)
    {
        Console.WriteLine($"{skill.Name}: {skill.SkillRating}");
    }
    Console.ReadLine();

}