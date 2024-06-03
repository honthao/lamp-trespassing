using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Start is called before the first frame update
    int phase;
    bool moving;
    int rotation;
    int direction;
    int magnitude;
    public GameObject model;
    void Start()
    {
        phase = 0;
        moving = true;
        direction = Random.Range(0, 2);
        magnitude = (int)model.transform.position.magnitude * 37;
        rotation = magnitude % 4 * 90;
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        phase += 1;
        if (moving)
        {
            if(magnitude % 2 == 0)
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
