using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class InputMessageSystem : ReactiveSystem<InputEntity>
{

    public InputMessageSystem(Contexts contexts) : base(contexts.input)
    {

    }
    protected override void Execute(List<InputEntity> entities)
    {
        foreach (var item in entities)
        {
            Debug.Log(item.inputMessage.message);
        }
    }

    protected override bool Filter(InputEntity entity)
    {
        return entity.hasInputMessage;
    }

    protected override ICollector<InputEntity> GetTrigger(IContext<InputEntity> context)
    {
        return context.CreateCollector(InputMatcher.InputMessage);
    }
}
