//I am using this tutorial to learn how to spawn objects https://www.youtube.com/watch?v=aBzpvUXibw0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnerScript : MonoBehaviour


//i want to change my code to an automatic spawn, rather than one that is triggered by a key press.
// I was getting an error saying "'Instantiate' does not exist in the current context" so I went to the Unity forums 
// and found this code (https://forum.unity.com/threads/instantiate-does-not-exist-in-the-current-context.48207/)
// I am still not happy with this as I dont want the player to have to press a button to spawn the object, I want it to spawn automatically.
  
  // Instantiate a rigidbody then set the velocity
{
    // Assign a Rigidbody component in the inspector to instantiate

    public Rigidbody projectile;

    void Update()
    {
        // Ctrl was pressed, launch a projectile
        if (Input.GetButtonDown("Fire1"))
        {
            // Instantiate the projectile at the position and rotation of this transform
            Rigidbody clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);

            // Give the cloned object an initial velocity along the current
            // object's Z axis
            clone.velocity = transform.TransformDirection(Vector3.forward * 10);
        }
    }
}