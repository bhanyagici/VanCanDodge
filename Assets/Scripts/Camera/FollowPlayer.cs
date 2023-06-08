using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -8);


    // Update is called once per frame
    void LateUpdate() //For Camera
    {
        CameraFollow();
    }

    private void CameraFollow()
    {
        //Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
 
}
