public static class EntityContentExtension
{
    public static GameEntity CreateBullet(this GameContext context, float x, float y)
    {
        var bulletEntity = context.CreateEntity();
        bulletEntity.isBullet = true;
        bulletEntity.isMovable = true;
        bulletEntity.AddPosition(x, y);
        bulletEntity.AddSpeed(0, 1F);
        bulletEntity.AddTimerTick(300F);
        bulletEntity.AddTimerPassedTime(0F);
        bulletEntity.AddAsset("Bullet");

        return bulletEntity;
    }

    public static GameEntity CreatePlayer(this GameContext context, float x, float y)
    {
        var playerEntity = context.CreateEntity();
        playerEntity.AddPosition(x, y);
        playerEntity.isPlayer = true;
        playerEntity.AddTimerTick(2F);
        playerEntity.AddTimerPassedTime(0F);
        playerEntity.AddAsset("Player");

        return playerEntity;
    }
}