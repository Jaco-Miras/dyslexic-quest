using System;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public Sound[] sounds;    

    // Start is called before the first frame update
    void Awake()
    {
        foreach (Sound s in sounds)
        {
           s.source = gameObject.AddComponent<AudioSource>();
           s.source.clip = s.clip;

           s.source.volume = s.volume;
           s.source.pitch = s.pitch;
           Debug.Log("Sound is " + s.name);
        }
    }

    public void Play (string name)
    {
        Debug.Log(name);
        Sound s = Array.Find(sounds, sound => sound.name == name);
        Debug.Log("Final Sound is " + s.name);
        s.source.Play();
    }
}
