using Entitas;
using UnityEngine;

public class GameController {

    readonly Systems _systems;

    public GameController(Contexts contexts)
    {
        _systems = new TutorialSystems(contexts);
    }

	public void Initialize()
    {                    
        _systems.Initialize();
	}
	
	public void Execute()
    {
        _systems.Execute();
        _systems.Cleanup();
	}
}
