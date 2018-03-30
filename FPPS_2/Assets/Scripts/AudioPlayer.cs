using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour {

    private AudioSource beachSource;

    public AudioClip[] soundClips;


	// Use this for initialization
	void Start ()
    {
        beachSource = (AudioSource)GetComponent (typeof(AudioSource));
	}

    private void OnTriggerEnter(Collider collider)
    {
        AudioClip randomClip = soundClips[Random.Range(0, soundClips.Length)];

        beachSource.clip = randomClip; 
        beachSource.Play ();
    }

    // Update is called once per frame
    void Update () {
		
	}
}
