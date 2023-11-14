using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imageTargetInteractons : MonoBehaviour
{
    //Making model rotate - Naoise's tutorial
    public float rotationSpeed = 45f;

    public Vector3 rotationVector = new Vector3(10f,0,0);

 
    private bool shouldRotate;

    // Update is called once per frame
    void Update()
    {
        HandleRotation();
    }
    public void ToggleRotation(bool status) => shouldRotate = status;

    private void HandleRotation()
    {
        if(!shouldRotate) return;

        transform.Rotate(rotationVector * rotationSpeed * Time.deltaTime);
    }
}
