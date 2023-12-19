// The food is spawning ok, but it's going in strange directions. I want to make it move towards my character, 
//so I looked at this tutorial: https://www.youtube.com/watch?v=wp8m6xyIPtE and added in some code from that


//I am using this tutorial to learn how to spawn objects https://www.youtube.com/watch?v=aBzpvUXibw0
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class SpawnerScript : MonoBehaviour


//With a good nights sleep I decied to go back to figuring out how to spawn the objects. I looked at this youtube tutorial
//https://www.youtube.com/watch?v=EVZQJeGzs0U and added some code from that. 
{
    public GameObject item;
    public float delay = 2f;
    public float speed = 0.5f;
    float nextTimeToSpawn;
    [SerializeField] private GameObject Mouse1;

    // Start is called before the first frame update
    void Start()
    {
        nextTimeToSpawn = Time.time;
        
    } 

    void Update()
    {
        if (Time.time > nextTimeToSpawn)
        {
          nextTimeToSpawn = Time.time + delay;
          GameObject go = Instantiate(item, new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f)), Quaternion.identity);
          go.AddComponent<Move>();
          go.AddComponent<Move>().speed = speed; 
    }
    //I'm using this tutorial to see if I can spawn objects randomly https://www.youtube.com/watch?v=IbiwNnOv5So
    // its not working so i disabled it
    // {Vector3 randomSpawnPos = new Vector3(Random.Range(-5f, 5f), 0, Random.Range(-5f, 5f));}
}
}
public class Move : MonoBehaviour
{
    public float speed = 3f;
    void Update()

   
    {
       transform.position = Vector3.MoveTowards(transform.position, GameObject.Find("Mouse1").transform.position, speed * Time.deltaTime);
    }
    //void OnBecomeInvisible()
    //{
    //    Destroy(gameObject);
    //}
}