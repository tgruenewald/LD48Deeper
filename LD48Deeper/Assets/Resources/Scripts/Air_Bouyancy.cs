using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air_Bouyancy : MonoBehaviour
{
    float buoy = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1f)
        {
            buoy = transform.position.y * -3;
            Vector2 dir = Vector2.up;
            transform.GetComponent<Rigidbody2D>().AddForce(dir * buoy);
        }
        else
        {
            buoy = 3f;
        }
    }
}
