// I am folowing an Udemy course tring to get an object moving. https://www.udemy.com/course/augmented-reality-ar-with-unity-vuforia-for-android-ios/learn/lecture/15704296#content
// A compilation error is coming up however, saying "Assets\Scripts\FoodRecoScript.cs(21,25): error CS0246: The type or namespace name 'TrackableBehaviour' could not be found (are you missing a using directive or an assembly reference?)"
// looking at the forums, it looks like the turotial is using an old version of VUforia and it is no longer recognised .




using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class FoodRecoScript : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if(mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }

    public void OnTrackableStateChanged(
                        TrackableBehaviour.Status previousStatus,
                        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        
        {
            MoveFood.current.start = true;
        }
        else
        {
            MoveFood.current.start = false;
        
        }
    }                    
    
}
