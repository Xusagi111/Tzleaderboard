using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Data _data;

    void Start()
    {
        new GameInitialization(_data);
    }
}
