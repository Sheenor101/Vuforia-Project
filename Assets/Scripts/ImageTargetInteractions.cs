//Naoise's tutorial  


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ImageTargetInteractions : MonoBehaviour
{
     public float rotationSpeed = 45f;
     public Vector3 rotationVector = new Vector3(10f,0,0);
     public Vector3 scaleChange; 
     public AudioSource sound;
     public AudioClip song;
     public TextMeshProUGUI textDisplay;

    
    private bool shouldRotate;
    private bool shouldScale;
    private bool shouldPlaySound;
    private bool shouldChangeText;

    // Update is called once per frame
    private void Update()
    {
        HandleRotation();
        HandleScaling();
        HandleSound();
        HandleTextChange();

    }

    public void ToggleRotation(bool status) => shouldRotate = status;
    public void ToggleScaling(bool status) => shouldScale = status;
    public void ToggleSound(bool status) => shouldPlaySound = status;
    public void ToggleTextChange(bool status) => shouldChangeText = status;

    private void HandleRotation()
    {
        if(!shouldRotate) return;

        transform.Rotate(rotationVector * rotationSpeed * Time.deltaTime);
    }
    private void HandleScaling ()
    {
        if(!shouldScale) return;
        transform.localScale += scaleChange * Time.deltaTime;

        if(transform.localScale.x < 0.1f || transform.localScale.x > 0.1f||
        transform.localScale.y < 0.1f || transform.localScale.y > 0.1f||
        transform.localScale.z < 0.1f || transform.localScale.z > 0.1f)
        {
            scaleChange = -scaleChange;
        }
    }
    private void HandleTextChange()
    {
        if (!shouldChangeText) return;

        textDisplay.text = "You Pressed a Button";
    }
    
    
    private void HandleSound()
    {
        if(sound.isPlaying)
        {
            Debug.Log("SOund is Playing");
            return;
        }
        if (shouldPlaySound)
        {
            sound.PlayOneShot(song);
        }
        else
        {
            sound.Stop();
        }
    }

}
