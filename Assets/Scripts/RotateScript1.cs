/// this code was copied from a Udemy course. https://www.udemy.com/course/develop-augmented-reality-book-ar-business-card-with-unity/learn/lecture/8516356#overview


using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateScript : MonoBehaviour

{
    public int ydirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,ydirection,0) * Time.deltaTime);
        
    }
}
