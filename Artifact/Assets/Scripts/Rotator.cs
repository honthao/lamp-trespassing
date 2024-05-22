using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    int phase;
    bool moving;
    int rotation;
    int direction;
    public GameObject model;
    void Start()
    {
        phase = 0;
        rotation = 0;
        moving = true;
        direction = Random.Range(0, 2);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        phase += 1;
        if (moving)
        {
            print(direction);
            if(direction == 0)
            {
                rotation += 3;
            } else
            {
                rotation -= 3;
            }
            
            if(rotation >= 360)
            {
                rotation = 0;
            }
            transform.rotation = Quaternion.Euler(0, rotation, 0);
            if(phase >= 30)
            {
                moving = false;
            }
        } else if(phase >= 60)
        {
            phase = 0;
            moving = true;
        }

    }
}
