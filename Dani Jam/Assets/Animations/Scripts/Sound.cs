using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound {
    public string name = "Untitled Sound";
    [HideInInspector]
    public AudioSource source;
    [Range(0f, 10f)]
    public float volume = 1f;
    [Range(0f, 2f)]
    public float pitch = 1f;
    public bool loop;
}