using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {
    AudioSource audioSource;

    void Start() {
        audioSource = GetComponent<AudioSource>();

        if (audioSource != null && audioSource.clip != null) {
            audioSource.loop = true;
            audioSource.Play();
        } else {
            Debug.LogWarning("AudioSource or AudioClip is missing.");
        }
    }

    void Update() {
        if (!audioSource.isPlaying && gameObject.scene.isLoaded) {
            audioSource.Play();
        }
    }
}

