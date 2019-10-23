using Entitas;

public class Cleanup_InputSystem : ICleanupSystem
{
    readonly GameContext context;
    readonly IGroup<GameEntity> inputs;
    public Cleanup_InputSystem(Contexts contexts)
    {
        this.context = contexts.game;
        inputs = context.GetGroup(GameMatcher.Input);

    }
    public void Cleanup()
    {
        foreach (var item in inputs.GetEntities())
        {
            item.Destroy();
        }
    }
}
