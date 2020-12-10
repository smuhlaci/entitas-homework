using System;

public static class EntityContentExtension
{
    public static GameEntity CreatePlayer(this GameContext context)
    {
        var playerEntity = context.CreateEntity();
        playerEntity.isPlayer = true;
        playerEntity.AddPosition(0F, -2.5F);
        playerEntity.AddRotation(0, 1F);
        playerEntity.AddAsset("Player");
        playerEntity.AddId(context.GetGroup(GameMatcher.Player).count + 1);

        return playerEntity;
    }

    public static GameEntity CreateWeapon(this GameContext context, GameEntity playerEntity, float rotationInDegrees)
    {
        var weaponEntity = context.CreateEntity();
        weaponEntity.isWeapon = true;
        weaponEntity.AddPlayerDependency(playerEntity.id.value);
        weaponEntity.AddPosition(playerEntity.position.x, playerEntity.position.y);
        weaponEntity.AddTimerTick(2F);
        weaponEntity.AddTimerPassedTime(0F);

        var weaponRotation = CalculateAddedRotation(playerEntity.rotation, rotationInDegrees);
        weaponEntity.AddRotation(weaponRotation.x, weaponRotation.y);
        
        return weaponEntity;
    }
    
    public static GameEntity CreateBullet(this GameContext context, GameEntity weaponEntity)
    {
        var bulletEntity = context.CreateEntity();
        bulletEntity.isBullet = true;
        bulletEntity.isMovable = true;
        bulletEntity.AddPosition(weaponEntity.position.x, weaponEntity.position.y);
        bulletEntity.AddRotation(weaponEntity.rotation.x, weaponEntity.rotation.y);
        
        bulletEntity.AddSpeed(context.bulletSpeed.value); //3F
        bulletEntity.AddTimerTick(300F); //300F
        bulletEntity.AddTimerPassedTime(0F);
        bulletEntity.AddAsset("Bullet");

        return bulletEntity;
    }

    //TODO Can I return RotationComponent? 
    public static (float x, float y) CalculateAddedRotation(this RotationComponent currentRotation, float addingDegree)
    {
        var rad = (float)(Math.PI / 180F) * addingDegree;
        var cos = (float) Math.Cos(rad);
        var sin = (float) Math.Sin(rad);
        
        var rotationX = currentRotation.x * cos - currentRotation.y * sin;
        var rotationY = currentRotation.y * cos + currentRotation.x * sin;

        return (rotationX, rotationY);
    }
}