using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class Initialize_CreateSystem : IInitializeSystem
{
    readonly GameObject car;

    public Initialize_CreateSystem(Contexts contexts,GameObject car)
    {
        this.car = car;
    }
    public void Initialize()
    {
        throw new System.NotImplementedException();
    }
}
