using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcMove : MonoBehaviour
{
    private float npcSpeed = 40.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveNpc();
    }

    private void MoveNpc()
    {
        transform.Translate(Vector3.forward * npcSpeed * Time.deltaTime);
    }
}
