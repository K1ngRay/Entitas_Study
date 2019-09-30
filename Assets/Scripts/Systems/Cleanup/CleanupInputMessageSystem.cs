using UnityEngine;
using Entitas;

public class CleanupInputMessageSystem : ICleanupSystem
{
    readonly InputContext context;
    readonly IGroup<InputEntity> group;

    public CleanupInputMessageSystem(Contexts contexts)
    {
        this.context = contexts.input;
        group = context.GetGroup(InputMatcher.InputMessage);
    }
    public void Cleanup()
    {
        foreach (var item in group.GetEntities())
        {
            item.Destroy();
        }
    }
}
