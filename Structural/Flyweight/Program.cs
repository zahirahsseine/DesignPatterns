var characterFactory = new CharacterFactory();
characterFactory.GetCharacter('A').Display(1, 1);
characterFactory.GetCharacter('B').Display(1, 2);

Console.WriteLine("After the first creation, we will reuse the same character.");
characterFactory.GetCharacter('A').Display(1, 1);
characterFactory.GetCharacter('B').Display(1, 2);