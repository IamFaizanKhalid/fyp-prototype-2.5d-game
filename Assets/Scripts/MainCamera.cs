using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Variables
    public Transform player;
    public float smooth;
    public float height;

    public Vector3 velocity = Vector3.zero;

    int moveX = 15;

    private Vector3 prevPosition = Vector3.zero;



    // Methods

    void Start()
    {
        prevPosition = player.position;
    }

    void Update()
    {
        Vector3 pos = this.transform.position;
        if (prevPosition.x < player.position.x)
            pos.x = player.position.x + moveX;
        else if (prevPosition.x > player.position.x)
            pos.x = player.position.x - moveX;
        prevPosition = player.position;
        //pos.y = player.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, smooth);
    }

}
