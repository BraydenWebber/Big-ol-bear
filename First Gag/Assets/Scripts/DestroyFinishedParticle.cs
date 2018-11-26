using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticle : MonoBehaviour {
    private ParticleSystem thisParicleSystem;

	// Use this for initialization
	void Start () {
        thisParicleSystem = GetComponent<ParticleSystem>();

	}
	
	// Update is called once per frame
	void Update () {
        if (thisParicleSystem.isPlaying)
            return;
        Destroy(gameObject);
	}

	void OnBecameInvisible()
	{
        Destroy(gameObject);
	}
}