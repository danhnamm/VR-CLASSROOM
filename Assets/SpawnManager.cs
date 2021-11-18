using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager Instance;

    SpawnPoint[] spawnpoints;
     
    private void Awake()
    {
        Instance = this;
        spawnpoints = GetComponentsInChildren<SpawnPoint>();
    }

    public Transform GetSpawnpoints()
    {
        return spawnpoints[Random.Range(0, 6)].transform;
    }

}
