//I am using this tutorial to learn how to spawn objects https://www.youtube.com/watch?v=aBzpvUXibw0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
   public GameObject foodPrefab;

//i want to change the below code to an automatic spawn, rather than one that is triggered by a key press
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            instantiate(foodPrefab, transform.position, Quaternion.identity);
        }
    }
     
    
}
