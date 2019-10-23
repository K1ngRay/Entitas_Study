using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class Reactive_InputSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext context;
    public Reactive_InputSystem(Contexts contexts) : base(contexts.game)
    {
        this.context = contexts.game;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var item in entities)
        {
            KeyCode keyCode = item.input.keyCode;
            if(keyCode== KeyCode.W)
            {
                context.CreateEntity().AddPosition(new Vector3(0f, 0f, 1f));
            }
            if (keyCode == KeyCode.A)
            {
                context.CreateEntity().AddRotation(new Vector3(0f, -1f, 0f));
            }
            if (keyCode == KeyCode.S)
            {
                context.CreateEntity().AddPosition(new Vector3(0f, 0f, -1f));
            }
            if (keyCode == KeyCode.D)
            {
                context.CreateEntity().AddRotation(new Vector3(0f, 1f, 0f));
            }
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasInput;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Input);
    }
}
