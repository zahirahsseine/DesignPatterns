public class EnemyFactory {
    private Random _random = new Random();

    public IEnemy CreateEnemy() {
        int type = _random.Next(1, 4); // Random type: 1 to 3

        switch (type) {
            case 1:
                return new Goblin(health: 30, damage: 5);
            case 2:
                return new Troll(health: 80, damage: 15, armor: 5);
            case 3:
                return new Dragon(firePower: 100, flySpeed: 20, health: 200);
            default:
                throw new ArgumentException("Unknown enemy type");
        }
    }
}