using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PointerClick()
    {
        player.transform.position = new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
