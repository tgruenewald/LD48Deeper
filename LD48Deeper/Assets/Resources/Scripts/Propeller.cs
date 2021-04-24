using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propeller : MonoBehaviour
{
    public float thrust;
    public float efficency;
    public float energy; //this is a placeholder
    //public GameObject submarine;
    // Start is called before the first frame update
    void Start()
    {
        print(transform.GetComponentInParent<Submarine>().getEnergy());
        energy = transform.GetComponentInParent<Submarine>().getEnergy();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        energy = transform.GetComponentInParent<Submarine>().getEnergy();
        if (Input.GetKey(KeyCode.W) && energy > 0.0)
        {
            
            Vector2 dir = transform.GetComponent<Rigidbody2D>().GetRelativeVector(Vector2.up);
            transform.GetComponent<Rigidbody2D>().AddForce(dir * thrust);
            transform.GetComponentInParent<Submarine>().setEnergy(energy - efficency);
            print("vrrrooom");
        }
       
        
    }
}
