// I found this "Coin collection" tutorial on youtube. https://www.youtube.com/watch?v=6iSJ_jh6Rdo
// Trying it out to see if I can make my food dissappear when it collides with the character

using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class FoodCollection : MonoBehaviour

{
    private int Apple = 0;

private void OnTriggerEnter(Collider other)
{
    if (other.transform.tag == "Apple")
    {
        Apple++;
        Debug.Log(Apple);
        Destroy(other.gameObject);
    }
}
} 
