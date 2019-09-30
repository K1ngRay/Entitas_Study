using UnityEngine;
using Entitas;

public class LogMouseClickSystem : IExecuteSystem
{
    readonly InputContext _context;

    public LogMouseClickSystem(Contexts contexts)
    {
        _context = contexts.input;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _context.CreateEntity().AddInputMessage("Left Mouse");
        }
        if (Input.GetMouseButtonDown(1))
        {
            _context.CreateEntity().AddInputMessage("Right Mouse");
        }
    }
}
