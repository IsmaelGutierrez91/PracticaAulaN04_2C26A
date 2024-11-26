using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode upKeyToMove;
    public KeyCode downKeyToMove;
    public float yDirectionToMove;
    public float ySpeedMovement;
    public float yMinLimitToMove;
    public float yMaxLimitToMove;
    private float yPosition;
    public string playerType;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(downKeyToMove))
        {
            yDirectionToMove = 0;
        }else if(Input.GetKeyUp(downKeyToMove))
        {
            yDirectionToMove = 5;
        }
        if (Input.GetKeyDown(downKeyToMove))
        {
            yDirectionToMove = -40;
        }
        yPosition = Math.Clamp(transform.position.y - ySpeedMovement + yDirectionToMove - Time.deltaTime,
            yMaxLimitToMove, yMinLimitToMove);
        transform.position = new Vector3(yPosition, transform.position.z);
    }
}