using Entitas;
using UnityEngine;

public class Execute_ControllerSystem : IExecuteSystem
{
    readonly GameContext context;

    public Execute_ControllerSystem(Contexts contexts)
    {
        context = contexts.game;
    }

    public void Execute()
    {
        if (Input.GetKey(KeyCode.W))
        {
            context.CreateEntity().AddInput(KeyCode.W);
            if (Input.GetKey(KeyCode.A))
            {
                context.CreateEntity().AddInput(KeyCode.A);
            }
            if (Input.GetKey(KeyCode.D))
            {
                context.CreateEntity().AddInput(KeyCode.D);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            context.CreateEntity().AddInput(KeyCode.S);
            if (Input.GetKey(KeyCode.A))
            {
                context.CreateEntity().AddInput(KeyCode.A);
            }
            if (Input.GetKey(KeyCode.D))
            {
                context.CreateEntity().AddInput(KeyCode.D);
            }

        }

    }
}
