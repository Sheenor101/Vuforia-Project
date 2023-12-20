//I folowed Naoise's lecture no. 6 on game managers for this code. Copilot also helped.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameManagers{
    public class AudioManager : MonoBehaviour
    {
        public static AudioManager Instance;

        public AudioSource audioPlay;
        public AudioClip[] soundEffects;

        private void Awake(){
            if(Instance == null)
            {
                Instance = this;
                 DontDestroyOnLoad(gameObject);
            }
            else if (Instance != this)
            {
                Destroy(gameObject);
                return;
            }

            audioPlay = GetComponent<AudioSource>();
           
        }

    public void PlaySoundEffect(string clipName)
    {
        AudioClip clip = FindClipByName(clipName);
        if(clip != null)
        {
            audioPlay.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError("No clip with name " + clipName + " found in soundEffects array!");
        }
    }

    private AudioClip FindClipByName(string clipName)
    {
        foreach(AudioClip clip in soundEffects)
        {
            if(clip.name == clipName)
            {
                return clip;
            }
        }
        return null;
    }
}
}