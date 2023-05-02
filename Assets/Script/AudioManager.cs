using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSource;

    // Start is called before the first frame update
    private void Start()
    {
        PlayBGM();
    }

    public void PlayBGM() 
    {
        bgmAudioSource.Play();
    }
    public void PlaySFX(Vector3 spawnPosition) 
    {
        GameObject.Instantiate(sfxAudioSource, spawnPosition, Quaternion.identity);
    }

}
