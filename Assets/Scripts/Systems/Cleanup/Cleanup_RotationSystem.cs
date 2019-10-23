using Entitas;

public class Cleanup_RotationSystem : ICleanupSystem
{
    readonly GameContext context;
    readonly IGroup<GameEntity> rotations;

    public Cleanup_RotationSystem(Contexts contexts)
    {
        this.context = contexts.game;
        rotations = context.GetGroup(GameMatcher.Rotation);
    }
    public void Cleanup()
    {
        foreach (var item in rotations.GetEntities())
        {
            item.Destroy();
        }
    }
}
