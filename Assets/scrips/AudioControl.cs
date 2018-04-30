using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControl : MonoBehaviour {

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();        
    }

    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.P))
        {
            audioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            audioSource.Stop();
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            audioSource.Pause();
        }
    }
}
