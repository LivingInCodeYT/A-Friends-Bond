﻿using System;
using UnityEngine;

public class SFXManager : MonoBehaviour {
    public Sound[] sounds;

    void Awake() {
        DontDestroyOnLoad(gameObject);
        foreach (Sound s in sounds) {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.loop = s.loop;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
        }
    }
    public void Play(string name) {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null) {
            Debug.LogWarning("Sound " + s + " not found, please check it's spelling.");
        } else {
            s.source.Play();
        }
    }
}