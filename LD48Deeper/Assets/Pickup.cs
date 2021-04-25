using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("there");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        print("heare");
        if(other.transform.CompareTag("Teasure"))
        {
            print("Picked up");
            other.transform.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
        }
        
    }
}
