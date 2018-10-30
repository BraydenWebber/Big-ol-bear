using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    public PlayerControl Player;

    public bool isFollowing;

    //Camera position offset

    public float xOffset;

    public float yOffset;

    //Use this for Initialization

    void Start()
    {
        Player = FindObjectOfType<PlayerControl>();
        isFollowing = true;
    }

    //Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = new Vector3(Player.transform.position.x + xOffset, Player.transform.position.y + yOffset, transform, transform.position.z);

        }
    }

}

