public class CharacterFactory
{
    private readonly Dictionary<char, ICharacter> _characters = new();

    public ICharacter GetCharacter(char character)
    {
        if(_characters.ContainsKey(character)) return _characters[character];
        return _characters[character] = character switch
        {
            'A' => new CharacterA(),
            'B' => new CharacterB(),
            _ => throw new ArgumentException($"Unknown character: {character}"),
        };
    }
}