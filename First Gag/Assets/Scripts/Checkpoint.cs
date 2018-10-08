using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public LevelManager levelManager;
	//Use this for initilization
	private void Start()
	{
        levelManager = FindObjectOfType<LevelManager>();
	}

	// Update is called once per frame
	void Update()
	{
		
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
        if(other.name == "PC"){
            levelManager.CurrentCheckPoint = gameObject;
            Debug.Log("Activatedd Checkpoint" + transform.position);
        }
	}
}