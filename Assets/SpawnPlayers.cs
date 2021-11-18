using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;

    private void Start()
    {

        Transform  spawnpoint = SpawnManager.Instance.GetSpawnpoints();
      //  Vector3 spawnPos = new Vector3(2.19f, 4.167f, -0.729f);       
        PhotonNetwork.Instantiate(playerPrefab.name, spawnpoint.position, spawnpoint.rotation,0);
       
    }
    private void Update()
    {
    
    }

}
