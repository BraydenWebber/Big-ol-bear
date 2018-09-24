using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

    public int pointsToAdd;

	void OnTriggerEnter2D (Collider2D other)
	{
        if (other.GetComponenent<Rigidbody2D>() == null)
            return;

                ScoreManager.AddPoints(pointsToAdd);
        Destroy(gameObject);



	}
}
