using Entitas;
using System.Collections.Generic;
using UnityEngine;

public class Reactive_RotationSystem : ReactiveSystem<GameEntity>
{
    readonly GameContext context;
    Transform transform;
    public Reactive_RotationSystem(Contexts contexts) : base(contexts.game)
    {
        this.context = contexts.game;
        this.transform = transform;
        
    }
    protected override void Execute(List<GameEntity> entities)
    {
        transform = GameObject.Find("Car(Clone)").transform;
        foreach (var item in entities)
        {
            transform.Rotate(item.rotation.rotation);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasRotation;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Rotation);
    }
}
