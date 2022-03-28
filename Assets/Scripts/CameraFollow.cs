using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour

{
    private Transform player;

    private Vector3 tempPos;

    [SerializeField]
    private float minX, MaxX;
    
    private
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(!player){
            return;
        }
        tempPos = transform.position;
        tempPos.x = player.position.x;

        if( tempPos.x < minX)
            tempPos.x = minX;
        
        if(tempPos.x > MaxX)   
            tempPos.x = MaxX;

        transform.position = tempPos;
    }
}
