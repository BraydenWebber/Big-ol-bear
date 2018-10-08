using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject CurrentCheckPoint;
    private Rigidbody2D PC;

    //Particles
    public GameObject DeathParticle;
    public GameObject RespawnParticle;

    //Respawn Delay
    public float RespawnDelay;

    //Point Penalty on Death
    public int PointPenaltyOnDeath;

    //Store Gravity Value
    private float GravitySore;

	//Use this for initilization
	void Start()
	{
        PC = FindObjectOfType<Rigidbody2D>();
	}

    public void RespawnPlayer(){
        StartCoroutine("RespawnPlayerCo");
        
    }

    public IEnumerator RespawnPlayerCo(){
        //Generate Death Particle 
        Instantiate(DeathParticle, PC.transform.position, PC.transform.rotation);
        //Hide PC
        //PC.enabled = false
        PC.GetComponent<Renderer> ().enabled
    }
}