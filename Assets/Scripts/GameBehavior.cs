using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBehavior : MonoBehaviour
{
    public GameObject carPrefab;

    [SerializeField]
    private Transform car;
    private GameController gameController;
    void Awake()
    {
        gameController = new GameController(Contexts.sharedInstance, carPrefab, car);
    }

    void Start()
    {
        gameController.Initialize(Contexts.sharedInstance, car);
    }

    // Update is called once per frame
    void Update()
    {
        gameController.Execute();
    }
}
