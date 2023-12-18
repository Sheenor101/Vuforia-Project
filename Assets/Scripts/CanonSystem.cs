// I just wasn't getting the spawn system to work for me and there weren't many tutorials online, so I decided to use a different method.
//This is the script that comes with the canon from the viewforia starter kit. 
//I copied it, using this tutoorial from Youtube to help: https://www.youtube.com/watch?v=S1VrS05IxyQ&list=PLX2vGYjWbI0Thl0pOCbKWrbbiw7RWiRG7&index=4

using UnityEngine;
using UnityEngine.Events;

public class CanonSystem : MonoBehaviour
{
   
   [Header("Firing Properties")]
   public float maxProjectileForce = 18000f; //Maximum force of a projectile
   public float cooldown = 1f;

    [Header("Projectile Properties")]
    public GameObject projectilePrefab; //The projectile to be shot

    Transform projectileSpawnTransform; // Location where the projectiles should spawn
    bool canShoot = true;
    Animator anim;                      // Reference to the animator component

    void Awake()
    {
        //Get a reference to the projectile spawn point. By providing the path to the object like this we are making an
        //inefficient method call more efficient
        projectileSpawnTransform = GameObject.Find("Mouse1").transform;
    
    }

    public void FireProjectile()
    {
        if (!canShoot)
            return;

            GameObject go = (GameObject)Instantiate(projectilePrefab, projectileSpawnTransform.position, projectileSpawnTransform.rotation);
            Vector3 force = projectileSpawnTransform.transform.forward * maxProjectileForce;
            anim.SetTrigger ("Fire");
 
            canShoot = false;
            Invoke("CoolDown", cooldown);
    }

    void Cooldown()
    {
        canShoot = true;
    }
}
