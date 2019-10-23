using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feature_CarSystem : Feature
{
    public Feature_CarSystem(Contexts contexts, GameObject carPrefab, Transform car)
    {
        Add(new Initialize_CreateSystem(contexts, carPrefab, car));
        Add(new Execute_ControllerSystem(contexts));
        Add(new Reactive_InputSystem(contexts));
        Add(new Reactive_PositionSystem(contexts));
        Add(new Reactive_RotationSystem(contexts));
        Add(new Cleanup_InputSystem(contexts));
        Add(new Cleanup_PositionSystem(contexts));
        Add(new Cleanup_RotationSystem(contexts));
    }
}
