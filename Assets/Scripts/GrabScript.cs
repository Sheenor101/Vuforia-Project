//I used naoise's tutorial to import the mixamo characters, then this old tutorial to make the character move at the press of a button on the interface
// https://www.youtube.com/watch?v=lCu4z7CNELA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabScript : MonoBehaviour
{
    public Animator myGrab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGrab()
    {
        myGrab.Play("Grab");
    }
    // The above tutorial creates two buttons - one to start the aniamtiona nd one to stop it. I only need one button so I have diabled the below code.
    //public void StopGrab()
   // {
    //    myGrab.Play("Grab");
   // }
}

