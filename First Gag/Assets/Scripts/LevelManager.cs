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

    // Store Gravity Value

    private float GravitySore;

	// Use this for initialization
	void Start () {
        PC = FindObjectOfType<Rigidbody2D>();
	}
	
    public void RespawnPlayer(){
        StartCoroutine("RespawnPlayerCo");
		
	}
    public IEnumerator RespawnPlayerCo()
    {
        //Generate Death Particle
        Instantiate(DeathParticle, PC.transform.position, PC.transform.rotation);
        //Hide Player
        PC.enabled = false;
        PC.GetComponent<Renderer>().endabled = false;
        // Gravity Reset
        gravityStore = PC.GetComponent<Rigidbody2D>().gravityScale;
        PC.GetComponent<Rigidbody2D>().gravityScale = 0f;
        PC.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        //Point Penalty
        ScoreManager.AddPoints(-PointPenaltyOnDeath);
        //
    }




}


