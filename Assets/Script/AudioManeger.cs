using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManeger : MonoBehaviour
{
    public Sound[] sounds;

    // Start is called before the first frame update
    private void Awake()
    {
        foreach (Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }

    public void playsound (string name)
    {
        Sound s = Array.Find(sounds, Sound => Sound.name == name);
        s.source.Play();
    }
}
