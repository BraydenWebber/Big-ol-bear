using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    public float Speed;
    public float TimeOut;
    public GameObject PC;

    public GameObject EnemyDeath;

    public GameObject ProjectileParticle;

    public int PointsForKill;

    // Use this for initialization
    void Start()
    {
        PC = GameObject.Find("PC");

        EnemyDeath = Resources.Load("Prefabs/Death_PS") as GameObject;
        ProjectileParticle = Resources.Load("Prefabs/Respawn_PS") as GameObject;

        if (PC.transform.localScale.x < 0)
            Speed = -Speed;


        // Destroys Projectile after X sseconds
        Destroy(gameObject, TimeOut);

        // Speed = Speed * Mathf.Sign(PC.transform.localScale.x);

        // GetComponent<Rigidbody2D>().velocity = new Vector2(Speed + (PC.GetComponent<Rigidbody2D>().velocity.x/3),GetComponent<Rigidbody2D>().velocity.y + (PC.GetComponent<Rigidbody2D>().velocity.y/3));


    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(PointsForKill);
            Destroy(gameObject);
        }
        if (other.tag == "Wall")
        {
            Destroy(gameObject);
        }

    }

}