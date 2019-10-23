using Entitas;
public class Cleanup_PositionSystem : ICleanupSystem
{
    readonly GameContext context;
    readonly IGroup<GameEntity> positions;

    public Cleanup_PositionSystem(Contexts contexts)
    {
        this.context = contexts.game;
        positions = context.GetGroup(GameMatcher.Position);
    }

    public void Cleanup()
    {
        foreach (var item in positions.GetEntities())
        {
            item.Destroy();
        }
    }
}
