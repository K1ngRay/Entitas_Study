using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Entitas;

public class Initialize_CreateSystem : IInitializeSystem
{
    readonly GameContext context;
    readonly GameObject prefab;

    public Initialize_CreateSystem(Contexts contexts,GameObject prefab,Transform transform)
    {
        this.context = contexts.game;
        this.prefab = prefab;
    }
    public void Initialize()
    {
        GameObject obj = GameObject.Instantiate(prefab);
    }
}
