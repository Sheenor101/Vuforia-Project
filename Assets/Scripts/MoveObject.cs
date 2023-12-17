//followed Naoise's tutorial 2 and copilot for this
//i want to spawn an onject and make it move across the screen and to collide with the character. 
//not sure how to do this yet, but I will look for tutorials


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelDesign{




public class MoveObject : MonoBehaviour
{
    public Transform pointAtransform;
    public Transform pointBtransform;
    public float speed = 1.0f;

    private Vector3 pointA;
    private Vector3 pointB;
    private float journeyLength;
    private float startTime;
    // Start is called before the first frame update
    void Start()
    {
        if(pointAtransform && pointBtransform){
            pointA = pointAtransform.position;
            pointB = pointBtransform.position;
            journeyLength = Vector3.Distance(pointA, pointB);
            startTime = Time.time;
        }
        else{
            Debug.LogWarning("No points set");
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (pointAtransform && pointBtransform){
            float distCovered = (Time.time - startTime) * speed;
            float fracJourney = distCovered / journeyLength;
            transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(fracJourney, 1));
        }
    }
}
}