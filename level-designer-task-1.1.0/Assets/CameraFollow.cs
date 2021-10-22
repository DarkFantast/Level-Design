using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player; // тут объект игрока
    private Vector3 offset; 

    void Start () 
    {
        player = GameObject.FindWithTag ("Player");        
        offset = transform.position - player.transform.position;
    }

    void FixedUpdate () 
    {        
        transform.position = player.transform.position + offset;
    }

}
