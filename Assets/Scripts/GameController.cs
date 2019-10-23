using Entitas;
using UnityEngine;

public class GameController {

    //readonly Systems tutorialSystems;
    readonly Systems carSystems;

    public GameController(Contexts contexts)
    {
        //tutorialSystems = new TutorialSystems(contexts);
    }
    public GameController(Contexts contexts, GameObject obj, Transform clone)
    {
        carSystems = new Feature_CarSystem(contexts, obj, clone);
    }

    public void Initialize(Contexts contexts,Transform clone)
    {
        //tutorialSystems.Initialize();
        carSystems.Initialize();
    }
	
	public void Execute()
    {
        //tutorialSystems.Execute();
        //tutorialSystems.Cleanup();
        carSystems.Execute();
        carSystems.Cleanup();
    }
}
