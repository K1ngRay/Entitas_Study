using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{

    private GameController gameController;
    void Awake()
    {
        gameController = new GameController(Contexts.sharedInstance);
    }

    void Start()
    {
        gameController.Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        gameController.Execute();
    }
}
