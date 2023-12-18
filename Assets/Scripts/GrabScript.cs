//I used naoise's tutorial to import the mixamo characters, then this old tutorial to make the character move at the press of a button on the interface
// https://www.youtube.com/watch?v=lCu4z7CNELA

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickScript : MonoBehaviour
{
    public Animator myKick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayKick()
    {
        myKick.Play("Kick");
    }
    public void StopKick()
    {
        myKick.Play("Idle");
    }
}

