//I am using this tutorial to learn how to spawn objects https://www.youtube.com/watch?v=aBzpvUXibw0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class SpawnerScript : MonoBehaviour


//I went back to this code as the other was not working. CoPilot filled this in for me so I thought I would save and see what happened. 
// I then started messing around with the code to try and get the objects to move int he direction I want. Pure trial and error

{
    public GameObject[] obj;

    public float spawnMin = 1f;
    public float spawnMax = 2f;

    // Start is called before the first frame update
    void Begin()
    {
        Spawn();
        
    }

    void Spawn()
    {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spawn", Random.Range(spawnMin, spawnMax));
       
    }
}
  