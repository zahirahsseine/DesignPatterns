var factory = new EnemyFactory();
for (int i = 0; i < 100; i++) {
    var enemy = factory.CreateEnemy();
    enemy.Attack();
}
